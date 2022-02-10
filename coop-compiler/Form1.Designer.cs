
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.pctDiscord = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panelRom = new System.Windows.Forms.Panel();
            this.pctRom = new System.Windows.Forms.PictureBox();
            this.btnRom = new System.Windows.Forms.Button();
            this.lblRomIncorrect = new System.Windows.Forms.Label();
            this.lblRomHeader = new System.Windows.Forms.Label();
            this.panelSuccess = new System.Windows.Forms.Panel();
            this.btnSuccessPlay = new System.Windows.Forms.Button();
            this.lblSuccessDescription = new System.Windows.Forms.Label();
            this.lblSuccessTitle = new System.Windows.Forms.Label();
            this.panelFailed = new System.Windows.Forms.Panel();
            this.btnFailedSaveLog = new System.Windows.Forms.Button();
            this.btnFailedDiscord = new System.Windows.Forms.Button();
            this.lblFailedDescription = new System.Windows.Forms.Label();
            this.lblFailedHeader = new System.Windows.Forms.Label();
            this.customProgressBar1 = new coop_builder.CustomProgressBar();
            this.panelBuild.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctDiscord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.panelRom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctRom)).BeginInit();
            this.panelSuccess.SuspendLayout();
            this.panelFailed.SuspendLayout();
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
            // pctDiscord
            // 
            this.pctDiscord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pctDiscord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctDiscord.Image = global::coop_builder.Properties.Resources.Discord_Logo_Wordmark_Color2;
            this.pctDiscord.Location = new System.Drawing.Point(27, 185);
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
            this.btnPlay.Location = new System.Drawing.Point(253, 242);
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
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(80)))));
            this.btnUpdate.Location = new System.Drawing.Point(27, 242);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(27, 28, 27, 28);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(174, 49);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_ClickAsync);
            // 
            // panelRom
            // 
            this.panelRom.BackgroundImage = global::coop_builder.Properties.Resources.background;
            this.panelRom.Controls.Add(this.btnRom);
            this.panelRom.Controls.Add(this.pctRom);
            this.panelRom.Controls.Add(this.lblRomIncorrect);
            this.panelRom.Controls.Add(this.lblRomHeader);
            this.panelRom.Location = new System.Drawing.Point(8, 343);
            this.panelRom.Name = "panelRom";
            this.panelRom.Size = new System.Drawing.Size(454, 325);
            this.panelRom.TabIndex = 5;
            // 
            // pctRom
            // 
            this.pctRom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pctRom.Dock = System.Windows.Forms.DockStyle.Top;
            this.pctRom.Image = global::coop_builder.Properties.Resources.rom;
            this.pctRom.Location = new System.Drawing.Point(0, 231);
            this.pctRom.Name = "pctRom";
            this.pctRom.Size = new System.Drawing.Size(454, 93);
            this.pctRom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctRom.TabIndex = 6;
            this.pctRom.TabStop = false;
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
            this.btnRom.Location = new System.Drawing.Point(141, 236);
            this.btnRom.Margin = new System.Windows.Forms.Padding(27, 28, 27, 28);
            this.btnRom.Name = "btnRom";
            this.btnRom.Size = new System.Drawing.Size(174, 49);
            this.btnRom.TabIndex = 4;
            this.btnRom.Text = "Select";
            this.btnRom.UseVisualStyleBackColor = false;
            this.btnRom.Click += new System.EventHandler(this.btnRom_Click);
            // 
            // lblRomIncorrect
            // 
            this.lblRomIncorrect.BackColor = System.Drawing.Color.Transparent;
            this.lblRomIncorrect.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRomIncorrect.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.lblRomIncorrect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.lblRomIncorrect.Location = new System.Drawing.Point(0, 148);
            this.lblRomIncorrect.Name = "lblRomIncorrect";
            this.lblRomIncorrect.Size = new System.Drawing.Size(454, 83);
            this.lblRomIncorrect.TabIndex = 5;
            this.lblRomIncorrect.Text = "Incorrect ROM file!\r\nMust be the United States release.\r\n";
            this.lblRomIncorrect.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.lblRomHeader.Size = new System.Drawing.Size(454, 148);
            this.lblRomHeader.TabIndex = 0;
            this.lblRomHeader.Text = "Select ROM file";
            this.lblRomHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSuccess
            // 
            this.panelSuccess.BackgroundImage = global::coop_builder.Properties.Resources.background;
            this.panelSuccess.Controls.Add(this.btnSuccessPlay);
            this.panelSuccess.Controls.Add(this.lblSuccessDescription);
            this.panelSuccess.Controls.Add(this.lblSuccessTitle);
            this.panelSuccess.Location = new System.Drawing.Point(465, 343);
            this.panelSuccess.Name = "panelSuccess";
            this.panelSuccess.Size = new System.Drawing.Size(454, 325);
            this.panelSuccess.TabIndex = 6;
            // 
            // btnSuccessPlay
            // 
            this.btnSuccessPlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuccessPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.btnSuccessPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuccessPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuccessPlay.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSuccessPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.btnSuccessPlay.Location = new System.Drawing.Point(141, 236);
            this.btnSuccessPlay.Margin = new System.Windows.Forms.Padding(27, 28, 27, 28);
            this.btnSuccessPlay.Name = "btnSuccessPlay";
            this.btnSuccessPlay.Size = new System.Drawing.Size(174, 49);
            this.btnSuccessPlay.TabIndex = 4;
            this.btnSuccessPlay.Text = "Play";
            this.btnSuccessPlay.UseVisualStyleBackColor = false;
            this.btnSuccessPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblSuccessDescription
            // 
            this.lblSuccessDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblSuccessDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSuccessDescription.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.lblSuccessDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblSuccessDescription.Location = new System.Drawing.Point(0, 96);
            this.lblSuccessDescription.Name = "lblSuccessDescription";
            this.lblSuccessDescription.Size = new System.Drawing.Size(454, 135);
            this.lblSuccessDescription.TabIndex = 5;
            this.lblSuccessDescription.Text = "The build completed successfully.\r\nEnjoy :)";
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
            // panelFailed
            // 
            this.panelFailed.BackgroundImage = global::coop_builder.Properties.Resources.background;
            this.panelFailed.Controls.Add(this.btnFailedSaveLog);
            this.panelFailed.Controls.Add(this.btnFailedDiscord);
            this.panelFailed.Controls.Add(this.lblFailedDescription);
            this.panelFailed.Controls.Add(this.lblFailedHeader);
            this.panelFailed.Location = new System.Drawing.Point(924, 8);
            this.panelFailed.Name = "panelFailed";
            this.panelFailed.Size = new System.Drawing.Size(454, 325);
            this.panelFailed.TabIndex = 7;
            // 
            // btnFailedSaveLog
            // 
            this.btnFailedSaveLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFailedSaveLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(0)))));
            this.btnFailedSaveLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFailedSaveLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFailedSaveLog.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnFailedSaveLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.btnFailedSaveLog.Location = new System.Drawing.Point(253, 242);
            this.btnFailedSaveLog.Margin = new System.Windows.Forms.Padding(27, 28, 27, 28);
            this.btnFailedSaveLog.Name = "btnFailedSaveLog";
            this.btnFailedSaveLog.Size = new System.Drawing.Size(174, 49);
            this.btnFailedSaveLog.TabIndex = 6;
            this.btnFailedSaveLog.Text = "Save Log";
            this.btnFailedSaveLog.UseVisualStyleBackColor = false;
            this.btnFailedSaveLog.Click += new System.EventHandler(this.btnFailedSaveLog_Click);
            // 
            // btnFailedDiscord
            // 
            this.btnFailedDiscord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFailedDiscord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.btnFailedDiscord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFailedDiscord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFailedDiscord.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnFailedDiscord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(80)))));
            this.btnFailedDiscord.Location = new System.Drawing.Point(27, 242);
            this.btnFailedDiscord.Margin = new System.Windows.Forms.Padding(27, 28, 27, 28);
            this.btnFailedDiscord.Name = "btnFailedDiscord";
            this.btnFailedDiscord.Size = new System.Drawing.Size(174, 49);
            this.btnFailedDiscord.TabIndex = 4;
            this.btnFailedDiscord.Text = "Discord";
            this.btnFailedDiscord.UseVisualStyleBackColor = false;
            this.btnFailedDiscord.Click += new System.EventHandler(this.btnFailedDiscord_Click);
            // 
            // lblFailedDescription
            // 
            this.lblFailedDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblFailedDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFailedDescription.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.lblFailedDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.lblFailedDescription.Location = new System.Drawing.Point(0, 96);
            this.lblFailedDescription.Name = "lblFailedDescription";
            this.lblFailedDescription.Size = new System.Drawing.Size(454, 124);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1384, 677);
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
            this.panelSuccess.ResumeLayout(false);
            this.panelFailed.ResumeLayout(false);
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
    }
}

