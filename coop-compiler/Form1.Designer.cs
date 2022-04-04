
namespace coop_builder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBuild = new System.Windows.Forms.Panel();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.customProgressBar1 = new coop_builder.CustomProgressBar();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pctDiscord = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.panelRom = new System.Windows.Forms.Panel();
            this.pctRom = new System.Windows.Forms.PictureBox();
            this.lblRomIncorrect = new System.Windows.Forms.Label();
            this.lblRomHeader = new System.Windows.Forms.Label();
            this.panelRomBottom = new System.Windows.Forms.Panel();
            this.btnRom = new System.Windows.Forms.Button();
            this.panelSuccess = new System.Windows.Forms.Panel();
            this.lblSuccessDescription = new System.Windows.Forms.Label();
            this.lblSuccessTitle = new System.Windows.Forms.Label();
            this.panelSuccessBottom = new System.Windows.Forms.Panel();
            this.btnSuccessPlay = new System.Windows.Forms.Button();
            this.panelFailed = new System.Windows.Forms.Panel();
            this.lblFailedDescription = new System.Windows.Forms.Label();
            this.lblFailedHeader = new System.Windows.Forms.Label();
            this.panelFailedBottom = new System.Windows.Forms.Panel();
            this.btnFailedDiscord = new System.Windows.Forms.Button();
            this.btnFailedSaveLog = new System.Windows.Forms.Button();
            this.panelRenderer = new System.Windows.Forms.Panel();
            this.panelOGL = new System.Windows.Forms.Panel();
            this.lblOGL = new System.Windows.Forms.Label();
            this.btnOpenGL = new System.Windows.Forms.Button();
            this.panelDX = new System.Windows.Forms.Panel();
            this.lblDX = new System.Windows.Forms.Label();
            this.btnDirectX11 = new System.Windows.Forms.Button();
            this.lblRendererTitle = new System.Windows.Forms.Label();
            this.panelRuntime = new System.Windows.Forms.Panel();
            this.lblRuntime = new System.Windows.Forms.Label();
            this.lblRuntimeTitle = new System.Windows.Forms.Label();
            this.panelRuntimeBottom = new System.Windows.Forms.Panel();
            this.btnRuntime = new System.Windows.Forms.Button();
            this.panelBuild.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctDiscord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.panelRom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctRom)).BeginInit();
            this.panelRomBottom.SuspendLayout();
            this.panelSuccess.SuspendLayout();
            this.panelSuccessBottom.SuspendLayout();
            this.panelFailed.SuspendLayout();
            this.panelFailedBottom.SuspendLayout();
            this.panelRenderer.SuspendLayout();
            this.panelOGL.SuspendLayout();
            this.panelDX.SuspendLayout();
            this.panelRuntime.SuspendLayout();
            this.panelRuntimeBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBuild
            // 
            this.panelBuild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.panelBuild.Controls.Add(this.rtbOutput);
            this.panelBuild.Controls.Add(this.customProgressBar1);
            this.panelBuild.Location = new System.Drawing.Point(465, 8);
            this.panelBuild.Name = "panelBuild";
            this.panelBuild.Size = new System.Drawing.Size(454, 325);
            this.panelBuild.TabIndex = 3;
            // 
            // rtbOutput
            // 
            this.rtbOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(4)))), ((int)(((byte)(5)))));
            this.rtbOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbOutput.Font = new System.Drawing.Font("Consolas", 9F);
            this.rtbOutput.ForeColor = System.Drawing.Color.White;
            this.rtbOutput.HideSelection = false;
            this.rtbOutput.Location = new System.Drawing.Point(0, 0);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ReadOnly = true;
            this.rtbOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbOutput.Size = new System.Drawing.Size(454, 302);
            this.rtbOutput.TabIndex = 3;
            this.rtbOutput.Text = "";
            this.rtbOutput.WordWrap = false;
            // 
            // customProgressBar1
            // 
            this.customProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.customProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.customProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.customProgressBar1.Location = new System.Drawing.Point(0, 302);
            this.customProgressBar1.Name = "customProgressBar1";
            this.customProgressBar1.Size = new System.Drawing.Size(454, 23);
            this.customProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.customProgressBar1.TabIndex = 9;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelMain.BackgroundImage = global::coop_builder.Properties.Resources.background;
            this.panelMain.Controls.Add(this.btnUpdate);
            this.panelMain.Controls.Add(this.pctDiscord);
            this.panelMain.Controls.Add(this.btnPlay);
            this.panelMain.Controls.Add(this.pctLogo);
            this.panelMain.Location = new System.Drawing.Point(8, 8);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(454, 325);
            this.panelMain.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(80)))));
            this.btnUpdate.Location = new System.Drawing.Point(24, 252);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(27, 28, 27, 28);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(174, 49);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_ClickAsync);
            // 
            // pctDiscord
            // 
            this.pctDiscord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pctDiscord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctDiscord.Image = global::coop_builder.Properties.Resources.Discord_Logo_Wordmark_Color2;
            this.pctDiscord.Location = new System.Drawing.Point(24, 196);
            this.pctDiscord.Name = "pctDiscord";
            this.pctDiscord.Size = new System.Drawing.Size(164, 45);
            this.pctDiscord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctDiscord.TabIndex = 6;
            this.pctDiscord.TabStop = false;
            this.pctDiscord.Click += new System.EventHandler(this.pctDiscord_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.btnPlay.Location = new System.Drawing.Point(253, 252);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(27, 28, 27, 28);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(174, 49);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pctLogo
            // 
            this.pctLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pctLogo.Image = global::coop_builder.Properties.Resources.logo22;
            this.pctLogo.Location = new System.Drawing.Point(0, 0);
            this.pctLogo.Margin = new System.Windows.Forms.Padding(27, 55, 27, 28);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(454, 325);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctLogo.TabIndex = 5;
            this.pctLogo.TabStop = false;
            // 
            // panelRom
            // 
            this.panelRom.BackgroundImage = global::coop_builder.Properties.Resources.background;
            this.panelRom.Controls.Add(this.pctRom);
            this.panelRom.Controls.Add(this.lblRomIncorrect);
            this.panelRom.Controls.Add(this.lblRomHeader);
            this.panelRom.Controls.Add(this.panelRomBottom);
            this.panelRom.Location = new System.Drawing.Point(8, 343);
            this.panelRom.Name = "panelRom";
            this.panelRom.Size = new System.Drawing.Size(454, 325);
            this.panelRom.TabIndex = 5;
            // 
            // pctRom
            // 
            this.pctRom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pctRom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctRom.Image = global::coop_builder.Properties.Resources.rom;
            this.pctRom.Location = new System.Drawing.Point(0, 96);
            this.pctRom.Name = "pctRom";
            this.pctRom.Size = new System.Drawing.Size(454, 135);
            this.pctRom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctRom.TabIndex = 6;
            this.pctRom.TabStop = false;
            // 
            // lblRomIncorrect
            // 
            this.lblRomIncorrect.BackColor = System.Drawing.Color.Transparent;
            this.lblRomIncorrect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRomIncorrect.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.lblRomIncorrect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.lblRomIncorrect.Location = new System.Drawing.Point(0, 96);
            this.lblRomIncorrect.Name = "lblRomIncorrect";
            this.lblRomIncorrect.Size = new System.Drawing.Size(454, 135);
            this.lblRomIncorrect.TabIndex = 5;
            this.lblRomIncorrect.Text = "Incorrect ROM file!\r\n\r\nMust be the United States release.\r\n";
            this.lblRomIncorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRomIncorrect.Visible = false;
            // 
            // lblRomHeader
            // 
            this.lblRomHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblRomHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRomHeader.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblRomHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.lblRomHeader.Location = new System.Drawing.Point(0, 0);
            this.lblRomHeader.Name = "lblRomHeader";
            this.lblRomHeader.Size = new System.Drawing.Size(454, 96);
            this.lblRomHeader.TabIndex = 0;
            this.lblRomHeader.Text = "Select ROM file";
            this.lblRomHeader.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panelRomBottom
            // 
            this.panelRomBottom.BackColor = System.Drawing.Color.Transparent;
            this.panelRomBottom.Controls.Add(this.btnRom);
            this.panelRomBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRomBottom.Location = new System.Drawing.Point(0, 231);
            this.panelRomBottom.Name = "panelRomBottom";
            this.panelRomBottom.Size = new System.Drawing.Size(454, 94);
            this.panelRomBottom.TabIndex = 7;
            // 
            // btnRom
            // 
            this.btnRom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.btnRom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRom.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnRom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(80)))));
            this.btnRom.Location = new System.Drawing.Point(140, 21);
            this.btnRom.Margin = new System.Windows.Forms.Padding(27, 28, 27, 28);
            this.btnRom.Name = "btnRom";
            this.btnRom.Size = new System.Drawing.Size(174, 49);
            this.btnRom.TabIndex = 4;
            this.btnRom.Text = "Select";
            this.btnRom.UseVisualStyleBackColor = false;
            this.btnRom.Click += new System.EventHandler(this.btnRom_Click);
            // 
            // panelSuccess
            // 
            this.panelSuccess.BackgroundImage = global::coop_builder.Properties.Resources.background;
            this.panelSuccess.Controls.Add(this.lblSuccessDescription);
            this.panelSuccess.Controls.Add(this.lblSuccessTitle);
            this.panelSuccess.Controls.Add(this.panelSuccessBottom);
            this.panelSuccess.Location = new System.Drawing.Point(465, 343);
            this.panelSuccess.Name = "panelSuccess";
            this.panelSuccess.Size = new System.Drawing.Size(454, 325);
            this.panelSuccess.TabIndex = 6;
            // 
            // lblSuccessDescription
            // 
            this.lblSuccessDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblSuccessDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSuccessDescription.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.lblSuccessDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblSuccessDescription.Location = new System.Drawing.Point(0, 96);
            this.lblSuccessDescription.Name = "lblSuccessDescription";
            this.lblSuccessDescription.Size = new System.Drawing.Size(454, 135);
            this.lblSuccessDescription.TabIndex = 5;
            this.lblSuccessDescription.Text = "The build completed successfully.\r\n\r\nEnjoy :)";
            this.lblSuccessDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSuccessTitle
            // 
            this.lblSuccessTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSuccessTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSuccessTitle.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblSuccessTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.lblSuccessTitle.Location = new System.Drawing.Point(0, 0);
            this.lblSuccessTitle.Name = "lblSuccessTitle";
            this.lblSuccessTitle.Size = new System.Drawing.Size(454, 96);
            this.lblSuccessTitle.TabIndex = 0;
            this.lblSuccessTitle.Text = "Success!";
            this.lblSuccessTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panelSuccessBottom
            // 
            this.panelSuccessBottom.BackColor = System.Drawing.Color.Transparent;
            this.panelSuccessBottom.Controls.Add(this.btnSuccessPlay);
            this.panelSuccessBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSuccessBottom.Location = new System.Drawing.Point(0, 231);
            this.panelSuccessBottom.Name = "panelSuccessBottom";
            this.panelSuccessBottom.Size = new System.Drawing.Size(454, 94);
            this.panelSuccessBottom.TabIndex = 6;
            // 
            // btnSuccessPlay
            // 
            this.btnSuccessPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSuccessPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.btnSuccessPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuccessPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuccessPlay.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSuccessPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.btnSuccessPlay.Location = new System.Drawing.Point(140, 21);
            this.btnSuccessPlay.Margin = new System.Windows.Forms.Padding(27, 28, 27, 28);
            this.btnSuccessPlay.Name = "btnSuccessPlay";
            this.btnSuccessPlay.Size = new System.Drawing.Size(174, 49);
            this.btnSuccessPlay.TabIndex = 4;
            this.btnSuccessPlay.Text = "Play";
            this.btnSuccessPlay.UseVisualStyleBackColor = false;
            this.btnSuccessPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // panelFailed
            // 
            this.panelFailed.BackgroundImage = global::coop_builder.Properties.Resources.background;
            this.panelFailed.Controls.Add(this.lblFailedDescription);
            this.panelFailed.Controls.Add(this.lblFailedHeader);
            this.panelFailed.Controls.Add(this.panelFailedBottom);
            this.panelFailed.Location = new System.Drawing.Point(925, 8);
            this.panelFailed.Name = "panelFailed";
            this.panelFailed.Size = new System.Drawing.Size(454, 325);
            this.panelFailed.TabIndex = 7;
            // 
            // lblFailedDescription
            // 
            this.lblFailedDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblFailedDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFailedDescription.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.lblFailedDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.lblFailedDescription.Location = new System.Drawing.Point(0, 96);
            this.lblFailedDescription.Name = "lblFailedDescription";
            this.lblFailedDescription.Size = new System.Drawing.Size(454, 135);
            this.lblFailedDescription.TabIndex = 5;
            this.lblFailedDescription.Text = "The build failed during XXXXXXXXX\r\n\r\nPost the log to the #help-desk channel";
            this.lblFailedDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFailedHeader
            // 
            this.lblFailedHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblFailedHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFailedHeader.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblFailedHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.lblFailedHeader.Location = new System.Drawing.Point(0, 0);
            this.lblFailedHeader.Name = "lblFailedHeader";
            this.lblFailedHeader.Size = new System.Drawing.Size(454, 96);
            this.lblFailedHeader.TabIndex = 0;
            this.lblFailedHeader.Text = "Failed!";
            this.lblFailedHeader.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panelFailedBottom
            // 
            this.panelFailedBottom.BackColor = System.Drawing.Color.Transparent;
            this.panelFailedBottom.Controls.Add(this.btnFailedDiscord);
            this.panelFailedBottom.Controls.Add(this.btnFailedSaveLog);
            this.panelFailedBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFailedBottom.Location = new System.Drawing.Point(0, 231);
            this.panelFailedBottom.Name = "panelFailedBottom";
            this.panelFailedBottom.Size = new System.Drawing.Size(454, 94);
            this.panelFailedBottom.TabIndex = 7;
            // 
            // btnFailedDiscord
            // 
            this.btnFailedDiscord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFailedDiscord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.btnFailedDiscord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFailedDiscord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFailedDiscord.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnFailedDiscord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(80)))));
            this.btnFailedDiscord.Location = new System.Drawing.Point(24, 21);
            this.btnFailedDiscord.Margin = new System.Windows.Forms.Padding(27, 28, 27, 28);
            this.btnFailedDiscord.Name = "btnFailedDiscord";
            this.btnFailedDiscord.Size = new System.Drawing.Size(174, 49);
            this.btnFailedDiscord.TabIndex = 4;
            this.btnFailedDiscord.Text = "Discord";
            this.btnFailedDiscord.UseVisualStyleBackColor = false;
            this.btnFailedDiscord.Click += new System.EventHandler(this.btnFailedDiscord_Click);
            // 
            // btnFailedSaveLog
            // 
            this.btnFailedSaveLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFailedSaveLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.btnFailedSaveLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFailedSaveLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFailedSaveLog.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnFailedSaveLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.btnFailedSaveLog.Location = new System.Drawing.Point(253, 21);
            this.btnFailedSaveLog.Margin = new System.Windows.Forms.Padding(27, 28, 27, 28);
            this.btnFailedSaveLog.Name = "btnFailedSaveLog";
            this.btnFailedSaveLog.Size = new System.Drawing.Size(174, 49);
            this.btnFailedSaveLog.TabIndex = 6;
            this.btnFailedSaveLog.Text = "Save Log";
            this.btnFailedSaveLog.UseVisualStyleBackColor = false;
            this.btnFailedSaveLog.Click += new System.EventHandler(this.btnFailedSaveLog_Click);
            // 
            // panelRenderer
            // 
            this.panelRenderer.BackgroundImage = global::coop_builder.Properties.Resources.background;
            this.panelRenderer.Controls.Add(this.panelOGL);
            this.panelRenderer.Controls.Add(this.panelDX);
            this.panelRenderer.Controls.Add(this.lblRendererTitle);
            this.panelRenderer.Location = new System.Drawing.Point(925, 343);
            this.panelRenderer.Name = "panelRenderer";
            this.panelRenderer.Size = new System.Drawing.Size(454, 325);
            this.panelRenderer.TabIndex = 8;
            // 
            // panelOGL
            // 
            this.panelOGL.BackColor = System.Drawing.Color.Transparent;
            this.panelOGL.Controls.Add(this.lblOGL);
            this.panelOGL.Controls.Add(this.btnOpenGL);
            this.panelOGL.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelOGL.Location = new System.Drawing.Point(227, 96);
            this.panelOGL.Margin = new System.Windows.Forms.Padding(0);
            this.panelOGL.Name = "panelOGL";
            this.panelOGL.Padding = new System.Windows.Forms.Padding(16, 25, 16, 16);
            this.panelOGL.Size = new System.Drawing.Size(227, 229);
            this.panelOGL.TabIndex = 11;
            // 
            // lblOGL
            // 
            this.lblOGL.BackColor = System.Drawing.Color.Transparent;
            this.lblOGL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOGL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOGL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.lblOGL.Location = new System.Drawing.Point(16, 74);
            this.lblOGL.Name = "lblOGL";
            this.lblOGL.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.lblOGL.Size = new System.Drawing.Size(195, 139);
            this.lblOGL.TabIndex = 11;
            this.lblOGL.Text = "\r\n(recommended)\r\n\r\n+ More heavily tested\r\n\r\n+ Mouse controls work\r\n\r\n- Old comput" +
    "ers might just show a white screen";
            // 
            // btnOpenGL
            // 
            this.btnOpenGL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.btnOpenGL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenGL.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenGL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenGL.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnOpenGL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.btnOpenGL.Location = new System.Drawing.Point(16, 25);
            this.btnOpenGL.Margin = new System.Windows.Forms.Padding(6);
            this.btnOpenGL.Name = "btnOpenGL";
            this.btnOpenGL.Size = new System.Drawing.Size(195, 49);
            this.btnOpenGL.TabIndex = 10;
            this.btnOpenGL.Text = "OpenGL";
            this.btnOpenGL.UseVisualStyleBackColor = false;
            this.btnOpenGL.Click += new System.EventHandler(this.btnOpenGL_Click);
            // 
            // panelDX
            // 
            this.panelDX.BackColor = System.Drawing.Color.Transparent;
            this.panelDX.Controls.Add(this.lblDX);
            this.panelDX.Controls.Add(this.btnDirectX11);
            this.panelDX.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDX.Location = new System.Drawing.Point(0, 96);
            this.panelDX.Margin = new System.Windows.Forms.Padding(0);
            this.panelDX.Name = "panelDX";
            this.panelDX.Padding = new System.Windows.Forms.Padding(16, 25, 16, 16);
            this.panelDX.Size = new System.Drawing.Size(227, 229);
            this.panelDX.TabIndex = 10;
            // 
            // lblDX
            // 
            this.lblDX.BackColor = System.Drawing.Color.Transparent;
            this.lblDX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDX.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblDX.Location = new System.Drawing.Point(16, 74);
            this.lblDX.Name = "lblDX";
            this.lblDX.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblDX.Size = new System.Drawing.Size(195, 139);
            this.lblDX.TabIndex = 10;
            this.lblDX.Text = "\r\n(not recommended)\r\n\r\n- Less tested\r\n\r\n- Mouse controls don\'t work\r\n\r\n+ May work" +
    " on old machines";
            // 
            // btnDirectX11
            // 
            this.btnDirectX11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.btnDirectX11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDirectX11.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDirectX11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirectX11.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnDirectX11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(80)))));
            this.btnDirectX11.Location = new System.Drawing.Point(16, 25);
            this.btnDirectX11.Margin = new System.Windows.Forms.Padding(27, 28, 27, 28);
            this.btnDirectX11.Name = "btnDirectX11";
            this.btnDirectX11.Size = new System.Drawing.Size(195, 49);
            this.btnDirectX11.TabIndex = 9;
            this.btnDirectX11.Text = "DirectX 11";
            this.btnDirectX11.UseVisualStyleBackColor = false;
            this.btnDirectX11.Click += new System.EventHandler(this.btnDirectX11_Click);
            // 
            // lblRendererTitle
            // 
            this.lblRendererTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblRendererTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRendererTitle.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblRendererTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.lblRendererTitle.Location = new System.Drawing.Point(0, 0);
            this.lblRendererTitle.Name = "lblRendererTitle";
            this.lblRendererTitle.Size = new System.Drawing.Size(454, 96);
            this.lblRendererTitle.TabIndex = 0;
            this.lblRendererTitle.Text = "Select Renderer";
            this.lblRendererTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panelRuntime
            // 
            this.panelRuntime.BackgroundImage = global::coop_builder.Properties.Resources.background;
            this.panelRuntime.Controls.Add(this.lblRuntime);
            this.panelRuntime.Controls.Add(this.lblRuntimeTitle);
            this.panelRuntime.Controls.Add(this.panelRuntimeBottom);
            this.panelRuntime.Location = new System.Drawing.Point(8, 674);
            this.panelRuntime.Name = "panelRuntime";
            this.panelRuntime.Size = new System.Drawing.Size(454, 325);
            this.panelRuntime.TabIndex = 9;
            this.panelRuntime.Visible = false;
            // 
            // lblRuntime
            // 
            this.lblRuntime.BackColor = System.Drawing.Color.Transparent;
            this.lblRuntime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRuntime.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.lblRuntime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblRuntime.Location = new System.Drawing.Point(0, 96);
            this.lblRuntime.Name = "lblRuntime";
            this.lblRuntime.Size = new System.Drawing.Size(454, 135);
            this.lblRuntime.TabIndex = 5;
            this.lblRuntime.Text = "You are missing a runtime from Microsoft.\r\n\r\nIt must be installed before coop-com" +
    "piler can work.";
            this.lblRuntime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRuntimeTitle
            // 
            this.lblRuntimeTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblRuntimeTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRuntimeTitle.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblRuntimeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.lblRuntimeTitle.Location = new System.Drawing.Point(0, 0);
            this.lblRuntimeTitle.Name = "lblRuntimeTitle";
            this.lblRuntimeTitle.Size = new System.Drawing.Size(454, 96);
            this.lblRuntimeTitle.TabIndex = 0;
            this.lblRuntimeTitle.Text = "Missing Runtime";
            this.lblRuntimeTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panelRuntimeBottom
            // 
            this.panelRuntimeBottom.BackColor = System.Drawing.Color.Transparent;
            this.panelRuntimeBottom.Controls.Add(this.btnRuntime);
            this.panelRuntimeBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRuntimeBottom.Location = new System.Drawing.Point(0, 231);
            this.panelRuntimeBottom.Name = "panelRuntimeBottom";
            this.panelRuntimeBottom.Size = new System.Drawing.Size(454, 94);
            this.panelRuntimeBottom.TabIndex = 6;
            // 
            // btnRuntime
            // 
            this.btnRuntime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRuntime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.btnRuntime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRuntime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRuntime.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnRuntime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(80)))));
            this.btnRuntime.Location = new System.Drawing.Point(140, 21);
            this.btnRuntime.Margin = new System.Windows.Forms.Padding(27, 28, 27, 28);
            this.btnRuntime.Name = "btnRuntime";
            this.btnRuntime.Size = new System.Drawing.Size(174, 49);
            this.btnRuntime.TabIndex = 4;
            this.btnRuntime.Text = "Download";
            this.btnRuntime.UseVisualStyleBackColor = false;
            this.btnRuntime.Click += new System.EventHandler(this.btnRuntime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1384, 1007);
            this.Controls.Add(this.panelRuntime);
            this.Controls.Add(this.panelRenderer);
            this.Controls.Add(this.panelFailed);
            this.Controls.Add(this.panelSuccess);
            this.Controls.Add(this.panelRom);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelBuild);
            this.Name = "Form1";
            this.Text = "coop-compiler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelBuild.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctDiscord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.panelRom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctRom)).EndInit();
            this.panelRomBottom.ResumeLayout(false);
            this.panelSuccess.ResumeLayout(false);
            this.panelSuccessBottom.ResumeLayout(false);
            this.panelFailed.ResumeLayout(false);
            this.panelFailedBottom.ResumeLayout(false);
            this.panelRenderer.ResumeLayout(false);
            this.panelOGL.ResumeLayout(false);
            this.panelDX.ResumeLayout(false);
            this.panelRuntime.ResumeLayout(false);
            this.panelRuntimeBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBuild;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panelRom;
        private System.Windows.Forms.Button btnRom;
        private System.Windows.Forms.Label lblRomHeader;
        private System.Windows.Forms.Label lblRomIncorrect;
        private System.Windows.Forms.Panel panelSuccess;
        private System.Windows.Forms.Button btnSuccessPlay;
        private System.Windows.Forms.Label lblSuccessDescription;
        private System.Windows.Forms.Label lblSuccessTitle;
        private System.Windows.Forms.Panel panelFailed;
        private System.Windows.Forms.Button btnFailedDiscord;
        private System.Windows.Forms.Label lblFailedDescription;
        private System.Windows.Forms.Label lblFailedHeader;
        private System.Windows.Forms.Button btnFailedSaveLog;
        private System.Windows.Forms.PictureBox pctDiscord;
        private System.Windows.Forms.PictureBox pctRom;
        private CustomProgressBar customProgressBar1;
        private System.Windows.Forms.Panel panelSuccessBottom;
        private System.Windows.Forms.Panel panelFailedBottom;
        private System.Windows.Forms.Panel panelRomBottom;
        private System.Windows.Forms.Panel panelRenderer;
        private System.Windows.Forms.Label lblRendererTitle;
        private System.Windows.Forms.Panel panelOGL;
        private System.Windows.Forms.Label lblOGL;
        private System.Windows.Forms.Button btnOpenGL;
        private System.Windows.Forms.Panel panelDX;
        private System.Windows.Forms.Label lblDX;
        private System.Windows.Forms.Button btnDirectX11;
        private System.Windows.Forms.Panel panelRuntime;
        private System.Windows.Forms.Label lblRuntime;
        private System.Windows.Forms.Label lblRuntimeTitle;
        private System.Windows.Forms.Panel panelRuntimeBottom;
        private System.Windows.Forms.Button btnRuntime;
    }
}

