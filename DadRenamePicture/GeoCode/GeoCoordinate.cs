using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DadRenamePicture.GeoCode
{
   
    public struct GeoCoordinate
    {
        private bool hasValue;
        private readonly double latitude;
        private readonly double longtitude;

        public double Latitude { get { return latitude; } }
        public double Longtitude { get { return longtitude; } }

        public GeoCoordinate(double latitude, double longtitude)
        {
            this.hasValue = (latitude == -1 || longtitude == -1);
            this.latitude = latitude;
            this.longtitude = longtitude;
        }

        public bool IsNull
        {
            get {
                return this.hasValue;
            }
        }

        public override string ToString()
        {
            return string.Format("{0},{1}", Latitude, longtitude);
        }

        public override bool Equals(Object other)
        {
            return other is GeoCoordinate && Equals((GeoCoordinate)other);
        }

        public bool Equals(GeoCoordinate other)
        {
            return Latitude == other.Latitude && Longtitude == other.Longtitude;
        }

        public override int GetHashCode()
        {
            return Latitude.GetHashCode() ^ Longtitude.GetHashCode();
        }
    }
}

