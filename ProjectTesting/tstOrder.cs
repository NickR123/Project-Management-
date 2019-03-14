using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectClassLibrary;
using System.Collections.Generic;
namespace ProjectTesting
{
    [TestClass]
    public class tstOrder
    {
        //good test data
        //create some test data to pass to the method
        string OrderName = "Laptop";
        string OrderDate = DateTime.Now.Date.ToString();
        string OrderPrice = "20";

        [TestMethod]
        public void Instance4OK()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AOrder);
        }

        [TestMethod]
        public void OrderNoOk()
        {
            clsOrder AOrder = new clsOrder();
            int SomeOrderNo = 301;
            AOrder.OrderNo = SomeOrderNo;
            Assert.AreEqual(AOrder.OrderNo, SomeOrderNo);
        }

        [TestMethod]
        public void CustomerNoOk()
        {
            clsOrder AOrder = new clsOrder();
            int SomeCustomerNo = 11;
            AOrder.CustomerNo = SomeCustomerNo;
            Assert.AreEqual(AOrder.CustomerNo, SomeCustomerNo);
        }

        [TestMethod]
        public void OrderNameOk()
        {
            clsOrder AOrder = new clsOrder();
            string SomeOrderName = "Laptop";
            AOrder.OrderName = SomeOrderName;
            Assert.AreEqual(AOrder.OrderName, SomeOrderName);
        }

        [TestMethod]
        public void OrderDateOk()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //Assign the data to the property
            AnOrder.OrderDate = TestData;
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void OrderPriceOk()
        {
            clsOrder AOrder = new clsOrder();
            decimal SomeOrderPrice = 20;
            AOrder.OrderPrice = SomeOrderPrice;
            Assert.AreEqual(AOrder.OrderPrice, SomeOrderPrice);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //create some data to use with the method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid( OrderName, OrderDate, OrderPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
