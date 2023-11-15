﻿using System;
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
      public int Id { get; set; } public string StreetName { get; set; } public int ZipCode { get; set; }
      public string City { get; set; } public string Country { get; set; }
      public double Area_InSqm { get; set; } public double Price { get; set; } 
      public double Rate { get; set; } public double TaxedPrice { get; set; } public int PricePerSqm { get; set; }
      public string ImagePath { get; set; }
      public string Category { get; set; } public string Type { get; set; }

      public Estate(int id, string streetName, int zipCode, string city, string country, double area, double price, double rate, string imagePath){
         this.Id = id; this.StreetName = streetName; this.ZipCode = zipCode;
         this.City = city; this.Country = country; this.Area_InSqm = area;
         this.Price = price; this.ImagePath = imagePath;

         this.TaxedPrice = this.CalculateTaxedPrice(price, this.Rate);
         this.PricePerSqm = (int)Math.Round(this.Price / this.Area_InSqm);

         if(this is Residential) { this.Category = "Residential"; }
         else if(this is Commercial) { this.Category = "Commercial"; }
         else if(this is Institutional) { this.Category = "Institutional"; }
         else { this.Category = "Unclassified Category"; }

         //P: Resi
         if(this is Apartment) { this.Type = "Apartment"; }
         else if (this is Townhouse) { this.Type = "Townhouse"; }
         else if (this is Villa) { this.Type = "Villa"; }

         //P: Comm
         else if (this is Shop) { this.Type = "Shop"; }
         else if (this is Warehouse) { this.Type = "Warehouse"; }

         //P: Inst
         else if (this is Hospital) { this.Type = "Hospital"; }
         else if (this is School) { this.Type = "School"; }
         else if (this is University) { this.Type = "University"; }

         else { this.Type = "Unclassified Type"; }




      }


      public virtual double CalculateTaxedPrice(double price, double rate) {
         return price * (1 + rate);
      }

      public override string ToString()
      {
         return "id: " + Id + " streetName: " + StreetName + " zipCode: " + ZipCode + " city: " + City + " country: " + Country + " area: " + Area_InSqm + " price: " + Price + " imagepath: " + ImagePath;
      }


   }

}
