using Assiment6C_.Net.OOP01;
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
            address2.SetCity( "Los Angeles");
            Console.WriteLine(address1.GetFullAddress());
            Console.WriteLine(address2.GetFullAddress());



            #endregion


            #region Shipment - Constructor 1 Test



            #endregion


            #region Shipment - Constructor 2 Test

            // Create a Shipment using:
            //
            // trackingCode
            // description
            // weight
            // deliveryFee
            // destination
            //
            // Print the shipment information.


            #endregion


            #region Shipment - Properties Test

            // Test Description property.
            //
            // Try assigning a valid value.
            //
            // Try assigning:
            // null
            // empty string
            // whitespace
            //
            // Invalid values should NOT replace
            // the previous valid value.


            // Test Weight property.
            //
            // Try assigning a valid value.
            //
            // Try assigning:
            // 0
            // negative number
            //
            // Invalid values should NOT replace
            // the previous valid value.


            #endregion


            #region Shipment - UpdateDeliveryFee Test

            // Call UpdateDeliveryFee().
            //
            // Test it with a valid fee.
            //
            // Test it with an invalid fee.
            //
            // The fee should only change
            // when the new fee is greater than 0.


            #endregion


            #region Shipment - EstimatedCost Test

            // Print EstimatedCost.
            //
            // Formula:
            //
            // DeliveryFee + (Weight * 5)
            //
            // EstimatedCost should be calculated
            // when requested.
            //
            // Do NOT store it in a separate field.


            #endregion


            #region DeliveryCenter - AddShipment Test

            // Create a DeliveryCenter.
            //
            // Add shipments using AddShipment().
            //
            // Print whether each shipment
            // was added successfully.


            #endregion


            #region DeliveryCenter - Integer Indexer Test

            // Access a shipment using its position.
            //
            // Example idea:
            // center[0]
            //
            // Test a valid index.
            //
            // Test an invalid index.
            //
            // Invalid getter should return default.
            //
            // Invalid setter should do nothing.


            #endregion


            #region DeliveryCenter - String Indexer Test

            // Search for a shipment using its tracking code.
            //
            // Example idea:
            // center["TR001"]
            //
            // It should return the first shipment
            // with the matching tracking code.
            //
            // If not found, return default.


            #endregion
        }
    }







}