using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.IO;
using System.Net;

using AutobahnMonitor.WebAPIHelper;
using static AutobahnMonitor.WebAPIHelper.MyGlobals;

namespace AutobahnMonitor
{
    public static partial class MyGlobals
    {
        //readonly List<string> sources = new List<string> {
        //    "Autobahnen", "Baustellen", "Staus", "Rastplätze", "Webcams", "Verkehrsmeldungen", "Sperrungen", "Ladestationen" };

        public static readonly string serverUri = "https://verkehr.autobahn.de/o/autobahn";
       
        public static JSONRoads jsonDeserializedRoads;
        public static JSONRoadworks jsonDeserializedRoadworks;
        public static JSONWebcams jsonDeserializedWebcams;

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
        };
    }
   
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AutobahnMonitor());
        }
    }
}
