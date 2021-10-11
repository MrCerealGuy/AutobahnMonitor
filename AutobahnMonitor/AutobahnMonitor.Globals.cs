using System.Collections.Generic;
using static AutobahnMonitor.WebAPIHelper.MyGlobals;

namespace AutobahnMonitor
{
    public static partial class MyGlobals
    {
        public static readonly string serverUri = "https://verkehr.autobahn.de/o/autobahn";

        public static Dictionary<string, JSONArray> jsonDeserializedArray = new Dictionary<string, JSONArray> { };

        public static readonly Dictionary<string, AutobahnAPIService> services = new Dictionary<string, AutobahnAPIService> {
            { "Webcams", new AutobahnAPIService()
                {
                    deDescription = "Webcams",
                    enDescription = "webcam",
                    serviceUri = "/{roadId}/services/webcam",
                    detailsUri = "/details/webcam/{webcamId}",

                    detailsParams = new string[] { "title", "operator", "imageurl", "linkurl", "coordinate", "lat", "long" },
                    detailsFormat = "Titel: {title}\nBetreiber: {operator}\n\nBild-URL: {imageurl}\n\nVideo-URL: {linkurl}\n\nKoordinaten:{lat} (Lat.), {long} (Long.)"
                }
            },
            { "Baustellen", new AutobahnAPIService()
                {
                    deDescription = "Baustellen",
                    enDescription = "roadworks",
                    serviceUri = "/{roadId}/services/roadworks",
                    detailsUri = "/details/roadworks/{roadworkId}",

                    detailsParams = new string[] { "title", "subtitle", "description", "coordinate", "lat", "long" },
                    detailsFormat = "Titel: {title}\nUntertitel:{subtitle}\n\nBeschreibung:{description}\n\nKoordinaten:{lat} (Lat.), {long} (Long.)"
                }
            },
            {"Rastplätze", new AutobahnAPIService()
                {
                    deDescription = "Rastplätze",
                    enDescription = "parking_lorry",
                    serviceUri = "/{roadId}/services/parking_lorry",
                    detailsUri = "/details/parking_lorry/{lorryId}",

                    detailsParams = new string[] { "title", "subtitle", "description", "coordinate", "lat", "long" },
                    detailsFormat = "Titel: {title}\nUntertitel:{subtitle}\n\nBeschreibung:{description}\n\nKoordinaten:{lat} (Lat.), {long} (Long.)"
                }
            },
            {"Sperrungen", new AutobahnAPIService()
                {
                    deDescription = "Sperrungen",
                    enDescription = "closure",
                    serviceUri = "/{roadId}/services/closure",
                    detailsUri = "/details/closure/{closureId}",

                    detailsParams = new string[] { "title", "subtitle", "description", "coordinate", "lat", "long" },
                    detailsFormat = "Titel: {title}\nUntertitel:{subtitle}\n\nBeschreibung:{description}\n\nKoordinaten:{lat} (Lat.), {long} (Long.)"
                }
            },
            {"Ladestationen", new AutobahnAPIService()
                {
                    deDescription = "Ladestationen",
                    enDescription = "electric_charging_station",
                    serviceUri = "/{roadId}/services/electric_charging_station",
                    detailsUri = "/details/electric_charging_station/{stationId}",

                    detailsParams = new string[] { "title", "subtitle", "description", "coordinate", "lat", "long" },
                    detailsFormat = "Titel: {title}\nUntertitel:{subtitle}\n\nBeschreibung:{description}\n\nKoordinaten:{lat} (Lat.), {long} (Long.)"
                }
            }
        };

        public static System.Drawing.Color colorHighlightedServiceButton = System.Drawing.SystemColors.ButtonShadow;
    }
}