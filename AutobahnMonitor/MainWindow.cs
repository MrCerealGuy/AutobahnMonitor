using System;
using System.Windows.Forms;

namespace AutobahnMonitor
{
    public partial class AutobahnMonitor : Form
    {
        public AutobahnMonitor()
        {
            InitializeComponent();
            InitAutobahnUI();
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
