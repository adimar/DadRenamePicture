using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Web;
using System.Net;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DadRenamePicture.GeoCode
{
    /*
    {
    "place_id": "26693344",
    "licence": "© LocationIQ.com CC BY 4.0, Data © OpenStreetMap contributors, ODbL 1.0",
    "osm_type": "node",
    "osm_id": "2525193585",
    "lat": "-37.870662",
    "lon": "144.9803321",
    "display_name": "Imbiss 25, Blessington Street, St Kilda, City of Port Phillip, Greater Melbourne, Victoria, 3182, Australia",
    "address": {
        "cafe": "Imbiss 25",
        "road": "Blessington Street",
        "suburb": "St Kilda",
        "county": "City of Port Phillip",
        "region": "Greater Melbourne",
        "state": "Victoria",
        "postcode": "3182",
        "country": "Australia",
        "country_code": "au"
    },
    "boundingbox": [
        "-37.870762",
        "-37.870562",
        "144.9802321",
        "144.9804321"
    ]
}
    */
    struct LocationIQLocation
    {
        public string place_id { get; set; }
        public string licence { get; set; }
        public string osm_type { get; set; }
        public string osm_id { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }
        public string display_name { get; set; }
        public object address { get; set; }
    
        string[] boundingbox { get; set; }

    }

    class LocationIQPlugin : GeoCodeServicePlugin
    {
        private const string KEY = "114f2b3373fd7e";
        private const string GEO_URL = "https://us1.locationiq.com/v1/reverse.php?key={0}&lat={1}&lon={2}&format=json";

        public string ResolveGPSCordinates(GeoCoordinate cord)
        {

            string locationUrl = String.Format(GEO_URL, KEY, cord.Latitude,cord.Longtitude);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(locationUrl);
            request.Method = "GET";

            try
            {
                WebResponse webRes = request.GetResponse();
                Stream webStream = webRes.GetResponseStream();
                StreamReader responseReader = new StreamReader(webStream);
                string response = responseReader.ReadToEnd();
                responseReader.Close();
                LocationIQLocation responseObj = JsonConvert.DeserializeObject<LocationIQLocation>(response);
                return responseObj.display_name;
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.Message);
                return "";
            }
        }
    }
}
