using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment._6
{
    internal struct Shipment
    {
        private string trackingCode;
        private string description;
        private double weight;
        private decimal deliveryFee;
        public DeliveryAddress destination { set; get; }
        public string TrackingCode
        {
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    trackingCode = value;
            }
            get { return trackingCode; }
        }
        public string Description
        {
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    description = value;
            }
            get { return description; }
        }
        public double Weight
        {
            set
            {
                if (value > 0)
                    weight = value;
            }
            get { return weight; }
        }
        public decimal DeliveryFee
        {
            private set
            {
                if (value > 0)
                    deliveryFee = value;
            }
            get { return deliveryFee; }
        }
        public decimal EstimatedCost
        {
            get { return deliveryFee+((decimal)weight *5); }
        }
        public Shipment(string trackingCode)
        {
            this.trackingCode = trackingCode;
            description = "Unknown";
            weight = 1;
            deliveryFee = 50;
            destination = default;
        }
        public Shipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
        {
            TrackingCode=trackingCode;
            Weight = weight;
            Description = description;
            DeliveryFee= deliveryFee;
            this.destination=destination;
        }
        public void UpDateDiliveryFee(decimal newFee)
        {
            if (newFee > 0)
                deliveryFee= newFee;
        }
        public void PrintShipment()
        {
            Console.WriteLine($"Tracking Code:{trackingCode}\nDescription:{description}");
            Console.WriteLine($"Weight:{weight}\nDelivery Fee:{deliveryFee}");
            Console.WriteLine($"Destination:{destination}\nEstimatedCost:{EstimatedCost}");
        }
    }
}
