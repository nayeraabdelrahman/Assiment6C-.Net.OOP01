using System;
using System.Collections.Generic;
using System.Text;

namespace Assiment6C_.Net.OOP01
{
    #region DeliveryCenter Struct

    struct DeliveryCenter
    {
        // ==========================================
        // FIELDS
        // ==========================================

        #region Fields

        // Private Shipment[] array.
        //
        // Maximum size = 10.


        #endregion



        // ==========================================
        // CONSTRUCTOR
        // ==========================================

        #region Constructor

        // Initialize the Shipment array
        // with a size of 10.


        #endregion



        // ==========================================
        // INTEGER INDEXER
        // ==========================================

        #region Integer Indexer

        // Create an indexer that receives int index.
        //
        // GET:
        // If index is valid:
        // return shipment at that position.
        //
        // If index is invalid:
        // return default.
        //
        // SET:
        // If index is valid:
        // replace the shipment.
        //
        // If index is invalid:
        // do nothing.


        #endregion



        // ==========================================
        // STRING INDEXER
        // ==========================================

        #region String Indexer

        // Create an indexer that receives:
        // string trackingCode
        //
        // Search the Shipment array.
        //
        // Return the FIRST shipment
        // with matching TrackingCode.
        //
        // If no shipment is found:
        // return default.


        #endregion



        // ==========================================
        // METHODS
        // ==========================================

        #region Methods

        // AddShipment(Shipment shipment)
        //
        // Add the shipment to the
        // first available position.
        //
        // Return true:
        // if added successfully.
        //
        // Return false:
        // if the DeliveryCenter is full.


        #endregion
    }

    #endregion
}
