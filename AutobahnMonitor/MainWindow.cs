using System;
using System.Windows.Forms;

using static AutobahnMonitor.MyGlobals;

namespace AutobahnMonitor
{
    public partial class AutobahnMonitor : Form
    {

        public string activeService = "Webcams";

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

        }

        private void btnQueryWebcams_Click(object sender, EventArgs e)
        {
            var road = comboBoxRoad.SelectedItem.ToString();
            activeService = "Webcams";

            queryServiceFromRoad(road, activeService);
            queryDetailsFromRoad(road, activeService);
        }

        private void btnQueryRoadworks_Click(object sender, EventArgs e)
        {
            var road = comboBoxRoad.SelectedItem.ToString();
            activeService = "Baustellen";

            queryServiceFromRoad(road, activeService);
            queryDetailsFromRoad(road, activeService);
        }

        private void btnQueryParkingLorries_Click(object sender, EventArgs e)
        {
            var road = comboBoxRoad.SelectedItem.ToString();
            activeService = "Rastplätze";

            queryServiceFromRoad(road, activeService);
            queryDetailsFromRoad(road, activeService);
        }

        private void btnQueryClosures_Click(object sender, EventArgs e)
        {
            var road = comboBoxRoad.SelectedItem.ToString();
            activeService = "Sperrungen";

            queryServiceFromRoad(road, activeService);
            queryDetailsFromRoad(road, activeService);
        }

        private void btnQueryElectricChargingStations_Click(object sender, EventArgs e)
        {
            var road = comboBoxRoad.SelectedItem.ToString();
            activeService = "Ladestationen";

            queryServiceFromRoad(road, activeService);
            queryDetailsFromRoad(road, activeService);

        }

        private void btnQueryWarnings_Click(object sender, EventArgs e)
        {
            var road = comboBoxRoad.SelectedItem.ToString();
            activeService = "Warnungen";

            queryServiceFromRoad(road, activeService);
            queryDetailsFromRoad(road, activeService);
        }
    }
}
