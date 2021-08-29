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

            // Query first road
            queryServiceFromRoad(comboBoxRoad.SelectedItem.ToString(), comboBoxService.SelectedItem.ToString());
        }

        private void queryServiceFromRoad(string road, string service)
        {
            listBoxObjects.Items.Clear();
            richTextBoxObjectDetails.Clear();

            if (service.Equals("Baustellen"))
            {

                string jsonRoadworks = queryJSONServiceFromRoad(road, service);

                jsonDeserializedRoadworks = deserializeJSONRoadworks(jsonRoadworks);

                foreach (var roadwork in jsonDeserializedRoadworks.roadworks)
                    listBoxObjects.Items.Add(JObject.Parse(roadwork.ToString())["title"].ToString() + " - " + JObject.Parse(roadwork.ToString())["subtitle"].ToString());
            }
            else if (service.Equals("Webcams"))
            {
                string jsonWebcams = queryJSONServiceFromRoad(road, service);

                jsonDeserializedWebcams = deserializeJSONWebcams(jsonWebcams);

                foreach (var webcam in jsonDeserializedWebcams.webcams)
                    listBoxObjects.Items.Add(JObject.Parse(webcam.ToString())["title"].ToString() + " - " + JObject.Parse(webcam.ToString())["subtitle"].ToString());
            }

            if (listBoxObjects.Items.Count > 0)
                listBoxObjects.SelectedIndex = 0;

        }

        private void queryDetailsFromRoad(string road, string service)
        {
            if (service.Equals("Baustellen"))
            {
                var roadwork = jsonDeserializedRoadworks.roadworks.GetValue(listBoxObjects.SelectedIndex);
                var details = JObject.Parse(roadwork.ToString())["description"].ToString();
                var coordinate = JObject.Parse(roadwork.ToString())["coordinate"].ToString();
                var lat = JObject.Parse(coordinate)["lat"].ToString();
                var longitude = JObject.Parse(coordinate)["long"].ToString();

                richTextBoxObjectDetails.Text = details;

                // Update GIS
                updateWebcamAndGIS("", "", lat, longitude);
            }
            else if (service.Equals("Webcams"))
            {
                var webcam = jsonDeserializedWebcams.webcams.GetValue(listBoxObjects.SelectedIndex);
                var title = JObject.Parse(webcam.ToString())["title"].ToString();
                var operatorwebcam = JObject.Parse(webcam.ToString())["operator"].ToString();
                var imageurl = JObject.Parse(webcam.ToString())["imageurl"].ToString();
                var linkurl = JObject.Parse(webcam.ToString())["linkurl"].ToString();
                var coordinate = JObject.Parse(webcam.ToString())["coordinate"].ToString();
                var lat = JObject.Parse(coordinate)["lat"].ToString();
                var longitude = JObject.Parse(coordinate)["long"].ToString();

                richTextBoxObjectDetails.Text = $"Titel: {title}\nBetreiber: {operatorwebcam}\n\nBild-URL: {imageurl}\n\nVideo-URL: {linkurl}\n\nKoordinaten:{lat} (Lat.), {longitude} (Long.)";

                // Update Webcam and GIS
                updateWebcamAndGIS(linkurl, imageurl, lat, longitude); 
            }
        }

        private void updateWebcamAndGIS(string webcamVideoUri, string webcamImageUri, string lat, string longitude)
        {
            // Update Browser Webcam
            if (webcamVideoUri != "")
                webBrowserWebcam.Url = new System.Uri(webcamVideoUri);
            else if (webcamImageUri != "")
                webBrowserWebcam.Url = new System.Uri(webcamImageUri);

            // Update Browser GIS
            if (lat != "" && longitude != "")
                webBrowserGIS.Url = new System.Uri($"https://www.openstreetmap.org/?mlat={lat}&mlon={longitude}#map=12/{lat}/{longitude}");
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
            //buttonQuerySource_Click(sender, e);
        }
    }
}
