
namespace LiveSplit.UI.Components
{
    partial class TimerPauseSettings
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.grpBoxLinks = new System.Windows.Forms.GroupBox();
            this.tblLayoutLinks = new System.Windows.Forms.TableLayoutPanel();
            this.lblGitHub = new System.Windows.Forms.LinkLabel();
            this.lblYouTube = new System.Windows.Forms.LinkLabel();
            this.lblTwitch = new System.Windows.Forms.LinkLabel();
            this.mainLayout.SuspendLayout();
            this.grpBoxLinks.SuspendLayout();
            this.tblLayoutLinks.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.AutoSize = true;
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainLayout.Controls.Add(this.grpBoxLinks, 0, 0);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 1;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainLayout.Size = new System.Drawing.Size(462, 50);
            this.mainLayout.TabIndex = 0;
            // 
            // grpBoxLinks
            // 
            this.grpBoxLinks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxLinks.AutoSize = true;
            this.grpBoxLinks.Controls.Add(this.tblLayoutLinks);
            this.grpBoxLinks.Location = new System.Drawing.Point(3, 3);
            this.grpBoxLinks.Name = "grpBoxLinks";
            this.grpBoxLinks.Size = new System.Drawing.Size(456, 44);
            this.grpBoxLinks.TabIndex = 0;
            this.grpBoxLinks.TabStop = false;
            this.grpBoxLinks.Text = "Links";
            // 
            // tblLayoutLinks
            // 
            this.tblLayoutLinks.AutoSize = true;
            this.tblLayoutLinks.ColumnCount = 3;
            this.tblLayoutLinks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutLinks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutLinks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutLinks.Controls.Add(this.lblGitHub, 0, 0);
            this.tblLayoutLinks.Controls.Add(this.lblYouTube, 1, 0);
            this.tblLayoutLinks.Controls.Add(this.lblTwitch, 2, 0);
            this.tblLayoutLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutLinks.Location = new System.Drawing.Point(3, 16);
            this.tblLayoutLinks.Name = "tblLayoutLinks";
            this.tblLayoutLinks.RowCount = 1;
            this.tblLayoutLinks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutLinks.Size = new System.Drawing.Size(450, 25);
            this.tblLayoutLinks.TabIndex = 0;
            // 
            // lblGitHub
            // 
            this.lblGitHub.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGitHub.AutoSize = true;
            this.lblGitHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGitHub.Image = global::Vofel.TimerPause.Properties.Resources.GitHub_Mark_16px;
            this.lblGitHub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGitHub.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblGitHub.Location = new System.Drawing.Point(3, 0);
            this.lblGitHub.Name = "lblGitHub";
            this.lblGitHub.Size = new System.Drawing.Size(143, 25);
            this.lblGitHub.TabIndex = 0;
            this.lblGitHub.TabStop = true;
            this.lblGitHub.Text = "       GitHub";
            this.lblGitHub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGitHub_LinkClicked);
            // 
            // lblYouTube
            // 
            this.lblYouTube.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblYouTube.AutoSize = true;
            this.lblYouTube.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblYouTube.Image = global::Vofel.TimerPause.Properties.Resources.youtube_social_icon_red;
            this.lblYouTube.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblYouTube.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblYouTube.Location = new System.Drawing.Point(152, 0);
            this.lblYouTube.Name = "lblYouTube";
            this.lblYouTube.Size = new System.Drawing.Size(143, 25);
            this.lblYouTube.TabIndex = 1;
            this.lblYouTube.TabStop = true;
            this.lblYouTube.Text = "         YouTube";
            this.lblYouTube.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblYouTube.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblYouTube_LinkClicked);
            // 
            // lblTwitch
            // 
            this.lblTwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTwitch.AutoSize = true;
            this.lblTwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTwitch.Image = global::Vofel.TimerPause.Properties.Resources.TwitchGlitchPurple;
            this.lblTwitch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTwitch.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblTwitch.Location = new System.Drawing.Point(301, 0);
            this.lblTwitch.Name = "lblTwitch";
            this.lblTwitch.Size = new System.Drawing.Size(146, 25);
            this.lblTwitch.TabIndex = 2;
            this.lblTwitch.TabStop = true;
            this.lblTwitch.Text = "      Twitch";
            this.lblTwitch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTwitch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblTwitch_LinkClicked);
            // 
            // TimerPauseSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.mainLayout);
            this.Name = "TimerPauseSettings";
            this.Size = new System.Drawing.Size(462, 50);
            this.mainLayout.ResumeLayout(false);
            this.mainLayout.PerformLayout();
            this.grpBoxLinks.ResumeLayout(false);
            this.grpBoxLinks.PerformLayout();
            this.tblLayoutLinks.ResumeLayout(false);
            this.tblLayoutLinks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.GroupBox grpBoxLinks;
        private System.Windows.Forms.TableLayoutPanel tblLayoutLinks;
        private System.Windows.Forms.LinkLabel lblGitHub;
        private System.Windows.Forms.LinkLabel lblYouTube;
        private System.Windows.Forms.LinkLabel lblTwitch;
    }
}
