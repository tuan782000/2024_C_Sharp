using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _15_Constructor
{
    public class RealEstate
    {
        private string _address;
        public RealEstate(string address) {
            _address = address;
        }
        public string Address { 
            get => _address; 
            set => _address = value; 
        }
    }
}