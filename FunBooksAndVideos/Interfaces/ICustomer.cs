using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunBooksAndVideos.Interfaces
{
    public interface ICustomer
    {
        void ActivateMembership(string itemId);

        void GenerateShippingSlip(string itemId);
    }
}
