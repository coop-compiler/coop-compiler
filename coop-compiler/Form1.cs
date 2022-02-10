using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;

namespace coop_builder
{
    public partial class Form1 : Form
    {
        private LogUtil logUtil = null;
        private DirUtil dirUtil = null;
        private BuildUtil buildUtil = null;
        private string discordUrl = "https://discord.gg/eXhpSRhCyM";

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Size = new Size(600, 450);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        private void ShowPanel(Panel panel)
        {
            if (panel != null)
            {
                panel.Visible = true;
            }

            foreach (Panel p in this.Controls)
            {
                if (p == panel) { continue; }
                p.Dock = DockStyle.Fill;
                p.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowPanel(null);
            logUtil = new LogUtil(this, this.rtbOutput, this.customProgressBar1);
            dirUtil = new DirUtil();
            buildUtil = new BuildUtil(logUtil, dirUtil);

            rtbOutput.ForeColor = LogUtil.subSection;

            MiscUtil.IsIntelHd();

            if (dirUtil.exePath != null)
            {
                ShowPanel(panelMain);
                return;
            }

            if (dirUtil.romPath != null)
            {
                // check if we're in the process of updating the compiler
                CmdlineUtil cmdlineUtil = CmdlineUtil.Get();
                if (cmdlineUtil.isUpdatedCompiler)
                {
                    _ = StartBuildAsync();
                    return;
                }
                lblRomIncorrect.Visible = false;
                pctRom.Visible = true;
                lblRomHeader.Text = "Rom Found";
                btnRom.Text = "Compile";
            }
            ShowPanel(panelRom);
        }

        private void Form1_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
        }

        private async Task StartBuildAsync()
        {
            ShowPanel(panelBuild);
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            bool built = await buildUtil.BuildAsync();
            if (!built)
            {
                lblFailedDescription.Text = "The build failed during '" + buildUtil.stage + "'\n\nPost the log to the #help-desk channel";
                ShowPanel(panelFailed);
            }
            else
            {
                ShowPanel(panelSuccess);
            }
        }

        private async void btnUpdate_ClickAsync(object sender, EventArgs e)
        {
            if (dirUtil.romPath == null)
            {
                ShowPanel(panelRom);
                return;
            }

            await StartBuildAsync();
        }

        private void btnRom_Click(object sender, EventArgs e)
        {
            // if rom is already found, just build
            if (dirUtil.romPath != null)
            {
                _ = StartBuildAsync();
                return;
            }

            // get filename from dialog
            string romFilename = "";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Super Mario 64 rom (*.z64)|*.z64";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() != DialogResult.OK) { return; }
                romFilename = openFileDialog.FileName;
            }

            // check sha
            if (!MiscUtil.ValidRom(romFilename))
            {
                pctRom.Visible = false;
                lblRomIncorrect.Visible = true;
                return;
            }

            // copy rom
            string dstDir = dirUtil.WritePath("rom");
            string dstPath = dstDir + "\\baserom.us.z64";
            Directory.CreateDirectory(dstDir);
            File.Copy(romFilename, dstPath, true);
            dirUtil.FindFiles();

            // build
            lblRomIncorrect.Visible = false;
            _ = StartBuildAsync();
        }

        private void pctDiscord_Click(object sender, EventArgs e)
        {
            MiscUtil.OpenUrl(discordUrl);
        }

        private void btnFailedDiscord_Click(object sender, EventArgs e)
        {
            MiscUtil.OpenUrl(discordUrl);
        }

        private void btnFailedSaveLog_Click(object sender, EventArgs e)
        {
            // get filename from dialog
            string logFilename = "";
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Compile Log (*.rtf)|*.rtf";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                if (saveFileDialog.ShowDialog() != DialogResult.OK) { return; }
                logFilename = saveFileDialog.FileName;
            }

            // save log
            rtbOutput.SaveFile(logFilename);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = dirUtil.exePath,
                WorkingDirectory = Path.GetDirectoryName(dirUtil.exePath),
            };
            Process.Start(startInfo);
            Application.Exit();
        }
    }
}
