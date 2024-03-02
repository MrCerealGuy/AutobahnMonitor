using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

using static AutobahnMonitor.MyGlobals;

namespace AutobahnMonitor
{
    public partial class AutobahnMonitor : Form
    { 
        public AutobahnMonitor()
        {
            InitializeComponent();            
        }

        private void listBoxObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            var road = listBoxObjects.SelectedItem.ToString();

            queryDetailsFromRoad(road, activeService);
        }

        private void comboBoxRoad_SelectedIndexChanged(object sender, EventArgs e)
        {
            var road = comboBoxRoad.SelectedItem.ToString();

            queryServiceFromRoad(road, activeService);
            queryDetailsFromRoad(road, activeService);

            updateLabelRoadService();
        }

        private void btnQueryWebcams_Click(object sender, EventArgs e)
        {
            resetAllServiceButtonColor();
            btnQueryWebcams.BackColor = colorHighlightedServiceButton;

            queryServiceButtonHandler("Webcams");
        }

        private void btnQueryRoadworks_Click(object sender, EventArgs e)
        {
            resetAllServiceButtonColor();
            btnQueryRoadworks.BackColor = colorHighlightedServiceButton;

            queryServiceButtonHandler("Baustellen");
        }

        private void btnQueryParkingLorries_Click(object sender, EventArgs e)
        {
            resetAllServiceButtonColor();
            btnQueryParkingLorries.BackColor = colorHighlightedServiceButton;

            queryServiceButtonHandler("Rastplätze");
        }

        private void btnQueryClosures_Click(object sender, EventArgs e)
        {
            resetAllServiceButtonColor();
            btnQueryClosures.BackColor = colorHighlightedServiceButton;

            queryServiceButtonHandler("Sperrungen");
        }

        private void btnQueryElectricChargingStations_Click(object sender, EventArgs e)
        {
            resetAllServiceButtonColor();
            btnQueryElectricChargingStations.BackColor = colorHighlightedServiceButton;

            queryServiceButtonHandler("Ladestationen");
        }

        private void btnQueryWarnings_Click(object sender, EventArgs e)
        {
            resetAllServiceButtonColor();
            btnQueryWarnings.BackColor = colorHighlightedServiceButton;

            queryServiceButtonHandler("Warnungen");
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoDialog dlg = new InfoDialog();
            dlg.ShowDialog(this);
        }

        private async void AutobahnMonitor_Load(object sender, EventArgs e)
        {
            webBrowserGIS.CoreWebView2InitializationCompleted += WebView_CoreWebView2InitializationCompleted;

            Debug.WriteLine("before InitializeAsync");
            await InitializeAsync();
            Debug.WriteLine("after InitializeAsync");

            if ((webBrowserGIS == null) || (webBrowserGIS.CoreWebView2 == null))
            {
                Debug.WriteLine("not ready");
            }

            Debug.WriteLine("after NavigateToString");

            InitAutobahnUI();

            resetAllServiceButtonColor();
            btnQueryRoadworks.BackColor = colorHighlightedServiceButton;

            queryServiceButtonHandler("Baustellen");
        }

        private async Task InitializeAsync()
        {
            Debug.WriteLine("InitializeAsync");
            await webBrowserGIS.EnsureCoreWebView2Async(null);
            Debug.WriteLine("WebView2 Runtime version: " + webBrowserGIS.CoreWebView2.Environment.BrowserVersionString);
        }

        private void WebView_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            Debug.WriteLine("WebView_CoreWebView2InitializationCompleted");
        }
    }
}
