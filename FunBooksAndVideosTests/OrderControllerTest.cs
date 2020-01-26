using FunBooksAndVideos.Controllers;
using FunBooksAndVideos.Enums;
using FunBooksAndVideos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FunBooksAndVideosTests
{
    [TestClass]
    public class OrderControllerTest
    {
        private OrderController _orderController;

        [TestInitialize]
        public void Setup()
        {
            _orderController = new OrderController();
        }

        [TestMethod]
        public void CheckResponse()
        {
            // This method checks if the 200 status is returned;

            // Create sample.
            PurchaseOrder purchaseOrder = CreateTestPurchaseOrder();

            // Call method.
            var result = _orderController.ProcessOrder(purchaseOrder);

            // Test.
            Assert.IsTrue((result as StatusCodeResult).StatusCode == StatusCodes.Status200OK);
        }

        /// <summary>
        /// Initial test for creating a purchase order.
        /// </summary>
        private PurchaseOrder CreateTestPurchaseOrder()
        {
            PurchaseOrder purchaseOrder = new PurchaseOrder()
            {
                TotalPrice = 100,
                CustomerId = "123213",
                PurchaseOrderId = "124242",
                ItemList = new List<Item>()
                {
                    new Item()
                    {
                        ItemId = "32",
                        Title = "The Girl on the train",
                        TotalPrice = 46,
                        ItemType = ItemType.Product
                    },

                    new Item()
                    {
                        ItemId = "23",
                        Title = "Comprehensive First Aid Training",
                        TotalPrice = 12,
                        ItemType = ItemType.Product
                    },

                    new Item()
                    {
                        ItemId = "46",
                        Title = "Book Club Membership",
                        TotalPrice = 32,
                        ItemType = ItemType.Membership
                    }
                }
            };

            return purchaseOrder;
        }
    }
}
