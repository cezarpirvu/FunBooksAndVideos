using FunBooksAndVideos.Enums;
using FunBooksAndVideos.Interfaces;
using FunBooksAndVideos.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Moq;

namespace FunBooksAndVideosTests
{
    [TestClass]
    public class RuleTests
    {
        private Rule _rule;
        private Mock<ICustomer> _iCustomer;

        [TestInitialize]
        public void Setup()
        {
            _iCustomer = new Mock<ICustomer>();
            _rule = new Rule(_iCustomer.Object);
        }

        [TestMethod]
        public void CheckActivateMembership()
        {
            // This method checks if the ActivateMembership rule works.

            _iCustomer.Setup(x => x.ActivateMembership(It.IsAny<string>())).Verifiable();

            PurchaseOrder purchaseOrder = CreateTestPurchaseOrder();

            _rule.ActivateMembership(purchaseOrder);

            _iCustomer.Verify(x => x.ActivateMembership("46"), Times.Once);
        }

        [TestMethod]
        public void CheckGenerateShippingSlip()
        {
            // This method checks if the GenerateShippingSlip rule works.

            _iCustomer.Setup(x => x.GenerateShippingSlip(It.IsAny<string>())).Verifiable();

            PurchaseOrder purchaseOrder = CreateTestPurchaseOrder();

            _rule.GenerateShippingSlip(purchaseOrder);

            _iCustomer.Verify(x => x.GenerateShippingSlip("32"), Times.Once);
            _iCustomer.Verify(x => x.GenerateShippingSlip("23"), Times.Once);
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
