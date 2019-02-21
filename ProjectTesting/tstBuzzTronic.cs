using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectClassLibrary;
using System.Collections.Generic;

namespace ProjectTesting
{
    [TestClass]
    public class tstBuzzTronic
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff AStaff = new clsStaff();
            Assert.IsNotNull(AStaff);
        }
        [TestMethod]
        public void FirstNameOK()
        {
            clsStaff AStaff = new clsStaff();
            string SomeFirstName = "Fred";
            AStaff.FirstName = SomeFirstName;
            Assert.AreEqual(AStaff.FirstName, SomeFirstName);
        }

        [TestMethod]
        public void LastNameOK()
        {
            clsStaff AStaff = new clsStaff();
            string SomeLastName = "Fred";
            AStaff.LastName = SomeLastName;
            Assert.AreEqual(AStaff.LastName, SomeLastName);
        }

        [TestMethod]
        public void StaffAddressOK()
        {
            clsStaff AStaff = new clsStaff();
            string SomeStaffAddress = "Jimblor";
            AStaff.StaffAddress = SomeStaffAddress;
            Assert.AreEqual(AStaff.StaffAddress, SomeStaffAddress);
        }

        [TestMethod]
        public void StaffNoOK()
        {
            clsStaff AStaff = new clsStaff();
            int SomeStaffNo = 123;
            AStaff.StaffNo = SomeStaffNo;
            Assert.AreEqual(AStaff.StaffNo, SomeStaffNo);
        }

        [TestMethod]
        public void StaffPhoneNoOK()
        {
            clsStaff AStaff = new clsStaff();
            int SomeStaffPhoneNo = 1234567891;
            AStaff.StaffPhoneNo = SomeStaffPhoneNo;
            Assert.AreEqual(AStaff.StaffPhoneNo, SomeStaffPhoneNo);
        }

        [TestMethod]
        public void StaffPostCode()
        {
            clsStaff AStaff = new clsStaff();
            var SomeStaffPostCode = "LE7 2UR";
            AStaff.StaffPostCode = SomeStaffPostCode;
            Assert.AreEqual(AStaff.StaffPostCode, SomeStaffPostCode);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            string StaffFirstName = "john";
            Found = AStaff.Find(StaffFirstName);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string SomeStaffFirstName = "john";
            Error = AStaff.Valid(SomeStaffFirstName);
            Assert.AreEqual(Error, "");
        }
        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////
        /// </summary>
        [TestMethod]
        public void Instance2OK()
        {
            clsProduct AProduct = new clsProduct();
            Assert.IsNotNull(AProduct);
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
            string ProductName = "Samsung";
            Found = AProduct.Find(ProductName);
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
        ////////////////////////////////////////////////////////////////////////////////////
        [TestMethod]
        public void Instance3Ok()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //Test to see that it exist 
            Assert.IsNotNull(AnManufacturer);
        }
        [TestMethod]
        public void CheckPropertyOk()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //Create some test data to assign to the property
            Boolean TestData = true;
            //Assign the data to the property 
            AnManufacturer.Check = TestData;
            //Test to see that the two values are the same 
            Assert.AreEqual(AnManufacturer.Check, TestData);
        }
        [TestMethod]
        public void DateAddedPropertyOk()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //Create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //Assign the data to the property 
            AnManufacturer.DateAdded = TestData;
            //Test to see that the two values are the same 
            Assert.AreEqual(AnManufacturer.DateAdded, TestData);
        }
        [TestMethod]
        public void ManufacturerNoPropertyOk()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //Create some test data to assign to the property
            Int32 TestData = 2;
            //Assign the data to the property 
            AnManufacturer.ManufacturerNo = TestData;
            //Test to see that the two values are the same 
            Assert.AreEqual(AnManufacturer.ManufacturerNo, TestData);
        }
        [TestMethod]
        public void ManufacturerNamePropertyOk()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //Create some test data to assign to the property
            String TestData = "Microsoft";
            //Assign the data to the property 
            AnManufacturer.ManufacturerName = TestData;
            //Test to see that the two values are the same 
            Assert.AreEqual(AnManufacturer.ManufacturerName, TestData);
        }
        [TestMethod]
        public void ProductListPropertyOk()
        {
            // Create instance of the class
            clsManufacturer AllManufacturers = new clsManufacturer();
            //Create some test data to assign to the property
            Int32 SomeCount = 1;
            //Assign the data to the property 
            AllManufacturers.Count = SomeCount;
            //Test to see that the two values are the same 
            Assert.AreEqual(AllManufacturers.Count, SomeCount);
        }
        [TestMethod]
        public void FindMethod3Ok()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //Boolean variable to store the result of the validation 
            Boolean Found = false;
            //Create some test data to use with the method 
            Int32 ManufacturerNo = 1;
            //Invoke the method 
            Found = AnManufacturer.Find(ManufacturerNo);
            //Test to see that the result is correct 
            Assert.IsTrue(Found);
        }



        [TestMethod]
        public void ValidMethod3Ok()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //Create some test data to test the method 
            string SomeManufacturer = "Apple";
            //Invoke the method 
            Error = AnManufacturer.Valid(SomeManufacturer);
            //Test to see that the result is Ok  
            Assert.AreEqual(Error, "");
        }


    }

}