
namespace AutobahnMonitor
{
    partial class AutobahnMonitor
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.listBoxObjects = new System.Windows.Forms.ListBox();
            this.richTextBoxObjectDetails = new System.Windows.Forms.RichTextBox();
            this.webBrowserWebcam = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.webBrowserGIS = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.buttonQueryService = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelRoad = new System.Windows.Forms.Label();
            this.labelService = new System.Windows.Forms.Label();
            this.comboBoxRoad = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1109, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 655);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1109, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // listBoxObjects
            // 
            this.listBoxObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxObjects.FormattingEnabled = true;
            this.listBoxObjects.HorizontalScrollbar = true;
            this.listBoxObjects.Location = new System.Drawing.Point(3, 28);
            this.listBoxObjects.Name = "listBoxObjects";
            this.listBoxObjects.Size = new System.Drawing.Size(361, 233);
            this.listBoxObjects.TabIndex = 5;
            this.listBoxObjects.SelectedIndexChanged += new System.EventHandler(this.listBoxObjects_SelectedIndexChanged);
            // 
            // richTextBoxObjectDetails
            // 
            this.richTextBoxObjectDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxObjectDetails.Location = new System.Drawing.Point(370, 28);
            this.richTextBoxObjectDetails.Name = "richTextBoxObjectDetails";
            this.richTextBoxObjectDetails.Size = new System.Drawing.Size(361, 233);
            this.richTextBoxObjectDetails.TabIndex = 6;
            this.richTextBoxObjectDetails.Text = "";
            // 
            // webBrowserWebcam
            // 
            this.webBrowserWebcam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserWebcam.Location = new System.Drawing.Point(737, 28);
            this.webBrowserWebcam.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserWebcam.Name = "webBrowserWebcam";
            this.webBrowserWebcam.Size = new System.Drawing.Size(363, 233);
            this.webBrowserWebcam.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Autobahn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(737, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Webcam";
            // 
            // webBrowserGIS
            // 
            this.webBrowserGIS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserGIS.Location = new System.Drawing.Point(3, 353);
            this.webBrowserGIS.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserGIS.Name = "webBrowserGIS";
            this.webBrowserGIS.Size = new System.Drawing.Size(1103, 275);
            this.webBrowserGIS.TabIndex = 10;
            this.webBrowserGIS.Url = new System.Uri("https://www.openstreetmap.org/#map=6/51.193/10.437", System.UriKind.Absolute);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.webBrowserGIS, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.03382F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.96618F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1109, 631);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // comboBoxService
            // 
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Location = new System.Drawing.Point(174, 43);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(170, 21);
            this.comboBoxService.TabIndex = 3;
            // 
            // buttonQueryService
            // 
            this.buttonQueryService.Location = new System.Drawing.Point(503, 43);
            this.buttonQueryService.Name = "buttonQueryService";
            this.buttonQueryService.Size = new System.Drawing.Size(75, 23);
            this.buttonQueryService.TabIndex = 4;
            this.buttonQueryService.Text = "abfragen";
            this.buttonQueryService.UseVisualStyleBackColor = true;
            this.buttonQueryService.Click += new System.EventHandler(this.buttonQueryService_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.labelService, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelRoad, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxRoad, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxService, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonQueryService, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1103, 74);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // labelRoad
            // 
            this.labelRoad.AutoSize = true;
            this.labelRoad.Location = new System.Drawing.Point(3, 0);
            this.labelRoad.Name = "labelRoad";
            this.labelRoad.Size = new System.Drawing.Size(53, 13);
            this.labelRoad.TabIndex = 3;
            this.labelRoad.Text = "Autobahn";
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Location = new System.Drawing.Point(3, 40);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(37, 13);
            this.labelService.TabIndex = 8;
            this.labelService.Text = "Dienst";
            // 
            // comboBoxRoad
            // 
            this.comboBoxRoad.FormattingEnabled = true;
            this.comboBoxRoad.Location = new System.Drawing.Point(174, 3);
            this.comboBoxRoad.Name = "comboBoxRoad";
            this.comboBoxRoad.Size = new System.Drawing.Size(171, 21);
            this.comboBoxRoad.TabIndex = 8;
            this.comboBoxRoad.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoad_SelectedIndexChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.webBrowserWebcam, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.richTextBoxObjectDetails, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.listBoxObjects, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 83);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1103, 264);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // AutobahnMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 677);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AutobahnMonitor";
            this.Text = "AutobahnMonitor v1.0 - Andreas Zahnleiter - Free to use";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListBox listBoxObjects;
        private System.Windows.Forms.RichTextBox richTextBoxObjectDetails;
        private System.Windows.Forms.WebBrowser webBrowserWebcam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.WebBrowser webBrowserGIS;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.Label labelRoad;
        private System.Windows.Forms.ComboBox comboBoxRoad;
        private System.Windows.Forms.ComboBox comboBoxService;
        private System.Windows.Forms.Button buttonQueryService;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}

