﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTests
{
    [TestClass()]
    public class OrderRepositoryTests
    {
        [TestMethod()]
        public void RetrieveOrderDisplayTest()
        {
            //-- Arrange
            var orderRepository = new OrderRepository();
            var expected = new OrderDisplay()
            {
                FirstName = "Bilbo",
                LastName = "Baggins",
                OrderDate = new DateTimeOffset(2014,4,14,10,00,00, new TimeSpan(7,0,0)),
                ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                },
                orderDisplayItemList = new List<OrderDisplayItem>() 
                {
                    new OrderDisplayItem()
                    {
                        OrderQuantity = 2,
                        ProductName = "Sunflowers",
                        PurchasePrice = 15.96M
                    },
                    new OrderDisplayItem()
                    {
                        OrderQuantity = 1,
                        ProductName = "Rake",
                        PurchasePrice = 6M
                    }
                }
            };
            //-- Act
            var actual = orderRepository.RetrieveOrderDisplay(10);

            //-- Assert
            Assert.AreEqual( expected.FirstName, actual.FirstName );
            Assert.AreEqual( expected.LastName, actual.LastName );
            Assert.AreEqual( expected.OrderDate, actual.OrderDate );

            Assert.AreEqual( expected.ShippingAddress.AddressType, actual.ShippingAddress.AddressType );
            Assert.AreEqual( expected.ShippingAddress.StreetLine1, actual.ShippingAddress.StreetLine1 );
            Assert.AreEqual( expected.ShippingAddress.City, actual.ShippingAddress.City );
            Assert.AreEqual( expected.ShippingAddress.State, actual.ShippingAddress.State );
            Assert.AreEqual( expected.ShippingAddress.Country, actual.ShippingAddress.Country );
            Assert.AreEqual( expected.ShippingAddress.PostalCode, actual.ShippingAddress.PostalCode );

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.orderDisplayItemList[i].OrderQuantity, actual.orderDisplayItemList[i].OrderQuantity);
                Assert.AreEqual(expected.orderDisplayItemList[i].ProductName, actual.orderDisplayItemList[i].ProductName);
                Assert.AreEqual(expected.orderDisplayItemList[i].PurchasePrice, actual.orderDisplayItemList[i].PurchasePrice);
            }
        }

        [TestMethod()]
        public void TestMethod1()
        {

        }

    }        
}
