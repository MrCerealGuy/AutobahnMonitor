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
                public string[] detailsParams { get; set; }
                public string detailsFormat { get; set; }
            }

            public class JSONArray
            {
                public JSONArray(string json, string propertyName)
                {
                    JObject jObject = JObject.Parse(json);
                    jsonArray = jObject[propertyName].ToArray();
                }

                public Array jsonArray { get; set; }
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

            public static JSONArray deserializeJSON(string json, string propertyName)
            {
                return new JSONArray(json, propertyName);
            }
            
            public static string queryJSONServiceFromRoad(string road, string service)
            {
                var serviceUri = services[service].serviceUri;
                return curlRequest(serverUri + "/" + serviceUri.Replace("{roadId}", road));
            }
        }
    }
}