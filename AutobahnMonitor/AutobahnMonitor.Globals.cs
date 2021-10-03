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
                    detailsUri = "/details/webcam/{webcamId}"
                }
            },
            { "Baustellen", new AutobahnAPIService()
                {
                    deDescription = "Baustellen",
                    enDescription = "roadworks",
                    serviceUri = "/{roadId}/services/roadworks",
                    detailsUri = "/details/roadworks/{roadworkId}"
                }
            },
            {"Rastplätze", new AutobahnAPIService()
                {
                    deDescription = "Rastplätze",
                    enDescription = "parking_lorry",
                    serviceUri = "/{roadId}/services/parking_lorry",
                    detailsUri = "/details/parking_lorry/{lorryId}"
                }
            },
            {"Sperrungen", new AutobahnAPIService()
                {
                    deDescription = "Sperrungen",
                    enDescription = "closure",
                    serviceUri = "/{roadId}/services/closure",
                    detailsUri = "/details/closure/{closureId}"
                }
            },
            {"Ladestationen", new AutobahnAPIService()
                {
                    deDescription = "Ladestationen",
                    enDescription = "electric_charging_station",
                    serviceUri = "/{roadId}/services/electric_charging_station",
                    detailsUri = "/details/electric_charging_station/{stationId}"
                }
            }
        };
    }
}