using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Modern_Real_Estate.Model.EstateTypes
{
    public class Apartment : Residential
    {
        public Apartment(int id, string streetName, int zipCode, string city, string country, double area, double price, double rate, string imagePath, int rooms) : base(id, streetName, zipCode, city, country, area, price, rate, imagePath, rooms)
        {
            
        }
    }
}

