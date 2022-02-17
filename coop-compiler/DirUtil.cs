using System;
using System.IO;

namespace coop_builder
{
    public class DirUtil
    {
        private string[] searchPaths;
        private string writeDir = null;
        private string writeNearDir = null;
        public string exePath = null;
        public string romPath = null;

        public DirUtil()
        {
            CmdlineUtil cmdlineUtil = CmdlineUtil.Get();

            searchPaths = new string[2];
            searchPaths[0] = cmdlineUtil.workingDir;
            searchPaths[1] = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\coop-compiler";
            Directory.CreateDirectory(searchPaths[1]);

            foreach (string path in searchPaths)
            {
                if (path == null) { continue; }
                if (path.Length == 0) { continue; }
                if (!IsDirectoryWritable(path)) { continue; }
                if (writeNearDir == null) { writeNearDir = path; }
                writeDir = path;
            }

            if (writeDir == null)
            {
                throw new Exception("could not find a suitable write path");
            }

            FindFiles();
        }

        private string FindFile(string filename)
        {
            foreach (string path in searchPaths)
            {
                if (path == null) { continue; }
                if (path.Length == 0) { continue; }
                string s = path + "\\" + filename;
                if (File.Exists(s))
                {
                    return s;
                }
            }

            return null;
        }

        public void FindFiles()
        {
            exePath = FindFile("bin\\sm64.us.f3dex2e.exe");
            romPath = FindFile("rom\\baserom.us.z64");
            if (romPath != null && !MiscUtil.ValidRom(romPath))
            {
                romPath = null;
            }
        }

        private bool IsDirectoryWritable(string dirPath, bool throwIfFails = false)
        {
            // taken from stack overflow user priit: https://stackoverflow.com/a/6371533
            try
            {
                var path = Path.Combine(dirPath, Path.GetRandomFileName());
                using (FileStream fs = File.Create(path, 1, FileOptions.DeleteOnClose)) { }
                return true;
            }
            catch
            {
                if (throwIfFails) { throw; }
                else { return false; }
            }
        }

        public string WritePath(string path)
        {
            return writeDir + "\\" + path;
        }

        public string WritePathNear(string path)
        {
            return writeNearDir + "\\" + path;
        }

        public string UpdatedCompilerUrl()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\coop-compiler\\coop-compiler-new.exe";
        }
    }
}
