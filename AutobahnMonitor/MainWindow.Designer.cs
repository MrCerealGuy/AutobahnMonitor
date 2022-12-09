
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
            this.labelRoadService = new System.Windows.Forms.Label();
            this.labelServiceDetails = new System.Windows.Forms.Label();
            this.labelWebcam = new System.Windows.Forms.Label();
            this.webBrowserGIS = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanelMainWindow = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPaneServiceButtons = new System.Windows.Forms.TableLayoutPanel();
            this.labelWarnings = new System.Windows.Forms.Label();
            this.labelElectricChargingStations = new System.Windows.Forms.Label();
            this.labelClosures = new System.Windows.Forms.Label();
            this.labelParkingLorries = new System.Windows.Forms.Label();
            this.labelRoadworks = new System.Windows.Forms.Label();
            this.btnQueryWebcams = new System.Windows.Forms.Button();
            this.labelWebcams = new System.Windows.Forms.Label();
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
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
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
            this.listBoxObjects.TabIndex = 7;
            this.listBoxObjects.SelectedIndexChanged += new System.EventHandler(this.listBoxObjects_SelectedIndexChanged);
            // 
            // richTextBoxObjectDetails
            // 
            this.richTextBoxObjectDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxObjectDetails.Location = new System.Drawing.Point(336, 28);
            this.richTextBoxObjectDetails.Name = "richTextBoxObjectDetails";
            this.richTextBoxObjectDetails.Size = new System.Drawing.Size(328, 310);
            this.richTextBoxObjectDetails.TabIndex = 8;
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
            // labelRoadService
            // 
            this.labelRoadService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelRoadService.AutoSize = true;
            this.labelRoadService.Location = new System.Drawing.Point(3, 0);
            this.labelRoadService.Name = "labelRoadService";
            this.labelRoadService.Size = new System.Drawing.Size(53, 25);
            this.labelRoadService.TabIndex = 11;
            this.labelRoadService.Text = "Autobahn";
            this.labelRoadService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelServiceDetails
            // 
            this.labelServiceDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelServiceDetails.AutoSize = true;
            this.labelServiceDetails.Location = new System.Drawing.Point(336, 0);
            this.labelServiceDetails.Name = "labelServiceDetails";
            this.labelServiceDetails.Size = new System.Drawing.Size(39, 25);
            this.labelServiceDetails.TabIndex = 12;
            this.labelServiceDetails.Text = "Details";
            this.labelServiceDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWebcam
            // 
            this.labelWebcam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelWebcam.AutoSize = true;
            this.labelWebcam.Location = new System.Drawing.Point(670, 0);
            this.labelWebcam.Name = "labelWebcam";
            this.labelWebcam.Size = new System.Drawing.Size(50, 25);
            this.labelWebcam.TabIndex = 13;
            this.labelWebcam.Text = "Webcam";
            this.labelWebcam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // webBrowserGIS
            // 
            this.webBrowserGIS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserGIS.Location = new System.Drawing.Point(3, 490);
            this.webBrowserGIS.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserGIS.Name = "webBrowserGIS";
            this.webBrowserGIS.ScriptErrorsSuppressed = true;
            this.webBrowserGIS.Size = new System.Drawing.Size(1002, 342);
            this.webBrowserGIS.TabIndex = 10;
            this.webBrowserGIS.Url = new System.Uri("https://www.google.com/maps", System.UriKind.Absolute);
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
            this.tableLayoutPaneServiceButtons.Controls.Add(this.labelWarnings, 10, 0);
            this.tableLayoutPaneServiceButtons.Controls.Add(this.labelElectricChargingStations, 8, 0);
            this.tableLayoutPaneServiceButtons.Controls.Add(this.labelClosures, 6, 0);
            this.tableLayoutPaneServiceButtons.Controls.Add(this.labelParkingLorries, 4, 0);
            this.tableLayoutPaneServiceButtons.Controls.Add(this.labelRoadworks, 2, 0);
            this.tableLayoutPaneServiceButtons.Controls.Add(this.btnQueryWebcams, 1, 0);
            this.tableLayoutPaneServiceButtons.Controls.Add(this.labelWebcams, 0, 0);
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
            // labelWarnings
            // 
            this.labelWarnings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWarnings.AutoSize = true;
            this.labelWarnings.Location = new System.Drawing.Point(833, 0);
            this.labelWarnings.Name = "labelWarnings";
            this.labelWarnings.Size = new System.Drawing.Size(77, 94);
            this.labelWarnings.TabIndex = 21;
            this.labelWarnings.Text = "Warnungen";
            this.labelWarnings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelElectricChargingStations
            // 
            this.labelElectricChargingStations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelElectricChargingStations.AutoSize = true;
            this.labelElectricChargingStations.Location = new System.Drawing.Point(667, 0);
            this.labelElectricChargingStations.Name = "labelElectricChargingStations";
            this.labelElectricChargingStations.Size = new System.Drawing.Size(77, 94);
            this.labelElectricChargingStations.TabIndex = 20;
            this.labelElectricChargingStations.Text = "Ladestationen";
            this.labelElectricChargingStations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelClosures
            // 
            this.labelClosures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClosures.AutoSize = true;
            this.labelClosures.Location = new System.Drawing.Point(501, 0);
            this.labelClosures.Name = "labelClosures";
            this.labelClosures.Size = new System.Drawing.Size(77, 94);
            this.labelClosures.TabIndex = 19;
            this.labelClosures.Text = "Sperrungen";
            this.labelClosures.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelParkingLorries
            // 
            this.labelParkingLorries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelParkingLorries.AutoSize = true;
            this.labelParkingLorries.Location = new System.Drawing.Point(335, 0);
            this.labelParkingLorries.Name = "labelParkingLorries";
            this.labelParkingLorries.Size = new System.Drawing.Size(77, 94);
            this.labelParkingLorries.TabIndex = 18;
            this.labelParkingLorries.Text = "Rastplätze";
            this.labelParkingLorries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRoadworks
            // 
            this.labelRoadworks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRoadworks.AutoSize = true;
            this.labelRoadworks.Location = new System.Drawing.Point(169, 0);
            this.labelRoadworks.Name = "labelRoadworks";
            this.labelRoadworks.Size = new System.Drawing.Size(77, 94);
            this.labelRoadworks.TabIndex = 17;
            this.labelRoadworks.Text = "Baustellen";
            this.labelRoadworks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnQueryWebcams.TabIndex = 1;
            this.btnQueryWebcams.UseVisualStyleBackColor = false;
            this.btnQueryWebcams.Click += new System.EventHandler(this.btnQueryWebcams_Click);
            // 
            // labelWebcams
            // 
            this.labelWebcams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWebcams.AutoSize = true;
            this.labelWebcams.Location = new System.Drawing.Point(3, 0);
            this.labelWebcams.Name = "labelWebcams";
            this.labelWebcams.Size = new System.Drawing.Size(77, 94);
            this.labelWebcams.TabIndex = 16;
            this.labelWebcams.Text = "Webcams";
            this.labelWebcams.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnQueryRoadworks.TabIndex = 2;
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
            this.btnQueryParkingLorries.Location = new System.Drawing.Point(418, 3);
            this.btnQueryParkingLorries.Name = "btnQueryParkingLorries";
            this.btnQueryParkingLorries.Size = new System.Drawing.Size(77, 88);
            this.btnQueryParkingLorries.TabIndex = 3;
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
            this.btnQueryClosures.TabIndex = 4;
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
            this.btnQueryElectricChargingStations.TabIndex = 5;
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
            this.btnQueryWarnings.TabIndex = 6;
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
            this.comboBoxRoad.TabIndex = 0;
            this.comboBoxRoad.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoad_SelectedIndexChanged);
            // 
            // tableLayoutPanelDetails
            // 
            this.tableLayoutPanelDetails.ColumnCount = 3;
            this.tableLayoutPanelDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelDetails.Controls.Add(this.labelRoadService, 0, 0);
            this.tableLayoutPanelDetails.Controls.Add(this.labelWebcam, 2, 0);
            this.tableLayoutPanelDetails.Controls.Add(this.webBrowserWebcam, 2, 1);
            this.tableLayoutPanelDetails.Controls.Add(this.labelServiceDetails, 1, 0);
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
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "AutobahnMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutobahnMonitor v1.1 - Andreas Zahnleiter - Free to use";
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
        private System.Windows.Forms.Label labelRoadService;
        private System.Windows.Forms.Label labelServiceDetails;
        private System.Windows.Forms.Label labelWebcam;
        private System.Windows.Forms.WebBrowser webBrowserGIS;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMainWindow;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRoad;
        private System.Windows.Forms.Label labelRoad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDetails;
        private System.Windows.Forms.ComboBox comboBoxRoad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPaneServiceButtons;
        private System.Windows.Forms.Label labelWarnings;
        private System.Windows.Forms.Label labelElectricChargingStations;
        private System.Windows.Forms.Label labelClosures;
        private System.Windows.Forms.Label labelParkingLorries;
        private System.Windows.Forms.Label labelRoadworks;
        private System.Windows.Forms.Button btnQueryWebcams;
        private System.Windows.Forms.Label labelWebcams;
        private System.Windows.Forms.Button btnQueryRoadworks;
        private System.Windows.Forms.Button btnQueryParkingLorries;
        private System.Windows.Forms.Button btnQueryClosures;
        private System.Windows.Forms.Button btnQueryElectricChargingStations;
        private System.Windows.Forms.Button btnQueryWarnings;
    }
}

