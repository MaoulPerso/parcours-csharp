using System;

namespace CSharpDiscovery.Quest03
{
    public class PointOfInterest
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string? Name { get; set; }

        public static string GoogleMapsUrlTemplate { get; set; } = "https://www.google.com/maps/place/{0}/@{1},{2},15z/";

        public PointOfInterest()
        {
            Name = "Bordeaux Ynov Campus";
            Latitude = 44.854186;
            Longitude = -0.566305;
        }
        public PointOfInterest(string name, double latitude, double longitude)
        {
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}