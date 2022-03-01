using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coop_builder
{
    public class BuildUtil
    {
        private LogUtil logUtil = null;
        private DirUtil dirUtil = null;
        public string stage = "init";

        public BuildUtil(LogUtil logUtil, DirUtil dirUtil)
        {
            this.logUtil = logUtil;
            this.dirUtil = dirUtil;
        }

        private void SetStage(string stage)
        {
            logUtil.Log("\nStage: '" + stage + "'", LogUtil.stage);
            this.stage = stage;
        }

        private async Task DownloadAsync(string url, string dest)
        {
            logUtil.Log("\nDownloading '" + url + "'", LogUtil.section);

            using (var client = new WebClient())
            {
                if (File.Exists(dest)) { await Task.Run(() => File.Delete(dest)); }
                //client.DownloadProgressChanged += (s, e) => progressBar.Value = Math.Clamp(e.ProgressPercentage, progressBar.Minimum, progressBar.Maximum);
                await client.DownloadFileTaskAsync(url, dest);
                client.DownloadFileCompleted += (s, e) => logUtil.Log("Completed download of '" + url + "'", LogUtil.section);
            }
        }

        private async Task DirectoryMoveAsync(string source, string dest)
        {
            logUtil.Log("\nMoving '" + source + "'", LogUtil.section);
            await Task.Run(() => Directory.Move(source, dest));
            logUtil.Log("Finished moving '" + source + "'", LogUtil.section);
        }

        private async Task UnzipAsync(string source, string dest)
        {
            logUtil.Log("\nExtracting '" + source + "'", LogUtil.section);
            await Task.Run(() => ZipFile.ExtractToDirectory(source, dest));
            logUtil.Log("Finished extracting '" + source + "'", LogUtil.section);
        }

        private async Task DeleteFileAsync(string source)
        {
            if (!File.Exists(source)) { return; }
            await Task.Run(() => File.Delete(source));
            logUtil.Log("Deleted '" + source + "'", LogUtil.section);
        }

        private async Task DeleteDirectoryAsync(string source)
        {
            if (!Directory.Exists(source)) { return; }
            if (source.Length == 0)    { throw new Exception("Invalid directory: " + source); }
            if (source.Contains("..")) { throw new Exception("Invalid directory: " + source); }

            logUtil.Log("\nDeleting directory '" + source + "'", LogUtil.section);
            await Task.Run(() => Directory.Delete(source, true));
            logUtil.Log("Deleted directory '" + source + "'", LogUtil.section);
        }

        private async Task CopyFileAsync(string source, string dest)
        {
            logUtil.Log("\nCopying '" + source + "'", LogUtil.section);
            if (!File.Exists(source))
            {
                throw new Exception("Could not find file " + source);
            }
            await Task.Run(() => File.Copy(source, dest, true));
        }

        private async Task CopyDirectoryAsync(string source, string dest)
        {
            if (source.Contains("\\.git")) { return; }

            logUtil.Log("\nCopying '" + source + "'", LogUtil.section);

            if (!Directory.Exists(source)) { throw new Exception("Could not find directory: " + source); }

            DirectoryInfo sourceDir = new DirectoryInfo(source);
            DirectoryInfo destDir = new DirectoryInfo(dest);
            Directory.CreateDirectory(dest);

            // copy files in that directory
            foreach (FileInfo file in sourceDir.EnumerateFiles())
            {
                string dirPath = sourceDir.FullName;
                string outputPath = dirPath.Replace(sourceDir.FullName, destDir.FullName + "\\");
                using (FileStream SourceStream = file.OpenRead())
                {
                    using (FileStream DestinationStream = File.Create(outputPath + "\\" + file.Name))
                    {
                        await SourceStream.CopyToAsync(DestinationStream);
                    }
                }
            }

            // copy folders in that directory
            foreach (DirectoryInfo dirInfo in sourceDir.GetDirectories("*", SearchOption.AllDirectories))
            {
                string dirPath = dirInfo.FullName;
                if (dirPath.Contains("\\.git")) { continue; }
                string outputPath = dirPath.Replace(sourceDir.FullName, destDir.FullName + "\\");
                Directory.CreateDirectory(outputPath);
                logUtil.Log("  - " + dirPath.Replace(sourceDir.FullName, ""), LogUtil.subSection);

                foreach (FileInfo file in dirInfo.EnumerateFiles())
                {
                    using (FileStream SourceStream = file.OpenRead())
                    {
                        using (FileStream DestinationStream = File.Create(outputPath + "\\" + file.Name))
                        {
                            await SourceStream.CopyToAsync(DestinationStream);
                        }
                    }
                }
            }

            logUtil.Log("Finished copying '" + source + "'", LogUtil.section);
        }

        private Task<int> RunProgramInternal(string filename, string arguments, string workingDirectory, string path)
        {
            var tcs = new TaskCompletionSource<int>();

            logUtil.Log("\nRunning '" + filename + "'" + " '" + arguments + "'", LogUtil.section);

            Process p = new Process();

            p.StartInfo.FileName = filename;
            p.StartInfo.Arguments = arguments;
            p.StartInfo.WorkingDirectory = workingDirectory;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.EnvironmentVariables["PATH"] = path;
            System.Environment.SetEnvironmentVariable("path", path);

            p.EnableRaisingEvents = true;

            p.OutputDataReceived += new DataReceivedEventHandler((s, e) =>
            {
                logUtil.Log(e.Data, LogUtil.subSection);
            });

            p.ErrorDataReceived += new DataReceivedEventHandler((s, e) =>
            {
                logUtil.Log(e.Data, LogUtil.error);
            });

            p.Exited += (sender, args) =>
            {
                tcs.SetResult(p.ExitCode);
                p.Dispose();
                logUtil.Log("Finished running '" + filename + "'", LogUtil.section);
            };

            p.Start();

            p.BeginErrorReadLine();
            p.BeginOutputReadLine();

            return tcs.Task;
        }

        private async Task RunProgram(string filename, string arguments, string workingDirectory, string path)
        {
            await RunProgramInternal(filename, arguments, workingDirectory, path);
        }

        private async Task DownloadAndExecuteNewCompiler(string currentExePath, string compilerUrl, string compilerPath, bool buildDirectX)
        {
            await DownloadAsync(compilerUrl, compilerPath);

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = compilerPath,
                WorkingDirectory = Environment.CurrentDirectory,
                Arguments = "--update-compiler \"" + Environment.CurrentDirectory + "\" \"" + currentExePath + "\"" + (buildDirectX ? " --directx" : ""),
            };
            await Task.Run(() => Process.Start(startInfo));
        }

        private async Task CopyCompiler(CmdlineUtil cmdlineUtil)
        {
            SetStage("copy new compiler");
            int iterations = 20;

            for (int i = 0; i < iterations; i++)
            {
                try
                {
                    await Task.Run(() => File.Copy(cmdlineUtil.currentExePath, cmdlineUtil.oldExePath, true));
                    break;
                }
                catch (Exception ex)
                {
                    if (i >= iterations - 1)
                    {
                        logUtil.Log("Exception: " + ex.ToString(), LogUtil.error);
                        return;
                    }
                    else
                    {
                        await Task.Delay(250);
                    }
                }
            }
        }

        public async Task<bool> BuildAsync(bool buildDirectX)
        {
            logUtil.StartThread();

            CmdlineUtil cmdlineUtil = CmdlineUtil.Get();
            bool ret = true;

            if (cmdlineUtil.isUpdatedCompiler)
            {
                await CopyCompiler(cmdlineUtil);
            }

            try
            {
                bool is64bit = Environment.Is64BitOperatingSystem;

                // cleanup old files
                SetStage("cleanup old files");
                string binDir = dirUtil.WritePathNear("bin");
                string downloadsDir = dirUtil.WritePath("downloads");
                string environmentDir = dirUtil.WritePath("environment");
                string tmpDir = dirUtil.WritePath("tmp");
                string coopCompilerNewPath = dirUtil.UpdatedCompilerUrl();
                await DeleteDirectoryAsync(binDir);
                await DeleteDirectoryAsync(environmentDir);
                await DeleteDirectoryAsync(downloadsDir);
                await DeleteDirectoryAsync(tmpDir);
                if (!cmdlineUtil.isUpdatedCompiler)
                {
                    await DeleteFileAsync(coopCompilerNewPath);
                }

                // create directories
                SetStage("creating directories");
                Directory.CreateDirectory(downloadsDir);
                Directory.CreateDirectory(tmpDir);
                Directory.CreateDirectory(binDir);

                // checking compiler version
                if (!cmdlineUtil.isUpdatedCompiler)
                {
                    SetStage("checking compiler version");
                    string remoteVersion = await RestUtil.GetSloppyAsync(RepoUtil.releaseApiUrl, "tag_name");
                    if (remoteVersion != null && !MiscUtil.VersionCheck(remoteVersion))
                    {
                        SetStage("downloading new compiler version");
                        string compilerUrl = RepoUtil.releaseExeUrl;
                        string compilerPath = coopCompilerNewPath;
                        await DownloadAndExecuteNewCompiler(cmdlineUtil.currentExePath, compilerUrl, compilerPath, buildDirectX);
                        logUtil.EndThread();
                        Application.Exit();
                    }
                }

                // download environment
                SetStage("download and extract environment");
                string envUrl = is64bit ? RepoUtil.environmentUrl64 : RepoUtil.environmentUrl32;
                string envZip = downloadsDir + @"\environment.zip";
                string tmpEnvDir = is64bit ? dirUtil.WritePath(RepoUtil.tmpEnvironment64) : dirUtil.WritePath(RepoUtil.tmpEnvironment32);
                await DeleteDirectoryAsync(tmpEnvDir);
                await DownloadAsync(envUrl, envZip);
                await UnzipAsync(envZip, environmentDir + "\\..");
                await DeleteFileAsync(envZip);
                await DirectoryMoveAsync(tmpEnvDir, environmentDir);

                // download source code
                SetStage("download and extract source");
                string coopUrl = RepoUtil.game.ZipUrl();
                string coopZip = downloadsDir + @"\game.zip";
                await DownloadAsync(coopUrl, coopZip);
                await UnzipAsync(coopZip, environmentDir);
                await DeleteFileAsync(coopZip);

                // copy over certain files
                SetStage("override files");
                string copySrc = environmentDir + @"\copy-over";
                string copyDst = environmentDir + "\\" + RepoUtil.game.ExtractedFolder();
                await CopyDirectoryAsync(copySrc, copyDst);

                // copy rom
                SetStage("copy rom");
                string romSrc = dirUtil.romPath;
                string romDst = environmentDir + "\\" + RepoUtil.game.ExtractedFolder() + @"\baserom.us.z64";
                await CopyFileAsync(romSrc, romDst);

                // run make
                SetStage("making build");
                string workingDir = environmentDir + "\\" + RepoUtil.game.ExtractedFolder();
                string pathDir = environmentDir + @"\bin";
                string makeParams = "WINDOWS_AUTO_BUILDER=1 -j2";
                if (buildDirectX) { makeParams = "RENDER_API=D3D11 WINDOW_API=DXGI " + makeParams; }
                if (is64bit) { makeParams += " TARGET_BITS=64"; } else { makeParams += " TARGET_BITS=32"; }
                await RunProgram(
                    @"make.exe",
                    makeParams,
                    workingDir,
                    pathDir
                    );

                // check and copy build
                SetStage("copying build");
                string buildDir = environmentDir + "\\" + RepoUtil.game.ExtractedFolder() + @"\build\us_pc";
                string exePath = buildDir + @"\sm64.us.f3dex2e.exe";
                if (!File.Exists(exePath)) { throw new Exception("Could not find exe") ; }
                foreach (string f in Directory.GetFiles(buildDir))
                {
                    if (f.ToLower().EndsWith(".exe") || f.ToLower().EndsWith(".dll") || f.ToLower().EndsWith(".map"))
                    {
                        string[] spl = f.Replace("\\", "/").Split('/');
                        string filename = spl[spl.Length - 1];
                        await CopyFileAsync(f, binDir + "\\" + filename);
                    }
                }
                dirUtil.FindFiles();
                if (dirUtil.exePath == null)
                {
                    throw new Exception("Could not find exe after copy");
                }

                // copy mods
                string modDirSrc = buildDir + @"\mods";
                string modDirDst = binDir + @"\mods";
                await CopyDirectoryAsync(modDirSrc, modDirDst);

                // add intel HD fix
                // performance is god awful. wtf is this dll, software opengl implementation?
                // disabled for now
                /*
                if (MiscUtil.IsIntelHd())
                {
                    SetStage("getting opengl fix for intel hd");
                    string intelUrl = is64bit ? RepoUtil.intelHdFix64 : RepoUtil.intelHdFix32;
                    string intelPath = binDir + @"\opengl32.dll";
                    await DownloadAsync(intelUrl, intelPath);
                }*/

                // cleanup
                SetStage("cleanup");
                await DeleteDirectoryAsync(environmentDir);
                await DeleteDirectoryAsync(downloadsDir);
                await DeleteDirectoryAsync(tmpDir);

                SetStage("done");
            }
            catch (Exception ex)
            {
                logUtil.Log("\nException: " + ex.ToString(), LogUtil.error);
                ret = false;
            }
            finally
            {
                logUtil.EndThread();
            }
            

            return ret;
        }
    }
}
