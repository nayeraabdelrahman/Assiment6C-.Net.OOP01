using System;
using System.Collections.Generic;
using System.Text;

namespace Assiment6C_.Net.OOP01
{
    #region Shipment Struct

    struct Shipment
    {
        // ==========================================
        // PRIVATE FIELDS
        // ==========================================

        #region Private Fields

        // TrackingCode field


        // Description field


        // Weight field


        // DeliveryFee field


        #endregion



        // ==========================================
        // PROPERTIES
        // ==========================================

        #region Properties

        // TrackingCode Property
        //
        // Read-only from outside the struct.
        //
        // TrackingCode cannot be:
        // null
        // empty
        // whitespace



        // Description Property
        //
        // Public get and set.
        //
        // Description cannot be:
        // null
        // empty
        // whitespace
        //
        // If invalid:
        // Keep the previous valid value.



        // Weight Property
        //
        // Public get and set.
        //
        // Weight must be greater than 0.
        //
        // If invalid:
        // Keep the previous valid value.



        // DeliveryFee Property
        //
        // Public getter.
        // Private setter.
        //
        // DeliveryFee must be greater than 0.



        // Destination Property
        //
        // Type: DeliveryAddress
        //
        // Public get and set.



        // EstimatedCost Property
        //
        // Read-only calculated property.
        //
        // Return:
        // DeliveryFee + (Weight * 5)
        //
        // Do NOT create a field for EstimatedCost.


        #endregion



        // ==========================================
        // CONSTRUCTORS
        // ==========================================

        #region Constructors

        // Constructor 1
        //
        // Receives:
        // trackingCode
        //
        // Default values:
        // Description = "Unknown"
        // Weight = 1
        // DeliveryFee = 50
        // Destination = default



        // Constructor 2
        //
        // Receives:
        // trackingCode
        // description
        // weight
        // deliveryFee
        // destination
        //
        // Make sure all values are initialized
        // with valid data.


        #endregion



        // ==========================================
        // METHODS
        // ==========================================

        #region Methods

        // UpdateDeliveryFee(decimal newFee)
        //
        // Update DeliveryFee only if
        // newFee > 0.



        // PrintShipment()
        //
        // Print:
        // TrackingCode
        // Description
        // Weight
        // DeliveryFee
        // Destination
        // EstimatedCost


        #endregion
    }

    #endregion
}
