namespace Assignment._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            #region Question01
            /*a) The original value will not change because the struct is value type.
              b) The other value also will not change although the class is reference type 
                 because the string is immutable (when changing it ,it cerate another object).*/
            #endregion
            #region Question02
            /*a) -Anyone can assign these fields invalid or unexpected values directly.
                 -Cannot apply validation on the input.
                 -Any Changes on the original field must also be applied on the objects in Main
                  which makes it hard to maintenance.
              b) Private fields prevent anyone to access the fields and change it's value
                 and public property allow the validation on the input and set and get the values.*/
            #endregion
            #endregion
            #region Part02
            #region Delivery Address
            //DeliveryAddress address1= new DeliveryAddress("Nasr City","Al-Swaf",15);
            //DeliveryAddress address2 = new DeliveryAddress();
            //address2= address1;
            //address2.buildingNumber = 7;
            //Console.WriteLine(address1.GetFullAddress());
            //Console.WriteLine(address2.GetFullAddress());
            #endregion
            DeliveryCenter deliveryCenter = new DeliveryCenter();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter Shipment{i + 1} Data:");
                Console.Write("Tracking Code:");
                string code = Console.ReadLine();
                Console.Write("Description:");
                string description = Console.ReadLine();
                Console.Write("Weight:");
                double weigh = double.Parse(Console.ReadLine());
                Console.Write("Delivery Fee:");
                decimal fee = decimal.Parse(Console.ReadLine());
                Console.Write("City:");
                string city = Console.ReadLine();
                Console.Write("Street:");
                string street = Console.ReadLine();
                Console.Write($"Building Number:");
                int num = int.Parse(Console.ReadLine());
                Shipment shipment = new Shipment(code, description, weigh, fee, new DeliveryAddress(city, street, num));
                if (deliveryCenter.AddShipment(shipment))
                { 
                    Console.WriteLine("Shipment added successfully."); 
                }
            }
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("------All Shimpents-------");
                deliveryCenter[j].PrintShipment();
            }
            Console.WriteLine("Enter a tracking code:");
            string searchCode = Console.ReadLine();
            Shipment foundCode = deliveryCenter[searchCode];
            if (!string.IsNullOrWhiteSpace(foundCode.TrackingCode))
            {
                Console.WriteLine($"Found Code:{foundCode.TrackingCode} - {foundCode.Description}");
            }
            else 
            { 
                Console.WriteLine("Not Found!"); 
            }
            #endregion
        }
    }
}
