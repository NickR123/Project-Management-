using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectClassLibrary;
using System.Collections.Generic;

namespace ProjectTesting
{
    [TestClass]
    public class tstProduct
    {
        [TestMethod]
        public void Instance2OK()
        {
            clsProduct AProduct = new clsProduct();
            Assert.IsNotNull(AProduct);
        }

        [TestMethod]
        public void ProductNoOK()
        {
            clsProduct AProduct = new clsProduct();
            int SomeProductNo = 123;
            AProduct.ProductNo = SomeProductNo;
            Assert.AreEqual(AProduct.ProductNo, SomeProductNo);
        }
        [TestMethod]
        public void ProductNameOK()
        {
            clsProduct AProduct = new clsProduct();
            string SomeProductName = "Samsung";
            AProduct.ProductName = SomeProductName;
            Assert.AreEqual(AProduct.ProductName, SomeProductName);
        }

        [TestMethod]
        public void DescriptionOK()
        {
            clsProduct AProduct = new clsProduct();
            string SomeDescription = "Red";
            AProduct.Description = SomeDescription;
            Assert.AreEqual(AProduct.Description, SomeDescription);
        }

        [TestMethod]
        public void PriceOK()
        {
            clsProduct AProduct = new clsProduct();
            decimal SomePrice = 1;
            AProduct.Price = SomePrice;
            Assert.AreEqual(AProduct.Price, SomePrice);
        }

        [TestMethod]
        public void ActiveProductOK()
        {
            clsProduct AProduct = new clsProduct();
            Boolean SomeActive = true;
            AProduct.Active = SomeActive;
            Assert.AreEqual(AProduct.Active, SomeActive);
        }



        [TestMethod]
        public void FindMethodOk2()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Int32 ProductNo = 1;
            Found = AProduct.Find(ProductNo);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void ValidMethodOk2()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string SomeProductName = "Samsung";
            Error = AProduct.Valid(SomeProductName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestProductNoFound()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 1;
            //invoke the method
            Found = AnProduct.Find(ProductNo);
            //check the staff No
            if (AnProduct.ProductNo!= 1)
            {
                OK = false;
            }
            //test the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductNameFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 1;
            //invoke the method
            Found = AProduct.Find(ProductNo);
            //check the staff No
            if (AProduct.ProductName != "Samsung")
            {
                OK = false;
            }
            //test the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDescriptionFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 1;
            //invoke the method
            Found = AProduct.Find(ProductNo);
            //check the staff No
            if (AProduct.Description != "Black")
            {
                OK = false;
            }
            //test the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 1;
            //invoke the method
            Found = AProduct.Find(ProductNo);
            //check the staff No
            if (AProduct.Price != 1)
            {
                OK = false;
            }
            //test the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 1;
            //invoke the method
            Found = AProduct.Find(ProductNo);
            //check the staff No
            if (AProduct.Active != true)
            {
                OK = false;
            }
            //test the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ProductNameMinLessOne()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string ProductName = "";
            //invoke the method
            Error = AProduct.Valid(ProductName, Description, Price);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMin()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string ProductName = "a";
            //invoke the method
            Error = AProduct.Valid(ProductName, Description, Price);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMinplusOne()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string ProductName = "aa";
            //invoke the method
            Error = AProduct.Valid(ProductName, Description, Price);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMaxLessOne()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string ProductName = "";
            ProductName = ProductName.PadRight(39, 'a');
            //invoke the method
            Error = AProduct.Valid(ProductName, Description, Price);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMax()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string ProductName = "";
            ProductName = ProductName.PadRight(40, 'a');
            //invoke the method
            Error = AProduct.Valid(ProductName, Description, Price);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMid()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string ProductName = "";
            ProductName = ProductName.PadRight(20, 'a');
            //invoke the method
            Error = AProduct.Valid(ProductName, Description, Price);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMaxplusOne()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string ProductName = "";
            ProductName = ProductName.PadRight(41, 'a');
            //invoke the method
            Error = AProduct.Valid(ProductName, Description, Price);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMaxExtreme()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string ProductName = "";
            ProductName = ProductName.PadRight(500, 'a');
            //invoke the method
            Error = AProduct.Valid(ProductName, Description, Price);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMinLessOne()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string Description = "";
            //invoke the method
            Error = AProduct.Valid(ProductName, Description, Price);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMin()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string Description = "a";
            //invoke the method
            Error = AProduct.Valid(ProductName, Description, Price);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionMinplusOne()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string Description = "aa";
            //invoke the method
            Error = AProduct.Valid(ProductName, Description, Price);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxLessOne()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string Description = "";
            Description = Description.PadRight(49, 'a');
            //invoke the method
            Error = AProduct.Valid(ProductName, Description, Price);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMax()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string Description = "";
            Description = Description.PadRight(50, 'a');
            //invoke the method
            Error = AProduct.Valid(ProductName, Description, Price);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMid()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string Description = "";
            Description = Description.PadRight(25, 'a');
            //invoke the method
            Error = AProduct.Valid(ProductName, Description, Price);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionMaxplusOne()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string Description = "";
            Description = Description.PadRight(51, 'a');
            //invoke the method
            Error = AProduct.Valid(ProductName, Description, Price);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionMaxExtreme()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string Description = "";
            Description = Description.PadRight(500, 'a');
            //invoke the method
            Error = AProduct.Valid(ProductName, Description, Price);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMin()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string Price = "123";
            //invoke the method
            Error = AProduct.Valid(ProductName, Description, Price);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinPlusOne()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string Price = "1234";
            //invoke the method
            Error = AProduct.Valid(ProductName, Description, Price);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinLessOne()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string Price = "12";
            //invoke the method
            Error = AProduct.Valid(ProductName, Description, Price);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMid()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string Price = "12345";
            //invoke the method
            Error = AProduct.Valid(ProductName, Description, Price);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMax()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string Price = "12345678";
            //invoke the method
            Error = AProduct.Valid(ProductName, Description, Price);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string Price = "123456789";
            //invoke the method
            Error = AProduct.Valid(ProductName, Description, Price);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxLessOne()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string Price = "1234567";
            //invoke the method
            Error = AProduct.Valid(ProductName, Description, Price);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            // create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string Price = "123456781234567";
            Price = Price.PadRight(500, '1');
            //invoke the method
            Error = AProduct.Valid(ProductName, Description, Price);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
