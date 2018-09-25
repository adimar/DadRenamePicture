using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Web;
using System.Net;
using System.Xml;

namespace DadRenamePicture.GeoCode
{
    class GoogleMapsPlugin : GeoCodeServicePlugin
    {
        private const string GEO_URL = "https://maps.googleapis.com/maps/api/geocode/xml?latlng=";

        public string ResolveGPSCordinates(GeoCoordinate cord)
        {

            string locationUrl = GEO_URL + cord.ToString();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(locationUrl);
            request.Method = "GET";

            try
            {
                WebResponse webRes = request.GetResponse();
                Stream webStream = webRes.GetResponseStream();
                StreamReader responseReader = new StreamReader(webStream);
                string response = responseReader.ReadToEnd();
                responseReader.Close();


                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(response);

                string xpath = "GeocodeResponse/result/formatted_address";
                var nodes = xmlDoc.SelectNodes(xpath);

                if (nodes.Count == 0)
                {
                    Console.WriteLine("google did not return location for coordinates:{0}", cord);
                    return "";
                }
                return nodes[0].InnerText;
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to get location from google maps error:{0}", e);
                return "";
            }
        }
    }
}
