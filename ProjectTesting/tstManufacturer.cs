using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectClassLibrary;
using System.Collections.Generic;
namespace ProjectTesting
{
    [TestClass]
    public class tstManufacturer
    {
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
