using FunBooksAndVideos.Enums;
using FunBooksAndVideos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunBooksAndVideos.Models
{
    public class PurchaseOrder
    {
        #region Contructor
        public PurchaseOrder()
        {

        }
        #endregion

        #region Get/Set properties
        public String PurchaseOrderId { get; set; }

        public String CustomerId { get; set; }

        public Decimal TotalPrice { get; set; }

        public List<Item> ItemList { get; set; }
        #endregion

        #region Public methods
        /// <summary>
        /// This method will apply the Business Rules on a Purchase Order.
        /// </summary>
        public void ProcessOrder()
        {
            #region Client specific rules
            Rule businessRule = new Rule(InterfaceManager.ICustomer);
            // Business Rule 1
            businessRule.ActivateMembership(this);

            // Business Rule 2
            businessRule.GenerateShippingSlip(this);
            #endregion
        }
        #endregion
    }
}
