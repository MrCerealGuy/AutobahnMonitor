using System.Windows.Forms;
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
        }

        private void queryServiceFromRoad(string road, string service)
        {
            listBoxObjects.Items.Clear();
            richTextBoxObjectDetails.Clear();

            if (service.Equals("Baustellen"))
            {
                string jsonRoadworks = queryJSONServiceFromRoad(road, service);

                jsonDeserializedArray["roadworks"] = deserializeJSON(jsonRoadworks, "roadworks");

                foreach (var roadwork in jsonDeserializedArray["roadworks"].jsonArray)
                    listBoxObjects.Items.Add(JObject.Parse(roadwork.ToString())["title"].ToString() + " - " + JObject.Parse(roadwork.ToString())["subtitle"].ToString());
            }
            else if (service.Equals("Webcams"))
            {
                string jsonWebcams = queryJSONServiceFromRoad(road, service);

                jsonDeserializedArray["webcam"] = deserializeJSON(jsonWebcams, "webcam");

                foreach (var webcam in jsonDeserializedArray["webcam"].jsonArray)
                    listBoxObjects.Items.Add(JObject.Parse(webcam.ToString())["title"].ToString() + " - " + JObject.Parse(webcam.ToString())["subtitle"].ToString());
            }
            else if (service.Equals("Rastplätze"))
            {
                string jsonParkingLorries = queryJSONServiceFromRoad(road, service);

                jsonDeserializedArray["parking_lorry"] = deserializeJSON(jsonParkingLorries, "parking_lorry");

                foreach (var parking_lorry in jsonDeserializedArray["parking_lorry"].jsonArray)
                    listBoxObjects.Items.Add(JObject.Parse(parking_lorry.ToString())["title"].ToString() + " - " + JObject.Parse(parking_lorry.ToString())["subtitle"].ToString());
            }
            else if (service.Equals("Sperrungen"))
            {
                string jsonClosures = queryJSONServiceFromRoad(road, service);

                jsonDeserializedArray["closure"] = deserializeJSON(jsonClosures, "closure");

                foreach (var closure in jsonDeserializedArray["closure"].jsonArray)
                    listBoxObjects.Items.Add(JObject.Parse(closure.ToString())["title"].ToString() + " - " + JObject.Parse(closure.ToString())["subtitle"].ToString());
            }
            else if (service.Equals("Ladestationen"))
            {
                string jsonStations = queryJSONServiceFromRoad(road, service);

                jsonDeserializedArray["electric_charging_station"] = deserializeJSON(jsonStations, "electric_charging_station");

                foreach (var station in jsonDeserializedArray["electric_charging_station"].jsonArray)
                    listBoxObjects.Items.Add(JObject.Parse(station.ToString())["title"].ToString() + " - " + JObject.Parse(station.ToString())["subtitle"].ToString());
            }

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

            if (service.Equals("Baustellen"))
            {
                var roadwork = jsonDeserializedArray["roadworks"].jsonArray.GetValue(listBoxObjects.SelectedIndex);
                var title = JObject.Parse(roadwork.ToString())["title"].ToString();
                var subtitle = JObject.Parse(roadwork.ToString())["subtitle"].ToString();
                var description = JObject.Parse(roadwork.ToString())["description"].ToString();
                var coordinate = JObject.Parse(roadwork.ToString())["coordinate"].ToString();
                var lat = JObject.Parse(coordinate)["lat"].ToString();
                var longitude = JObject.Parse(coordinate)["long"].ToString();

                richTextBoxObjectDetails.Text = $"Titel: {title}\nUntertitel:{subtitle}\n\nBeschreibung:{description}\n\nKoordinaten:{lat} (Lat.), {longitude} (Long.)";

                // Update GIS
                updateWebcamAndGIS("", "", lat, longitude);
            }
            else if (service.Equals("Webcams"))
            {
                var webcam = jsonDeserializedArray["webcam"].jsonArray.GetValue(listBoxObjects.SelectedIndex);
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
            else if (service.Equals("Rastplätze"))
            {
                var parking_lorry = jsonDeserializedArray["parking_lorry"].jsonArray.GetValue(listBoxObjects.SelectedIndex);
                var title = JObject.Parse(parking_lorry.ToString())["title"].ToString();
                var subtitle = JObject.Parse(parking_lorry.ToString())["subtitle"].ToString();
                var description = JObject.Parse(parking_lorry.ToString())["description"].ToString();
                var coordinate = JObject.Parse(parking_lorry.ToString())["coordinate"].ToString();
                var lat = JObject.Parse(coordinate)["lat"].ToString();
                var longitude = JObject.Parse(coordinate)["long"].ToString();

                richTextBoxObjectDetails.Text = $"Titel: {title}\nUntertitel:{subtitle}\n\nBeschreibung:{description}\n\nKoordinaten:{lat} (Lat.), {longitude} (Long.)";

                // Update GIS
                updateWebcamAndGIS("", "", lat, longitude);
            }
            else if (service.Equals("Sperrungen"))
            {
                var closure = jsonDeserializedArray["closure"].jsonArray.GetValue(listBoxObjects.SelectedIndex);
                var title = JObject.Parse(closure.ToString())["title"].ToString();
                var subtitle = JObject.Parse(closure.ToString())["subtitle"].ToString();
                var description = JObject.Parse(closure.ToString())["description"].ToString();
                var coordinate = JObject.Parse(closure.ToString())["coordinate"].ToString();
                var lat = JObject.Parse(coordinate)["lat"].ToString();
                var longitude = JObject.Parse(coordinate)["long"].ToString();

                richTextBoxObjectDetails.Text = $"Titel: {title}\nUntertitel:{subtitle}\n\nBeschreibung:{description}\n\nKoordinaten:{lat} (Lat.), {longitude} (Long.)";

                // Update GIS
                updateWebcamAndGIS("", "", lat, longitude);
            }
            else if (service.Equals("Ladestationen"))
            {
                var station = jsonDeserializedArray["electric_charging_station"].jsonArray.GetValue(listBoxObjects.SelectedIndex);
                var title = JObject.Parse(station.ToString())["title"].ToString();
                var subtitle = JObject.Parse(station.ToString())["subtitle"].ToString();
                var description = JObject.Parse(station.ToString())["description"].ToString();
                var coordinate = JObject.Parse(station.ToString())["coordinate"].ToString();
                var lat = JObject.Parse(coordinate)["lat"].ToString();
                var longitude = JObject.Parse(coordinate)["long"].ToString();

                richTextBoxObjectDetails.Text = $"Titel: {title}\nUntertitel:{subtitle}\n\nBeschreibung:{description}\n\nKoordinaten:{lat} (Lat.), {longitude} (Long.)";

                // Update GIS
                updateWebcamAndGIS("", "", lat, longitude);
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
    }
}