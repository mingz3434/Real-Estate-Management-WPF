using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore;
using Modern_Real_Estate.Utilities;

namespace Modern_Real_Estate.Model.EstateTypes
{
    [XmlInclude(typeof(Residential))]
    public class Residential : Estate
    {
        public int Rooms { get; set; }
        public Residential(int id, string streetName, int zipCode, string city, string country,
            double area, double price, double rate, string imagePath, int rooms) :
            base( id=0, streetName, zipCode, city, country, area, price, rate, imagePath){

            this.Rooms = rooms;
            
        }
    }
}
