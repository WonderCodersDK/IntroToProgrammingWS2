using System;

namespace classes
{
    public class Address 
    {
        public string Street;
        public int ZipCode;
        public string City;
        private double Latitude;
        private double Longtitude;

        public Address()
        {
            Street = string.Empty;
            ZipCode = 0;
            City = string.Empty;
            Latitude = 0.0;
            Longtitude = 0.0;
        }

        public Address(string street, int zipCode, string city)
        {
            Street = street;
            ZipCode = zipCode;
            City = city;
            Latitude = 0.0;
            Longtitude = 0.0;
        }

        public Address(string street, int zipCode, string city, double latitude, double longtitude)
        {
            Street = street;
            ZipCode = zipCode;
            City = city;
            Latitude = latitude;
            Longtitude = longtitude;
        }

        public void SetCoordinates(double latitude, double longtitude) 
        {
            Latitude = latitude;
            Longtitude = longtitude;
        }

        public string PrintCoordinates()
        {
            return "(" + Latitude.ToString() + ", " + Longtitude.ToString() + ")";
        }

        public string PrintAddress()
        {
            return Street + ", " + ZipCode.ToString() + " " + City;
        }
    }
}