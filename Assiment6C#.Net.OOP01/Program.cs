using Assiment6C_.Net.OOP01;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment6C_.Net.OOP01
{
    class Program
    {
        static void Main(string[] args)
        {
            // ==========================================
            // PART 01 - THEORETICAL QUESTIONS
            // ==========================================


            #region Theoretical - Question 1

            // Consider DeliveryAddress as a struct
            // and Customer as a class.
            //
            // a) What happens when a DeliveryAddress variable
            //    is copied into another variable and the copy is modified?
            //
            // Answer:
            // The copy of the DeliveryAddress variable will change,
            // but the original variable will not change because structs are value types
            // and are copied by value.


            // b) What happens when a Customer variable
            //    is copied into another variable and one variable
            //    modifies the object?
            //
            // Answer:
            //If the copied Customer variable modifies the object,
            //the original variable will see the change as well because classes are reference types.

            #endregion


            #region Theoretical - Question 2

            // Consider the given struct.
            //
            // a) Identify at least three problems with this design
            //    from an encapsulation perspective.
            //
            //1.The fields are public.
            //2. Any code outside the struct can modify the fields directly.
            //3. There is no validation to prevent invalid values.
            //
            // b) How can private fields and public properties
            //    improve this design?
            //
            // Answer:
            // By making the fields private and using getters and setters,
            // we can control how the fields are accessed and modified
            // and prevent invalid values.
            #endregion



            // ==========================================
            // PART 02 - PRACTICAL Smart Delivery Management System 
            // ==========================================


            #region DeliveryAddress - Test

            //Create one DeliveryAddress value,
            //copy it into a second variable,
            //modify the copy, and print both values to prove that the original did not change. 

            DeliveryAddress address1 = new DeliveryAddress(123, "5th Avenue", "New York");
            DeliveryAddress address2 = address1;
            Console.WriteLine(address1.GetFullAddress());
            Console.WriteLine(address2.GetFullAddress());
            Console.WriteLine("Modifying the copy...");
            address2.SetCity( "Los Angeles");
            Console.WriteLine(address1.GetFullAddress());
            Console.WriteLine(address2.GetFullAddress());



            #endregion


            #region   build a Console Application

            // Create a DeliveryCenter
            Shipment[] Shipments = new Shipment[10];
            DeliveryCenter Rout = new DeliveryCenter();
            
            Console.WriteLine($"Welcome to {nameof(Rout)} Delivery Center");
            //  Read data for three shipments from the user.
            // Create each Shipment and add it to the DeliveryCenter.
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Enter shipment {i} data:");
                
                Console.WriteLine($"Tracking Code: ");
                string trackingCode;
                trackingCode = ReadValidString("Tracking Code");
                Shipment shipment = new Shipment(trackingCode);
                Console.WriteLine($"Description: ");
                string description;
                description = Console.ReadLine()??"";
                shipment.Description = description;
                Console.WriteLine($"Weight: ");
                double weight;
                bool isValidWeight = false;
                do { isValidWeight = double.TryParse(Console.ReadLine(), out weight); }
                while (!isValidWeight || weight <= 0);
                shipment.Weight = weight;
                Console.WriteLine($"Delivery Fee: ");
                decimal deliveryFee;
                bool isValidDeliveryFee = false;
                do { isValidDeliveryFee = decimal.TryParse(Console.ReadLine(), out deliveryFee); }
                while (!isValidDeliveryFee || deliveryFee <= 0);
                shipment.UpdateDeliveryFee(deliveryFee);
                Console.WriteLine($"City: ");
                string city= ReadValidString("City");
                Console.WriteLine($"Street: ");
                string street = ReadValidString("Street");
                do
                {
                    street = Console.ReadLine() ?? "";
                    if (string.IsNullOrWhiteSpace(street))
                    {
                        Console.WriteLine("Street cannot be empty or whitespace. Please enter a valid Street.");
                    }
                } while (string.IsNullOrWhiteSpace(street));
                Console.WriteLine($"Building Number: ");
                int buildingNumber;
                bool isValidBuildingNumber = false;
                do
                {
                    isValidBuildingNumber = int.TryParse(Console.ReadLine(), out buildingNumber);
                } while (!isValidBuildingNumber||buildingNumber<=0);
                DeliveryAddress deliveryAddress = new DeliveryAddress(buildingNumber, street, city);
                if(Rout.AddShipment(shipment))
                {
                    Console.WriteLine("Shipment added successfully.");
                }
                else
                {
                    Console.WriteLine("Shipment could not be added.");
                }
            }
            //Print the three shipments using the integer indexer.
            Console.WriteLine("--- All Shipments");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Shipment {i + 1}:");
                Rout[i].PrintShipment();
            }
            //Ask the user to enter a tracking code.
            Console.WriteLine("Enter a tracking code to search :");
            string searchTrackingCode = Console.ReadLine()??"";
            //Print the shipment if found; otherwise print:Shipment not found.
            if (Rout[searchTrackingCode].Equals(default(Shipment)) ){ 
                Console.WriteLine("Shipment not found.");
            }
            else
            {
                Console.WriteLine($"Shipment found: {Rout[searchTrackingCode].TrackingCode} - {Rout[searchTrackingCode].Description}");
            }
            //Demonstrate the DeliveryAddress struct copy behavior
            Console.WriteLine("--- Struct Copy Test ---");
            DeliveryAddress originalAddress = Rout[0].Destination;
            DeliveryAddress copiedAddress = originalAddress;
            copiedAddress.SetCity("Assiut");
            Console.WriteLine("Original Address: " + Rout[0].Destination.GetFullAddress());
            Console.WriteLine("Copied Address: " + copiedAddress.GetFullAddress());

            #endregion


            #region validation
            static string ReadValidString(string message)
            {
                string input;
                do
                {
                   input=Console.ReadLine()??"";
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine($"{message} cannot be empty or whitespace. Please enter a valid {message}.");
                    }
                } while (string.IsNullOrWhiteSpace(input));
                return input;
            }



            #endregion
        }
    }







}