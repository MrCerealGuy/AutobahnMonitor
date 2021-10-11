
namespace AutobahnMonitor
{
    partial class InfoDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoDialog));
            this.labelInfoTitle = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.linkLabelGithub = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelGithub = new System.Windows.Forms.Label();
            this.linkLabelPayPal = new System.Windows.Forms.LinkLabel();
            this.labelPayPal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelInfoTitle
            // 
            this.labelInfoTitle.AutoSize = true;
            this.labelInfoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoTitle.Location = new System.Drawing.Point(10, 11);
            this.labelInfoTitle.Name = "labelInfoTitle";
            this.labelInfoTitle.Size = new System.Drawing.Size(192, 26);
            this.labelInfoTitle.TabIndex = 0;
            this.labelInfoTitle.Text = "AutobahnMonitor";
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Location = new System.Drawing.Point(12, 49);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(209, 13);
            this.labelCopyright.TabIndex = 1;
            this.labelCopyright.Text = "© 2021 Andreas \"MrCerealGuy\" Zahnleiter";
            // 
            // linkLabelGithub
            // 
            this.linkLabelGithub.AutoSize = true;
            this.linkLabelGithub.Location = new System.Drawing.Point(12, 134);
            this.linkLabelGithub.Name = "linkLabelGithub";
            this.linkLabelGithub.Size = new System.Drawing.Size(211, 13);
            this.linkLabelGithub.TabIndex = 2;
            this.linkLabelGithub.TabStop = true;
            this.linkLabelGithub.Text = "github.com/MrCerealGuy/AutobahnMonitor";
            this.linkLabelGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGithub_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.labelInfoTitle);
            this.panel1.Controls.Add(this.labelCopyright);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 87);
            this.panel1.TabIndex = 3;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(288, 185);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelGithub
            // 
            this.labelGithub.AutoSize = true;
            this.labelGithub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGithub.Location = new System.Drawing.Point(12, 118);
            this.labelGithub.Name = "labelGithub";
            this.labelGithub.Size = new System.Drawing.Size(195, 13);
            this.labelGithub.TabIndex = 5;
            this.labelGithub.Text = "Besuche mein Github-Repository:";
            // 
            // linkLabelPayPal
            // 
            this.linkLabelPayPal.AutoSize = true;
            this.linkLabelPayPal.Location = new System.Drawing.Point(12, 190);
            this.linkLabelPayPal.Name = "linkLabelPayPal";
            this.linkLabelPayPal.Size = new System.Drawing.Size(121, 13);
            this.linkLabelPayPal.TabIndex = 6;
            this.linkLabelPayPal.TabStop = true;
            this.linkLabelPayPal.Text = "paypal.me/MrCerealGuy";
            this.linkLabelPayPal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPayPal_LinkClicked);
            // 
            // labelPayPal
            // 
            this.labelPayPal.AutoSize = true;
            this.labelPayPal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayPal.Location = new System.Drawing.Point(11, 173);
            this.labelPayPal.Name = "labelPayPal";
            this.labelPayPal.Size = new System.Drawing.Size(157, 13);
            this.labelPayPal.TabIndex = 7;
            this.labelPayPal.Text = "Danke für deinen Support!";
            // 
            // InfoDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 229);
            this.Controls.Add(this.labelPayPal);
            this.Controls.Add(this.linkLabelPayPal);
            this.Controls.Add(this.labelGithub);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabelGithub);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Info";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfoTitle;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.LinkLabel linkLabelGithub;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelGithub;
        private System.Windows.Forms.LinkLabel linkLabelPayPal;
        private System.Windows.Forms.Label labelPayPal;
    }
}