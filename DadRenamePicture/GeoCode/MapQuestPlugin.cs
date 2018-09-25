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
    class MapQuestPlugin : GeoCodeServicePlugin
    {
        private const string MAPQUEST_KEY = "";
        private const string GEO_URL_MAPQUEST = "http://open.mapquestapi.com/geocoding/v1/reverse?key={0}&location={1}";

        public string ResolveGPSCordinates(GeoCoordinate cord)
        {

            string locationUrl = String.Format(GEO_URL_MAPQUEST, MAPQUEST_KEY, cord.ToString());
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
                    return "";
                }
                return nodes[0].InnerText;
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.Message);
                return "";
            }
        }
    }
}
