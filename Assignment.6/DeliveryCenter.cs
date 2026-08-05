using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment._6
{
    internal struct DeliveryCenter
    {
        private Shipment[]shipments;
        public Shipment this[int index]
        {
            get 
            { 
                if (index > 10||index<0)
                    return default;
                else
                    return shipments[index]; 
            }
            set
            {
                if (index >= 0 && index <= 10)
                    shipments[index] = value;
            }
        }
        public Shipment this[string code]
        {
            get 
            {
                foreach (Shipment shipment in shipments)
                {
                    if (shipment.TrackingCode == code)
                        return shipment;
                }
                return default;
            }
        }
        public bool AddShipment(Shipment shipment)
        {
            int counter=0;
            foreach (Shipment item in shipments)
            {
                if (string.IsNullOrWhiteSpace(item.TrackingCode))
                {
                    shipments[counter] = shipment;
                    return true;
                }
                counter++;
            }
            return false;
        }
    }
}
