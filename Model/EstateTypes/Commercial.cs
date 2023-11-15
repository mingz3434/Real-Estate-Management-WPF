using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Modern_Real_Estate.Model.EstateTypes
{
    [XmlInclude(typeof(Commercial))]
    public class Commercial 
    {
        protected Commercial(int id, string streetName, int zipCode, string city, string country, double area, double price, double rate, string imagePath)
        {
        }
    }
}
