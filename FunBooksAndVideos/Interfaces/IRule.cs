using FunBooksAndVideos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunBooksAndVideos.Interfaces
{
    public interface IRule
    {
        void ActivateMembership(PurchaseOrder purchaseOrder);

        void GenerateShippingSlip(PurchaseOrder purchaseOrder);
    }
}
