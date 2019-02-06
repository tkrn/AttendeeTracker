namespace AttendeeTracker
{
    partial class frmAbout
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.LinkLabel lnkGitHub;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.picAbout = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblBuiltOn = new System.Windows.Forms.Label();
            this.richTextbox = new System.Windows.Forms.RichTextBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            lnkGitHub = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkGitHub
            // 
            lnkGitHub.AutoSize = true;
            lnkGitHub.LinkColor = System.Drawing.Color.Navy;
            lnkGitHub.LinkVisited = true;
            lnkGitHub.Location = new System.Drawing.Point(184, 132);
            lnkGitHub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lnkGitHub.Name = "lnkGitHub";
            lnkGitHub.Size = new System.Drawing.Size(167, 13);
            lnkGitHub.TabIndex = 7;
            lnkGitHub.TabStop = true;
            lnkGitHub.Text = "github.com/tkrn/AttendeeTracker";
            lnkGitHub.VisitedLinkColor = System.Drawing.Color.Navy;
            lnkGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGitHub_LinkClicked);
            // 
            // picAbout
            // 
            this.picAbout.Image = ((System.Drawing.Image)(resources.GetObject("picAbout.Image")));
            this.picAbout.Location = new System.Drawing.Point(10, 17);
            this.picAbout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picAbout.Name = "picAbout";
            this.picAbout.Size = new System.Drawing.Size(170, 123);
            this.picAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAbout.TabIndex = 0;
            this.picAbout.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(184, 34);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(202, 26);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "A utility to import an attendee list, checkin\r\nattendees and printer name lables";
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.Location = new System.Drawing.Point(184, 11);
            this.lblAbout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(139, 13);
            this.lblAbout.TabIndex = 1;
            this.lblAbout.Text = "About AttendeeTracker";
            // 
            // lblLine
            // 
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine.Location = new System.Drawing.Point(183, 69);
            this.lblLine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(180, 2);
            this.lblLine.TabIndex = 3;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(184, 78);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(60, 13);
            this.lblVersion.TabIndex = 4;
            this.lblVersion.Text = "Version 1.0";
            // 
            // lblBuiltOn
            // 
            this.lblBuiltOn.AutoSize = true;
            this.lblBuiltOn.Location = new System.Drawing.Point(184, 96);
            this.lblBuiltOn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuiltOn.Name = "lblBuiltOn";
            this.lblBuiltOn.Size = new System.Drawing.Size(45, 13);
            this.lblBuiltOn.TabIndex = 5;
            this.lblBuiltOn.Text = "Built on ";
            // 
            // richTextbox
            // 
            this.richTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextbox.Location = new System.Drawing.Point(10, 151);
            this.richTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextbox.Name = "richTextbox";
            this.richTextbox.Size = new System.Drawing.Size(369, 200);
            this.richTextbox.TabIndex = 8;
            this.richTextbox.Text = resources.GetString("richTextbox.Text");
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(184, 114);
            this.lblCopyright.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(138, 13);
            this.lblCopyright.TabIndex = 6;
            this.lblCopyright.Text = "Copyright © 2018-2019 tkrn";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 369);
            this.Controls.Add(lnkGitHub);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.richTextbox);
            this.Controls.Add(this.lblBuiltOn);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.picAbout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(405, 408);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(405, 408);
            this.Name = "frmAbout";
            this.Text = "About AttendeeTracker";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAbout;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblBuiltOn;
        private System.Windows.Forms.RichTextBox richTextbox;
        private System.Windows.Forms.Label lblCopyright;
    }
}