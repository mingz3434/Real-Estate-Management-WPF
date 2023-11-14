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
        private string _subType;
        public string SubType
        {
            get { return "Apartment"; }
        }


    }
}

