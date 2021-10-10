
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutobahnMonitor));
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelRoad = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxRoad = new System.Windows.Forms.ComboBox();
            this.tableLayoutPaneServiceButtons = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnQueryWebcams = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnQueryRoadworks = new System.Windows.Forms.Button();
            this.btnQueryParkingLorries = new System.Windows.Forms.Button();
            this.btnQueryClosures = new System.Windows.Forms.Button();
            this.btnQueryElectricChargingStations = new System.Windows.Forms.Button();
            this.btnQueryWarnings = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPaneServiceButtons.SuspendLayout();
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
            this.listBoxObjects.Size = new System.Drawing.Size(361, 184);
            this.listBoxObjects.TabIndex = 5;
            this.listBoxObjects.SelectedIndexChanged += new System.EventHandler(this.listBoxObjects_SelectedIndexChanged);
            // 
            // richTextBoxObjectDetails
            // 
            this.richTextBoxObjectDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxObjectDetails.Location = new System.Drawing.Point(370, 28);
            this.richTextBoxObjectDetails.Name = "richTextBoxObjectDetails";
            this.richTextBoxObjectDetails.Size = new System.Drawing.Size(361, 184);
            this.richTextBoxObjectDetails.TabIndex = 6;
            this.richTextBoxObjectDetails.Text = "";
            // 
            // webBrowserWebcam
            // 
            this.webBrowserWebcam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserWebcam.Location = new System.Drawing.Point(737, 28);
            this.webBrowserWebcam.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserWebcam.Name = "webBrowserWebcam";
            this.webBrowserWebcam.Size = new System.Drawing.Size(363, 184);
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
            this.webBrowserGIS.Location = new System.Drawing.Point(3, 304);
            this.webBrowserGIS.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserGIS.Name = "webBrowserGIS";
            this.webBrowserGIS.Size = new System.Drawing.Size(1103, 223);
            this.webBrowserGIS.TabIndex = 10;
            this.webBrowserGIS.Url = new System.Uri("https://www.openstreetmap.org/#map=6/51.193/10.437", System.UriKind.Absolute);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPaneServiceButtons, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.webBrowserGIS, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.03382F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.96618F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1109, 631);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.labelRoad, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxRoad, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1103, 215);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // comboBoxRoad
            // 
            this.comboBoxRoad.FormattingEnabled = true;
            this.comboBoxRoad.Location = new System.Drawing.Point(73, 3);
            this.comboBoxRoad.Name = "comboBoxRoad";
            this.comboBoxRoad.Size = new System.Drawing.Size(171, 21);
            this.comboBoxRoad.TabIndex = 8;
            this.comboBoxRoad.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoad_SelectedIndexChanged);
            // 
            // tableLayoutPaneServiceButtons
            // 
            this.tableLayoutPaneServiceButtons.ColumnCount = 12;
            this.tableLayoutPaneServiceButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPaneServiceButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPaneServiceButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPaneServiceButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPaneServiceButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPaneServiceButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPaneServiceButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPaneServiceButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPaneServiceButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPaneServiceButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPaneServiceButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPaneServiceButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPaneServiceButtons.Controls.Add(this.label6, 10, 0);
            this.tableLayoutPaneServiceButtons.Controls.Add(this.label5, 8, 0);
            this.tableLayoutPaneServiceButtons.Controls.Add(this.label4, 6, 0);
            this.tableLayoutPaneServiceButtons.Controls.Add(this.label7, 4, 0);
            this.tableLayoutPaneServiceButtons.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPaneServiceButtons.Controls.Add(this.btnQueryWebcams, 1, 0);
            this.tableLayoutPaneServiceButtons.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPaneServiceButtons.Controls.Add(this.btnQueryRoadworks, 3, 0);
            this.tableLayoutPaneServiceButtons.Controls.Add(this.btnQueryParkingLorries, 5, 0);
            this.tableLayoutPaneServiceButtons.Controls.Add(this.btnQueryClosures, 7, 0);
            this.tableLayoutPaneServiceButtons.Controls.Add(this.btnQueryElectricChargingStations, 9, 0);
            this.tableLayoutPaneServiceButtons.Controls.Add(this.btnQueryWarnings, 11, 0);
            this.tableLayoutPaneServiceButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPaneServiceButtons.Location = new System.Drawing.Point(3, 533);
            this.tableLayoutPaneServiceButtons.Name = "tableLayoutPaneServiceButtons";
            this.tableLayoutPaneServiceButtons.RowCount = 1;
            this.tableLayoutPaneServiceButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPaneServiceButtons.Size = new System.Drawing.Size(1103, 95);
            this.tableLayoutPaneServiceButtons.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(913, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 95);
            this.label6.TabIndex = 21;
            this.label6.Text = "Warnungen";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(731, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 95);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ladestationen";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(549, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 95);
            this.label4.TabIndex = 19;
            this.label4.Text = "Sperrungen";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 95);
            this.label7.TabIndex = 18;
            this.label7.Text = "Rastplätze";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 95);
            this.label8.TabIndex = 17;
            this.label8.Text = "Baustellen";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQueryWebcams
            // 
            this.btnQueryWebcams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQueryWebcams.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQueryWebcams.BackgroundImage")));
            this.btnQueryWebcams.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQueryWebcams.Location = new System.Drawing.Point(94, 3);
            this.btnQueryWebcams.Name = "btnQueryWebcams";
            this.btnQueryWebcams.Size = new System.Drawing.Size(85, 89);
            this.btnQueryWebcams.TabIndex = 10;
            this.btnQueryWebcams.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 95);
            this.label9.TabIndex = 16;
            this.label9.Text = "Webcams";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQueryRoadworks
            // 
            this.btnQueryRoadworks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQueryRoadworks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQueryRoadworks.BackgroundImage")));
            this.btnQueryRoadworks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQueryRoadworks.Location = new System.Drawing.Point(276, 3);
            this.btnQueryRoadworks.Name = "btnQueryRoadworks";
            this.btnQueryRoadworks.Size = new System.Drawing.Size(85, 89);
            this.btnQueryRoadworks.TabIndex = 11;
            this.btnQueryRoadworks.UseVisualStyleBackColor = true;
            this.btnQueryRoadworks.Click += new System.EventHandler(this.btnQueryRoadworks_Click);
            // 
            // btnQueryParkingLorries
            // 
            this.btnQueryParkingLorries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQueryParkingLorries.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQueryParkingLorries.BackgroundImage")));
            this.btnQueryParkingLorries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQueryParkingLorries.Location = new System.Drawing.Point(458, 3);
            this.btnQueryParkingLorries.Name = "btnQueryParkingLorries";
            this.btnQueryParkingLorries.Size = new System.Drawing.Size(85, 89);
            this.btnQueryParkingLorries.TabIndex = 12;
            this.btnQueryParkingLorries.UseVisualStyleBackColor = true;
            this.btnQueryParkingLorries.Click += new System.EventHandler(this.btnQueryParkingLorries_Click);
            // 
            // btnQueryClosures
            // 
            this.btnQueryClosures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQueryClosures.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQueryClosures.BackgroundImage")));
            this.btnQueryClosures.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQueryClosures.Location = new System.Drawing.Point(640, 3);
            this.btnQueryClosures.Name = "btnQueryClosures";
            this.btnQueryClosures.Size = new System.Drawing.Size(85, 89);
            this.btnQueryClosures.TabIndex = 13;
            this.btnQueryClosures.UseVisualStyleBackColor = true;
            this.btnQueryClosures.Click += new System.EventHandler(this.btnQueryClosures_Click);
            // 
            // btnQueryElectricChargingStations
            // 
            this.btnQueryElectricChargingStations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQueryElectricChargingStations.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQueryElectricChargingStations.BackgroundImage")));
            this.btnQueryElectricChargingStations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQueryElectricChargingStations.Location = new System.Drawing.Point(822, 3);
            this.btnQueryElectricChargingStations.Name = "btnQueryElectricChargingStations";
            this.btnQueryElectricChargingStations.Size = new System.Drawing.Size(85, 89);
            this.btnQueryElectricChargingStations.TabIndex = 14;
            this.btnQueryElectricChargingStations.UseVisualStyleBackColor = true;
            this.btnQueryElectricChargingStations.Click += new System.EventHandler(this.btnQueryElectricChargingStations_Click);
            // 
            // btnQueryWarnings
            // 
            this.btnQueryWarnings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQueryWarnings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQueryWarnings.BackgroundImage")));
            this.btnQueryWarnings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQueryWarnings.Location = new System.Drawing.Point(1004, 3);
            this.btnQueryWarnings.Name = "btnQueryWarnings";
            this.btnQueryWarnings.Size = new System.Drawing.Size(96, 89);
            this.btnQueryWarnings.TabIndex = 15;
            this.btnQueryWarnings.UseVisualStyleBackColor = true;
            this.btnQueryWarnings.Click += new System.EventHandler(this.btnQueryWarnings_Click);
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
            this.tableLayoutPaneServiceButtons.ResumeLayout(false);
            this.tableLayoutPaneServiceButtons.PerformLayout();
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
        private System.Windows.Forms.Label labelRoad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox comboBoxRoad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPaneServiceButtons;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnQueryWebcams;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnQueryRoadworks;
        private System.Windows.Forms.Button btnQueryParkingLorries;
        private System.Windows.Forms.Button btnQueryClosures;
        private System.Windows.Forms.Button btnQueryElectricChargingStations;
        private System.Windows.Forms.Button btnQueryWarnings;
    }
}

