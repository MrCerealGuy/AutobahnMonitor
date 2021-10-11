using System;
using System.Windows.Forms;

using static AutobahnMonitor.MyGlobals;

namespace AutobahnMonitor
{
    public partial class AutobahnMonitor : Form
    { 
        public AutobahnMonitor()
        {
            InitializeComponent();
            InitAutobahnUI();
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
    }
}
