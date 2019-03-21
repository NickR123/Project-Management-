using System;
using ManufacturerClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ManufacturerTestFramework
{
    [TestClass]
    public class tstManufacturer
    {
        //Good test data
        //Create some test data to pass to the method
        string ManufacturerNo = "1";
        string ManufacturerName = "Apple";
        string Address = " 40 Paynell Road";
        string Town = "Peterboough";
        string PostCode = "PE1 5ST";
        string TelephoneNo = "01733389454";
        string Email = "apple@hotmail.com";
        string DateAdded = DateTime.Now.Date.ToString();


        [TestMethod]
        public void Instance33Ok()
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
        public void AddressPropertyOk()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //Create some test data to assign to the property
            string TestData = " 40 Paynell Road";
            //Assign the data to the property 
            AnManufacturer.Address = TestData;
            //Test to see that the two values are the same 
            Assert.AreEqual(AnManufacturer.Address, TestData);
        }

        [TestMethod]
        public void TownPropertyOK()
        {
            //create an instance of the class 
            clsManufacturer AnManufacturer = new clsManufacturer();
            //create some test data to assign to the property
            string TestData = "Peterborough";
            //assign the data to the property
            AnManufacturer.Town = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnManufacturer.Town, TestData);
        }

        [TestMethod]
        public void PostCodePropertyOk()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //Create some test data to assign to the property
            string TestData = "PE1 5ST";
            //Assign the data to the property 
            AnManufacturer.PostCode = TestData;
            //Test to see that the two values are the same 
            Assert.AreEqual(AnManufacturer.PostCode, TestData);
        }

        [TestMethod]
        public void TelephoneNoPropertyOk()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //Create some test data to assign to the property
            string TestData = "01733389454";
            //Assign the data to the property 
            AnManufacturer.TelephoneNo = TestData;
            //Test to see that the two values are the same 
            Assert.AreEqual(AnManufacturer.TelephoneNo, TestData);
        }

        [TestMethod]
        public void EmailPropertyOk()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //Create some test data to assign to the property
            string TestData = "apple@hotmail.com";
            //Assign the data to the property 
            AnManufacturer.Email = TestData;
            //Test to see that the two values are the same 
            Assert.AreEqual(AnManufacturer.Email, TestData);
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
            String TestData = "Apple";
            //Assign the data to the property 
            AnManufacturer.ManufacturerName = TestData;
            //Test to see that the two values are the same 
            Assert.AreEqual(AnManufacturer.ManufacturerName, TestData);
        }
        [TestMethod]
        public void FindMethodOk()
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
        public void TestManufacturerNoFound()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is Ok(assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 ManufacturerNo = 1;
            //Invoke the method
            Found = AnManufacturer.Find(ManufacturerNo);
            //Check the ManufacturerNo
            if (AnManufacturer.ManufacturerNo != 1)
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestManufacturerNameFound()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is Ok(assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 ManufacturerNo = 1;
            //Invoke the method
            Found = AnManufacturer.Find(ManufacturerNo);
            //Check the ManufacturerNo
            if (AnManufacturer.ManufacturerName != "Apple")
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAddressFound()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is Ok(assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 ManufacturerNo = 1;
            //Invoke the method
            Found = AnManufacturer.Find(ManufacturerNo);
            //Check the ManufacturerNo
            if (AnManufacturer.Address != "40 Paynell Road")
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestPostCodeFound()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is Ok(assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 ManufacturerNo = 1;
            //Invoke the method
            Found = AnManufacturer.Find(ManufacturerNo);
            //Check the ManufacturerNo
            if (AnManufacturer.PostCode != "PE1 5ST")
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is Ok(assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 ManufacturerNo = 1;
            //Invoke the method
            Found = AnManufacturer.Find(ManufacturerNo);
            //Check the ManufacturerNo
            if (AnManufacturer.DateAdded !=Convert.ToDateTime("14/03/2019 00:00:00"))
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTownFound()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is Ok(assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 ManufacturerNo = 1;
            //Invoke the method
            Found = AnManufacturer.Find(ManufacturerNo);
            //Check the property 
            if (AnManufacturer.Town != "Peterborough")
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTelephoneNoFound()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is Ok(assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 ManufacturerNo = 1;
            //Invoke the method
            Found = AnManufacturer.Find(ManufacturerNo);
            //Check the ManufacturerNo
            if (AnManufacturer.TelephoneNo != "01733389454")
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is Ok(assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 ManufacturerNo = 1;
            //Invoke the method
            Found = AnManufacturer.Find(ManufacturerNo);
            //Check the ManufacturerNo
            if (AnManufacturer.Email != "apple@hotmail.com")
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCheckFound()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is Ok(assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 ManufacturerNo = 1;
            //Invoke the method
            Found = AnManufacturer.Find(ManufacturerNo);
            //Check the property
            if (AnManufacturer.Check != true)
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ManufacturerNameMinLessOne()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should fail
            string ManufacturerName = "";
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ManufacturerNameMin()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should pass
            string ManufacturerName = "c";
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ManufacturerNameMinPlusOne()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should pass
            string ManufacturerName = "cc";
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ManufacturerNameMaxLessOne()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should pass
            string ManufacturerName = "";
            ManufacturerName = ManufacturerName.PadRight(49, 'c');
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ManufacturerNameMax()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should pass
            string ManufacturerName = " ";
            ManufacturerName = ManufacturerName.PadRight(50, 'c');
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ManufacturerNameMaxPlusOne()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should fail
            string ManufacturerName = "";
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ManufacturerNameMid()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should pass
            string ManufacturerName = " ";
            ManufacturerName = ManufacturerName.PadRight(25, 'c');
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should fail
            string Address = "";
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMin()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should pass
            string Address = "c";
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMinPlusOne()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should pass
            string Address = "cc";
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxLessOne()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should pass
            string Address = "";
            Address = Address.PadRight(49, 'c');
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMax()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should pass
            string Address = " ";
            Address = Address.PadRight(50, 'c');
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxPlusOne()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should fail
            string Address = "";
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMid()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should pass
            string Address = " ";
            Address = Address.PadRight(25, 'c');
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMinLessOne()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should fail
            string Town = "";
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TownMin()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should pass
            string Town = "c";
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TownMinPlusOne()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should pass
            string Town = "cc";
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TownMaxLessOne()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should pass
            string Town = "";
            Town = Town.PadRight(49, 'c');
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TownMax()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should pass
            string Town = " ";
            Town = Town.PadRight(50, 'c');
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TownMaxPlusOne()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should fail
            string Town = "";
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TownMid()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should pass
            string Town = " ";
            Town = Town.PadRight(25, 'c');
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinLessOne()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should fail
            string PostCode = "";
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMin()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should pass
            string PostCode = "c";
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PastCodeMinPlusOne()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should pass
            string PostCode = "cc";
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PostCodeMaxLessOne()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should pass
            string PostCode = "ccccccc";
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PostCodeMax()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should pass
            string PostCode = "cccccccc";
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should fail
            string PostCode = "ccccccccc";
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PostCodeMid()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should pass
            string PostCode = "ccc";
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneNoMinLessOne()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should fail
            string TelephoneNo = "";
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneNoMin()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should pass
            string TelephoneNo = "cccccccccccc";
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TelephoneNoMinPlusOne()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should pass
            string TelephoneNo = "cccccccccccc";
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TelephoneNoMaxLessOne()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should pass
            string TelephoneNo = "ccccccccccccccc";
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TelephoneNoMax()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should pass
            string TelephoneNo = "cccccccccccccccc";
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TelephoneNoPlusOne()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should fail
            string TelephoneNo = "ccccccccccccccccc";
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TelephoneNoMid()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should pass
            string TelephoneNo = "cccccccc";
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailLessOne()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should fail
            string Email = "";
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should pass
            string Email = "cccccccccc";
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinPlusOne()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should pass
            string Email = "ccccccccccc";
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxLessOne()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should pass
            string Email = "";
            Email = Email.PadRight(59, 'c');
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMax()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should pass
            string Email = " ";
            Email = Email.PadRight(60, 'c');
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxPlusOne()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should fail
            string Email = "";
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMid()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //This should pass
            string Email = " ";
            Email = Email.PadRight(30, 'c');
            //Invoke the method
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedMinLessOne()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //Set the date todays date 
            TestDate = DateTime.Now.Date;
            //Change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(-1);
            //Convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //Invoke the method 
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //Set the date todays date 
            TestDate = DateTime.Now.Date;
            //Convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //Invoke the method 
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //Set the date todays date 
            TestDate = DateTime.Now.Date;
            //Change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //Convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //Invoke the method 
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //Set the date todays date 
            TestDate = DateTime.Now.Date;
            //Change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddYears(150);
            //Convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //Invoke the method 
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            string Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //Set the date todays date 
            TestDate = DateTime.Now.Date;
            //Change the date to whatever the date is less 1 day
            TestDate = TestDate.AddYears(-150);
            //Convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //Invoke the method 
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreNotEqual(Error, "");
        }
        //[TestMethod]
        //public void DateAddedExtremeMin()
        //{
        //    // Create instance of the class
        //    clsManufacturer AnManufacturer = new clsManufacturer();
        //    //Boolean variable to store the result of the validation
        //    Boolean OK = false;
        //    //Create a variable to store the test date data
        //    DateTime TestDate;
        //    //Set the date todays date 
        //    TestDate = DateTime.Now.Date;
        //    //Change the date to whatever the date is less 150 years
        //    TestDate = TestDate.AddYears.TestDate(-150);
        //    //Convert the date variable to a string variable 
        //    string DateAdded = TestDate.ToString();
        //    //Invoke the method 
        //    OK = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
        //    //Test to see that the results is correct
        //    Assert.IsFalse(OK);
        //}

        [TestMethod]
        public void DateAddedInvalidData()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //Set the DateAdded to a non date value 
            string DateAdded = "this is not a date!";
            //Invoke the method 
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the results is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            // Create instance of the class
            clsManufacturer AnManufacturer = new clsManufacturer();
            //String variable to store any error message
            String Error = "";
            //Invoke the method 
            Error = AnManufacturer.Valid(ManufacturerNo, ManufacturerName, Address, PostCode, Town, TelephoneNo, Email, DateAdded);
            //Test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        
    }
}
