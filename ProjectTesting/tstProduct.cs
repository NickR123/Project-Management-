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
    }
}
