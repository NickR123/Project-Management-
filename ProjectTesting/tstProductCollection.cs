using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectClassLibrary;

namespace ProjectTesting
{
    [TestClass]
    public class tstProductCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //test that it exists
            Assert.IsNotNull(AllProducts);
        }
        [TestMethod]
        public void ProductListOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            List<clsProduct> TestList = new List<clsProduct>();

            clsProduct TestItem = new clsProduct();
            //set its properties
            TestItem.ProductNo = 1;
            TestItem.ProductName = "Samsung";
            TestItem.Description = "Black";
            TestItem.Price = 1299;
            TestItem.Active = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllProducts.ProductList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.ProductList, TestList);
        }
        [TestMethod]
        public void ThisProductPropertyOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create some test data to assign to the property
            clsProduct TestProduct = new clsProduct();
            //set the properties of the test object
            TestProduct.ProductNo = 1;
            TestProduct.ProductName = "Samsung";
            TestProduct.Description = "Black";
            TestProduct.Price = 1299;
            TestProduct.Active = true;
            //assign the data to the property
            AllProducts.ThisProduct = TestProduct;
            Assert.AreEqual(AllProducts.ThisProduct, TestProduct);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            List<clsProduct> TestList = new List<clsProduct>();

            clsProduct TestItem = new clsProduct();
            //set its properties
            TestItem.ProductNo = 1;
            TestItem.ProductName = "Samsung";
            TestItem.Description = "Black";
            TestItem.Price = 1299;
            TestItem.Active = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllProducts.ProductList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create the item of test data
            clsProduct TestItem = new clsProduct();
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ProductNo = 1;
            TestItem.ProductName = "Samsung";
            TestItem.Description = "Black";
            TestItem.Price = 1299;
            TestItem.Active = true;
            //set ThisProduct to test the data
            AllProducts.ThisProduct = TestItem;
            //add the record
            PrimaryKey = AllProducts.Add();
            TestItem.ProductNo = PrimaryKey;
            //find the record 
            AllProducts.ThisProduct.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.ThisProduct, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create the item of test data
            clsProduct TestItem = new clsProduct();
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ProductNo = 1;
            TestItem.ProductName = "Samsung";
            TestItem.Description = "Black";
            TestItem.Price = 1299;
            TestItem.Active = true;
            //set ThisProduct to test the data
            AllProducts.ThisProduct = TestItem;
            //add the record
            PrimaryKey = AllProducts.Add();
            TestItem.ProductNo = PrimaryKey;
            //find the record 
            AllProducts.ThisProduct.Find(PrimaryKey);
            //delete the record
            AllProducts.Delete();
            //now find the record
            Boolean Found = AllProducts.ThisProduct.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);


        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProduct = new clsProductCollection();
            //create the item of test data
            clsProduct TestItem = new clsProduct();
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ProductName = "Samsung";
            TestItem.Description = "Black";
            TestItem.Price = 1234;
            TestItem.Active= true;
            //set ThisProduct to test the data
            AllProduct.ThisProduct = TestItem;
            //add the record
            PrimaryKey = AllProduct.Add();
            //set primary key of 
            TestItem.ProductNo = PrimaryKey;
            //modify the test data
            TestItem.ProductName = "IPhone";
            TestItem.Description = "Gold";
            TestItem.Price = 124;
            TestItem.Active = false;
            //set the record based on the new test data
            AllProduct.ThisProduct = TestItem;
            //update the record
            AllProduct.Update();
            //find the record
            AllProduct.ThisProduct.Find(PrimaryKey);
            //test to see ThisStaff matches the test data
            Assert.AreEqual(AllProduct.ThisProduct, TestItem);

        }

        [TestMethod]
        public void ReportByProductNameOK()
        {
            //create an instance of the class containing unfiltered results
            clsProductCollection AllStaff = new clsProductCollection();
            //create an instance of the filtered data
            clsProductCollection FilteredProduct = new clsProductCollection();
            //apply a blank string(Should return all records);
            FilteredProduct.ReportByProductName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllProduct.Count, FilteredProduct.Count);
        }

        [TestMethod]
        public void ReportByFirstNameNoneFound()
        {
            //create an instance of the filtered data
            clsProductCollection FilteredProduct = new clsProductCollection();
            //apply a Product name that doesn't exist
            FilteredProduct.ReportByProductName("qqqqq");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredProduct.Count);

        }
    }
}
