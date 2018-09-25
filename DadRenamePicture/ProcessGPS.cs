using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;

using System.Web;
using System.Net;
using System.Xml;

namespace DadRenamePicture
{
    class ProcessGPS
    {
        static string GEO_URL = "https://maps.googleapis.com/maps/api/geocode/xml?latlng=";
        public static string GetGPSLocation(Image targetImg)
        {
            float? latitude = ProcessGPS.GetLatitude(targetImg);
            float? longtitude = ProcessGPS.GetLongitude(targetImg);

            if(latitude==null || longtitude==null) {
                return "";
            }

            string locationUrl = GEO_URL + latitude.ToString() + "," + longtitude.ToString();

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
                return nodes[0].InnerText ;
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.Message);
                return "";
            }

        }

        public static float? GetLatitude(Image targetImg)
        {
            try
            {
                //Property Item 0x0001 - PropertyTagGpsLatitudeRef
                PropertyItem propItemRef = targetImg.GetPropertyItem(1);
                //Property Item 0x0002 - PropertyTagGpsLatitude
                PropertyItem propItemLat = targetImg.GetPropertyItem(2);
                return ExifGpsToFloat(propItemRef, propItemLat);
            }
            catch (ArgumentException)
            {
                return null;
            }
        }

        public static float? GetLongitude(Image targetImg)
        {
            try
            {
                ///Property Item 0x0003 - PropertyTagGpsLongitudeRef
                PropertyItem propItemRef = targetImg.GetPropertyItem(3);
                //Property Item 0x0004 - PropertyTagGpsLongitude
                PropertyItem propItemLong = targetImg.GetPropertyItem(4);
                return ExifGpsToFloat(propItemRef, propItemLong);
            }
            catch (ArgumentException)
            {
                return null;
            }
        }

        private static float ExifGpsToFloat(PropertyItem propItemRef, PropertyItem propItem)
        {
            uint degreesNumerator = BitConverter.ToUInt32(propItem.Value, 0);
            uint degreesDenominator = BitConverter.ToUInt32(propItem.Value, 4);
            float degrees = degreesNumerator / (float)degreesDenominator;

            uint minutesNumerator = BitConverter.ToUInt32(propItem.Value, 8);
            uint minutesDenominator = BitConverter.ToUInt32(propItem.Value, 12);
            float minutes = minutesNumerator / (float)minutesDenominator;

            uint secondsNumerator = BitConverter.ToUInt32(propItem.Value, 16);
            uint secondsDenominator = BitConverter.ToUInt32(propItem.Value, 20);
            float seconds = secondsNumerator / (float)secondsDenominator;

            float coorditate = degrees + (minutes / 60f) + (seconds / 3600f);
            string gpsRef = System.Text.Encoding.ASCII.GetString(new byte[1] { propItemRef.Value[0] }); //N, S, E, or W
            if (gpsRef == "S" || gpsRef == "W")
                coorditate = 0 - coorditate;
            return coorditate;
        }
    }
}
