using FunBooksAndVideos.Enums;
using FunBooksAndVideos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunBooksAndVideos.Models
{
    public class Rule : IRule
    {
        private readonly ICustomer _iCustomer;

        #region Constructor
        public Rule(InterfaceManager interfaceManager)
        {
            if (interfaceManager == InterfaceManager.ICustomer)
            {
                _iCustomer = new Customer();
            }
        }

        public Rule(ICustomer customer)
        {
            _iCustomer = customer;
        }
        #endregion

        #region IRule methods
        /// <summary>
        /// This method checks for a Purchase Order if a Membership can be found and activates it if so.
        /// </summary>
        public void ActivateMembership(PurchaseOrder purchaseOrder)
        {
            if (purchaseOrder.ItemList != null)
            {
                // Check for items in the order.
                foreach (Item item in purchaseOrder.ItemList)
                {
                    // Find the memberships and activate them.
                    if (item.ItemType == ItemType.Membership)
                    {
                        _iCustomer.ActivateMembership(item.ItemId);
                    }
                }
            }
        }

        /// <summary>
        /// This method checks for a Purchase Order if a Product can be found and generates a shipping slip if so.
        /// </summary>
        public void GenerateShippingSlip(PurchaseOrder purchaseOrder)
        {
            if (purchaseOrder.ItemList != null)
            {
                // Check for items in the order.
                foreach (Item item in purchaseOrder.ItemList)
                {
                    // Find the physical products and generate a shipping slip.
                    if (item.ItemType == ItemType.Product)
                    {
                        _iCustomer.GenerateShippingSlip(item.ItemId);
                    }
                }
            }
        }
        #endregion
    }
}
