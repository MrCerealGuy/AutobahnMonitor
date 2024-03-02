using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Newtonsoft.Json.Linq;

using static AutobahnMonitor.MyGlobals;
using static AutobahnMonitor.WebAPIHelper.MyGlobals;

namespace AutobahnMonitor
{
    public partial class AutobahnMonitor : Form
    {
        public string activeService = "Webcams";

        private void InitAutobahnUI()
        {
            // Init roads
            var jsonRoads = curlRequest(serverUri + "/");

            jsonDeserializedArray["roads"] = deserializeJSON(jsonRoads, "roads");

            foreach (var road in jsonDeserializedArray["roads"].jsonArray)
                comboBoxRoad.Items.Add(road.ToString());

            comboBoxRoad.SelectedIndex = 0;

            // Query service from selected road
            btnQueryWebcams.BackColor = colorHighlightedServiceButton;
            queryServiceFromRoad(comboBoxRoad.SelectedItem.ToString(), activeService);

            updateLabelRoadService();
        }

        private void updateLabelRoadService()
        {
            labelRoadService.Text = "Autobahn " + comboBoxRoad.SelectedItem.ToString() + ": " + activeService;
        }

        private void resetAllServiceButtonColor()
        {
            btnQueryWebcams.BackColor = System.Drawing.SystemColors.Control;
            btnQueryRoadworks.BackColor = System.Drawing.SystemColors.Control;
            btnQueryParkingLorries.BackColor = System.Drawing.SystemColors.Control;
            btnQueryClosures.BackColor = System.Drawing.SystemColors.Control;
            btnQueryElectricChargingStations.BackColor = System.Drawing.SystemColors.Control;
            btnQueryWarnings.BackColor = System.Drawing.SystemColors.Control;
        }

        private void queryServiceButtonHandler(string service)
        {
            var road = comboBoxRoad.SelectedItem.ToString();
            activeService = service;

            queryServiceFromRoad(road, activeService);
            queryDetailsFromRoad(road, activeService);

            updateLabelRoadService();
        }

        private void queryServiceFromRoad(string road, string service)
        {
            listBoxObjects.Items.Clear();
            richTextBoxObjectDetails.Clear();

            string _json = queryJSONServiceFromRoad(road, service);

            jsonDeserializedArray[services[service].enDescription] = deserializeJSON(_json, services[service].enDescription);

            foreach (var roadObject in jsonDeserializedArray[services[service].enDescription].jsonArray)
                listBoxObjects.Items.Add(JObject.Parse(roadObject.ToString())["title"].ToString() + " - " + JObject.Parse(roadObject.ToString())["subtitle"].ToString());
          
            if (listBoxObjects.Items.Count > 0)
                listBoxObjects.SelectedIndex = 0;
        }

        private void queryDetailsFromRoad(string road, string service)
        {
            if (listBoxObjects.Items.Count == 0)
            {
                listBoxObjects.Items.Add("Keine " + service + " gefunden!");
                return;
            }

            var _jsonObject = jsonDeserializedArray[services[service].enDescription].jsonArray.GetValue(listBoxObjects.SelectedIndex);
            Dictionary<string, string> _params = new Dictionary<string, string> { };

            foreach (string _p in services[service].detailsParams)
                if (_p == "lat" || _p == "long")
                    _params[_p] = JObject.Parse(_params["coordinate"])[_p].ToString();
                else
                    _params[_p] = JObject.Parse(_jsonObject.ToString())[_p].ToString();

            var _s = services[service].detailsFormat;

            foreach (string _p in services[service].detailsParams)
                _s = _s.Replace("{" + _p + "}", _params[_p]);

            richTextBoxObjectDetails.Text = _s;

            // Update Webcam and GIS
            if (service == "Webcams")
                updateWebcamAndGIS(_params["title"], _params["linkurl"], _params["imageurl"], _params["lat"], _params["long"]);
            else
                updateWebcamAndGIS(_params["title"], "", "", _params["lat"], _params["long"]);
        }

        private void updateWebcamAndGIS(string title, string webcamVideoUri, string webcamImageUri, string lat, string longitude)
        {
            // Update Browser Webcam
            if (webcamVideoUri != "")
                webBrowserWebcam.Url = new System.Uri(webcamVideoUri);
            else if (webcamImageUri != "")
                webBrowserWebcam.Url = new System.Uri(webcamImageUri);

            if (title != "" && activeService == "Webcams")
                labelWebcam.Text = "Webcam: " + title;
            else
                labelWebcam.Text = "Webcam";

            // Update Browser GIS
            if (lat != "" && longitude != "")
                webBrowserGIS.Source = new System.Uri($"http://maps.google.com/maps?q={lat},{longitude}&ll={lat},{longitude}&z=14");
        }
    }
}