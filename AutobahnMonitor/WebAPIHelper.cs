using System;
using System.Linq;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

using static AutobahnMonitor.MyGlobals;

namespace AutobahnMonitor
{
    namespace WebAPIHelper
    {
        public static partial class MyGlobals
        {
            public class AutobahnAPIService
            {
                public string deDescription { get; set; }
                public string enDescription { get; set; }
                public string serviceUri { get; set; }
                public string detailsUri { get; set; }
            }

            public class JSONRoads
            {
                public JSONRoads(string json)
                {
                    JObject jObject = JObject.Parse(json);
                    roads = jObject["roads"].ToArray();
                }

                public Array roads { get; set; }
            }

            public class JSONRoadworks
            {
                public JSONRoadworks(string json)
                {
                    JObject jObject = JObject.Parse(json);
                    roadworks = jObject["roadworks"].ToArray();
                }

                public Array roadworks { get; set; }

                //public string title {get; set;}
                //public string subtitle {get; set;}
            }

            public class JSONWebcams
            {
                public JSONWebcams(string json)
                {
                    JObject jObject = JObject.Parse(json);
                    webcams = jObject["webcam"].ToArray();
                }

                public Array webcams { get; set; }
            }

            public static string curlRequest(string url)
            {
                var httpRequest = (HttpWebRequest)WebRequest.Create(url);

                httpRequest.ContentType = "application/json";
                httpRequest.Accept = "application/json";

                try
                {
                    var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        return result;
                    }

                }
                catch (System.Net.WebException)
                {
                    return "";
                }
            }

            //public static string curlRequestRoadworks(string serviceUri, string roadId)
            //{
            //    return curlRequest(serverUri + "/"+serviceUri.Replace("{roadId}", roadId));
            //}

            public static JSONRoads deserializeJSONRoads(string json)
            {
                return new JSONRoads(json);
            }

            public static JSONRoadworks deserializeJSONRoadworks(string json)
            {
                return new JSONRoadworks(json);
            }

            public static JSONWebcams deserializeJSONWebcams(string json)
            {
                return new JSONWebcams(json);
            }

            public static string queryJSONServiceFromRoad(string road, string service)
            {
                var serviceUri = services[service].serviceUri;
                return curlRequest(serverUri + "/" + serviceUri.Replace("{roadId}", road));
            }
        }
    }
}