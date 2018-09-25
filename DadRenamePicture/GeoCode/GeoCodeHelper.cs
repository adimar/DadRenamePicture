using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DadRenamePicture.GeoCode
{

    interface GeoCodeServicePlugin
    {
        string ResolveGPSCordinates(GeoCoordinate cord);
    }

    class GeoCodeHelper
    {
        private static GeoCodeServicePlugin geoCodePlugin = new MapQuestPlugin();
        public static string ResolveGeoCoordinates(Image workImage)
        {
            GeoCoordinate cord = ExifToGeoCoordinate.GetGeoCoordinate(workImage);
            if (cord.IsNull)
            {
                return "";
            }
            return geoCodePlugin.ResolveGPSCordinates(cord);
        }

    }
}
