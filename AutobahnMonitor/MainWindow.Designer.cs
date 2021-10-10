
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
            this.tableLayoutPanelMainWindow = new System.Windows.Forms.TableLayoutPanel();
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
            this.tableLayoutPanelRoad = new System.Windows.Forms.TableLayoutPanel();
            this.labelRoad = new System.Windows.Forms.Label();
            this.comboBoxRoad = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelDetails = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanelMainWindow.SuspendLayout();
            this.tableLayoutPaneServiceButtons.SuspendLayout();
            this.tableLayoutPanelRoad.SuspendLayout();
            this.tableLayoutPanelDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 859);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
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
            this.listBoxObjects.Size = new System.Drawing.Size(327, 310);
            this.listBoxObjects.TabIndex = 5;
            this.listBoxObjects.SelectedIndexChanged += new System.EventHandler(this.listBoxObjects_SelectedIndexChanged);
            // 
            // richTextBoxObjectDetails
            // 
            this.richTextBoxObjectDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxObjectDetails.Location = new System.Drawing.Point(336, 28);
            this.richTextBoxObjectDetails.Name = "richTextBoxObjectDetails";
            this.richTextBoxObjectDetails.Size = new System.Drawing.Size(328, 310);
            this.richTextBoxObjectDetails.TabIndex = 6;
            this.richTextBoxObjectDetails.Text = "";
            // 
            // webBrowserWebcam
            // 
            this.webBrowserWebcam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserWebcam.Location = new System.Drawing.Point(670, 28);
            this.webBrowserWebcam.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserWebcam.Name = "webBrowserWebcam";
            this.webBrowserWebcam.Size = new System.Drawing.Size(329, 310);
            this.webBrowserWebcam.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Autobahn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Details";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(670, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Webcam";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // webBrowserGIS
            // 
            this.webBrowserGIS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserGIS.Location = new System.Drawing.Point(3, 490);
            this.webBrowserGIS.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserGIS.Name = "webBrowserGIS";
            this.webBrowserGIS.Size = new System.Drawing.Size(1002, 342);
            this.webBrowserGIS.TabIndex = 10;
            this.webBrowserGIS.Url = new System.Uri("https://www.openstreetmap.org/#map=6/51.193/10.437", System.UriKind.Absolute);
            // 
            // tableLayoutPanelMainWindow
            // 
            this.tableLayoutPanelMainWindow.ColumnCount = 1;
            this.tableLayoutPanelMainWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMainWindow.Controls.Add(this.tableLayoutPaneServiceButtons, 0, 1);
            this.tableLayoutPanelMainWindow.Controls.Add(this.tableLayoutPanelRoad, 0, 0);
            this.tableLayoutPanelMainWindow.Controls.Add(this.webBrowserGIS, 0, 3);
            this.tableLayoutPanelMainWindow.Controls.Add(this.tableLayoutPanelDetails, 0, 2);
            this.tableLayoutPanelMainWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMainWindow.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanelMainWindow.Name = "tableLayoutPanelMainWindow";
            this.tableLayoutPanelMainWindow.RowCount = 4;
            this.tableLayoutPanelMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMainWindow.Size = new System.Drawing.Size(1008, 835);
            this.tableLayoutPanelMainWindow.TabIndex = 14;
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
            this.tableLayoutPaneServiceButtons.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPaneServiceButtons.Name = "tableLayoutPaneServiceButtons";
            this.tableLayoutPaneServiceButtons.RowCount = 1;
            this.tableLayoutPaneServiceButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPaneServiceButtons.Size = new System.Drawing.Size(1002, 94);
            this.tableLayoutPaneServiceButtons.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(833, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 94);
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
            this.label5.Location = new System.Drawing.Point(667, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 94);
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
            this.label4.Location = new System.Drawing.Point(501, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 94);
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
            this.label7.Location = new System.Drawing.Point(335, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 94);
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
            this.label8.Location = new System.Drawing.Point(169, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 94);
            this.label8.TabIndex = 17;
            this.label8.Text = "Baustellen";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQueryWebcams
            // 
            this.btnQueryWebcams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQueryWebcams.BackColor = System.Drawing.SystemColors.Control;
            this.btnQueryWebcams.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQueryWebcams.BackgroundImage")));
            this.btnQueryWebcams.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQueryWebcams.Location = new System.Drawing.Point(86, 3);
            this.btnQueryWebcams.Name = "btnQueryWebcams";
            this.btnQueryWebcams.Size = new System.Drawing.Size(77, 88);
            this.btnQueryWebcams.TabIndex = 10;
            this.btnQueryWebcams.UseVisualStyleBackColor = false;
            this.btnQueryWebcams.Click += new System.EventHandler(this.btnQueryWebcams_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 94);
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
            this.btnQueryRoadworks.Location = new System.Drawing.Point(252, 3);
            this.btnQueryRoadworks.Name = "btnQueryRoadworks";
            this.btnQueryRoadworks.Size = new System.Drawing.Size(77, 88);
            this.btnQueryRoadworks.TabIndex = 11;
            this.btnQueryRoadworks.UseVisualStyleBackColor = true;
            this.btnQueryRoadworks.Click += new System.EventHandler(this.btnQueryRoadworks_Click);
            // 
            // btnQueryParkingLorries
            // 
            this.btnQueryParkingLorries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQueryParkingLorries.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQueryParkingLorries.BackgroundImage")));
            this.btnQueryParkingLorries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQueryParkingLorries.Location = new System.Drawing.Point(418, 3);
            this.btnQueryParkingLorries.Name = "btnQueryParkingLorries";
            this.btnQueryParkingLorries.Size = new System.Drawing.Size(77, 88);
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
            this.btnQueryClosures.Location = new System.Drawing.Point(584, 3);
            this.btnQueryClosures.Name = "btnQueryClosures";
            this.btnQueryClosures.Size = new System.Drawing.Size(77, 88);
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
            this.btnQueryElectricChargingStations.Location = new System.Drawing.Point(750, 3);
            this.btnQueryElectricChargingStations.Name = "btnQueryElectricChargingStations";
            this.btnQueryElectricChargingStations.Size = new System.Drawing.Size(77, 88);
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
            this.btnQueryWarnings.Location = new System.Drawing.Point(916, 3);
            this.btnQueryWarnings.Name = "btnQueryWarnings";
            this.btnQueryWarnings.Size = new System.Drawing.Size(83, 88);
            this.btnQueryWarnings.TabIndex = 15;
            this.btnQueryWarnings.UseVisualStyleBackColor = true;
            this.btnQueryWarnings.Click += new System.EventHandler(this.btnQueryWarnings_Click);
            // 
            // tableLayoutPanelRoad
            // 
            this.tableLayoutPanelRoad.ColumnCount = 2;
            this.tableLayoutPanelRoad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.386188F));
            this.tableLayoutPanelRoad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.61381F));
            this.tableLayoutPanelRoad.Controls.Add(this.labelRoad, 0, 0);
            this.tableLayoutPanelRoad.Controls.Add(this.comboBoxRoad, 1, 0);
            this.tableLayoutPanelRoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelRoad.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelRoad.Name = "tableLayoutPanelRoad";
            this.tableLayoutPanelRoad.RowCount = 1;
            this.tableLayoutPanelRoad.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelRoad.Size = new System.Drawing.Size(1002, 34);
            this.tableLayoutPanelRoad.TabIndex = 0;
            // 
            // labelRoad
            // 
            this.labelRoad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRoad.AutoSize = true;
            this.labelRoad.Location = new System.Drawing.Point(3, 0);
            this.labelRoad.Name = "labelRoad";
            this.labelRoad.Size = new System.Drawing.Size(78, 34);
            this.labelRoad.TabIndex = 3;
            this.labelRoad.Text = "Autobahn";
            this.labelRoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxRoad
            // 
            this.comboBoxRoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxRoad.FormattingEnabled = true;
            this.comboBoxRoad.Location = new System.Drawing.Point(87, 6);
            this.comboBoxRoad.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.comboBoxRoad.Name = "comboBoxRoad";
            this.comboBoxRoad.Size = new System.Drawing.Size(163, 21);
            this.comboBoxRoad.TabIndex = 8;
            this.comboBoxRoad.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoad_SelectedIndexChanged);
            // 
            // tableLayoutPanelDetails
            // 
            this.tableLayoutPanelDetails.ColumnCount = 3;
            this.tableLayoutPanelDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelDetails.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelDetails.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanelDetails.Controls.Add(this.webBrowserWebcam, 2, 1);
            this.tableLayoutPanelDetails.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanelDetails.Controls.Add(this.richTextBoxObjectDetails, 1, 1);
            this.tableLayoutPanelDetails.Controls.Add(this.listBoxObjects, 0, 1);
            this.tableLayoutPanelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDetails.Location = new System.Drawing.Point(3, 143);
            this.tableLayoutPanelDetails.Name = "tableLayoutPanelDetails";
            this.tableLayoutPanelDetails.RowCount = 2;
            this.tableLayoutPanelDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDetails.Size = new System.Drawing.Size(1002, 341);
            this.tableLayoutPanelDetails.TabIndex = 1;
            // 
            // AutobahnMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 881);
            this.Controls.Add(this.tableLayoutPanelMainWindow);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AutobahnMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutobahnMonitor v1.0 - Andreas Zahnleiter - Free to use";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanelMainWindow.ResumeLayout(false);
            this.tableLayoutPaneServiceButtons.ResumeLayout(false);
            this.tableLayoutPaneServiceButtons.PerformLayout();
            this.tableLayoutPanelRoad.ResumeLayout(false);
            this.tableLayoutPanelRoad.PerformLayout();
            this.tableLayoutPanelDetails.ResumeLayout(false);
            this.tableLayoutPanelDetails.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMainWindow;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRoad;
        private System.Windows.Forms.Label labelRoad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDetails;
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

