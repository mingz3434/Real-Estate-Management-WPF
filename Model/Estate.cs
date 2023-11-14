using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore;
using Modern_Real_Estate.Model;
using Modern_Real_Estate.Model.EstateTypes;
using Modern_Real_Estate.Utilities;

namespace Modern_Real_Estate.Model{
   [Serializable]
   [XmlInclude(typeof(Apartment))]
   [XmlInclude(typeof(Hospital))]
   [XmlInclude(typeof(School))]
   [XmlInclude(typeof(Shop))]
   [XmlInclude(typeof(Townhouse))]
   [XmlInclude(typeof(University))]
   [XmlInclude(typeof(Villa))]
   [XmlInclude(typeof(Warehouse))]
   public class Estate{
      //Fuck all properties.
      public int Id { get; set; } public string StreetName { get; set; } public int ZipCode { get; set; } public string City { get; set; } public string Country { get; set; } public int Area { get; set; } public double Price { get; set; } public string ImagePath { get; set; }


      public Estate() { }

      public Estate(int id, string streetName, int zipCode, string city, string country, int area, double price, string imagePath){
         this.Id = id; this.StreetName = streetName; this.ZipCode = zipCode;
         this.City = city; this.Country = country; this.Area = area;
         this.Price = price; this.ImagePath = imagePath;

      }



      public virtual void CalculatePrice(double price) { }

      public override string ToString()
      {
         return "id: " + Id + " streetName: " + StreetName + " zipCode: " + ZipCode + " city: " + City + " country: " + Country + " area: " + Area + " price: " + Price + " imagepath: " + ImagePath;
      }


   }

}
