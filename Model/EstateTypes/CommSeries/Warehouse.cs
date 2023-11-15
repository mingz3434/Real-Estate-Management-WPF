using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern_Real_Estate.Model.EstateTypes
{
    public class Warehouse : Commercial
    {
        protected Warehouse(int id, string streetName, int zipCode, string city, string country, double area, double price, double rate, string imagePath) : base(id, streetName, zipCode, city, country, area, price, rate, imagePath)
        {
        }
    }
}
