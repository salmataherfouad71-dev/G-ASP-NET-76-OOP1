using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment._6
{
    internal struct DeliveryAddress
    {
        public string city;
        public string street;
        public int buildingNumber;
        public DeliveryAddress(string city,string street ,int buildingNumber)
        {
            this.city = city;
            this.street= street;
            this.buildingNumber = buildingNumber;
        }
        public string GetFullAddress()
        {
            return $"City:{city}\nStreet:{street}\nBuilding Number:{buildingNumber}";
        }
        public override string ToString()
        {
            return $"City:{city}\nStreet:{street}\nBuilding Number:{buildingNumber}";
        }
    }
}
