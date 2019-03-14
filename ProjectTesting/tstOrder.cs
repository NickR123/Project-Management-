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
            clsOrder AnOrder = new clsOrder();
            int SomeOrderNo = 5;
            AnOrder.OrderNo = SomeOrderNo;
            Assert.AreEqual(AnOrder.OrderNo, SomeOrderNo);
        }

        [TestMethod]
        public void CustomerNoOk()
        {
            clsOrder AnOrder = new clsOrder();
            int SomeCustomerNo = 11;
            AnOrder.CustomerNo = SomeCustomerNo;
            Assert.AreEqual(AnOrder.CustomerNo, SomeCustomerNo);
        }

        [TestMethod]
        public void OrderNameOk()
        {
            clsOrder AnOrder = new clsOrder();
            string SomeOrderName = "Laptop";
            AnOrder.OrderName = SomeOrderName;
            Assert.AreEqual(AnOrder.OrderName, SomeOrderName);
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
            clsOrder AnOrder = new clsOrder();
            decimal SomeOrderPrice = 10;
            AnOrder.OrderPrice = SomeOrderPrice;
            Assert.AreEqual(AnOrder.OrderPrice, SomeOrderPrice);
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

        [TestMethod]
        public void TestOrderNoFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 3;
            //invoke the method 
            Found = AnOrder.Find(OrderNo);
            //check the order no
            if (AnOrder.OrderNo != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNoFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 2;
            //invoke the method 
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.CustomerNo != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderNameFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 5;
            //invoke the method 
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.OrderName != "Smart watch")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 2;
            //invoke the method 
            Found = AnOrder.Find(OrderNo);
            //check the order no
            if (AnOrder.OrderDate != Convert.ToDateTime("12/03/2019"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderPriceFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 2;
            //invoke the method 
            Found = AnOrder.Find(OrderNo);
            //check the order no
            if (AnOrder.OrderPrice != 250)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }
}
