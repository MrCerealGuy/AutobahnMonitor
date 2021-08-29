using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;

using static AutobahnMonitor.MyGlobals;
using static AutobahnMonitor.WebAPIHelper.MyGlobals;

namespace AutobahnMonitor
{
    public partial class AutobahnMonitor : Form
    {
        public AutobahnMonitor()
        {
            InitializeComponent();

            // Init roads
            var jsonRoads = curlRequest(serverUri + "/");

            jsonDeserializedRoads = deserializeJSONRoads(jsonRoads);

            foreach (var road in jsonDeserializedRoads.roads)
                comboBoxRoad.Items.Add(road.ToString());

            comboBoxRoad.SelectedIndex = 0;

            // Init services
            foreach (var service in services)
                comboBoxService.Items.Add(service.Value.deDescription);

            comboBoxService.SelectedIndex = 0;

            // Query service from selected road
            queryServiceFromRoad(comboBoxRoad.SelectedItem.ToString(), comboBoxService.SelectedItem.ToString());
        }

        private void buttonQueryService_Click(object sender, EventArgs e)
        {
            var road = comboBoxRoad.SelectedItem.ToString();
            var service = comboBoxService.SelectedItem.ToString();

            queryServiceFromRoad(road, service);
        }

        private void listBoxObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            var road = listBoxObjects.SelectedItem.ToString();
            var service = comboBoxService.SelectedItem.ToString();

            queryDetailsFromRoad(road, service);
        }

        private void comboBoxRoad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
