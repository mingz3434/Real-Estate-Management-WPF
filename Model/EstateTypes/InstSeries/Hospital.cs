using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern_Real_Estate.Model.EstateTypes
{
    public class Hospital : Institutional
    {
        private string _subType;
        public string SubType
        {
            get { return "Hospital"; }
        }
        public Hospital() { }

    }
}
