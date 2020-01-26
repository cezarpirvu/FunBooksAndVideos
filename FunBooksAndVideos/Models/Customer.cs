using FunBooksAndVideos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunBooksAndVideos.Models
{
    public class Customer : ICustomer
    {
        #region Constructor
        public Customer()
        { 
        
        }
        #endregion

        #region ICustomer methods
        public void ActivateMembership(string itemId)
        {
            //throw new NotImplementedException();
        }

        public void GenerateShippingSlip(string itemId)
        {
            //throw new NotImplementedException();
        }
        #endregion
    }
}
