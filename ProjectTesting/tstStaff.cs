using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectClassLibrary;
using System.Collections.Generic;

namespace ProjectTesting
{
    [TestClass]
    public class tstStaff
    {
        string StaffNo = "1";
        string FirstName = "John";
        string LastName = "Fiddle";
        string StaffAddress = "21 lane";
        string StaffPhoneNo = "1234567891";
        string staffPostCode = "LE4 4ab";

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
            Int32 StaffNo = 1;
            Found = AStaff.Find(StaffNo);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            Error = AStaff.Valid(FirstName,LastName,StaffAddress,StaffPhoneNo,staffPostCode);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void TestStaffNoFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 1;
            //invoke the method
            Found = AnStaff.Find(StaffNo);
            //check the staff No
            if (AnStaff.StaffNo != 1)
            {
                OK = false;
            }
            //test the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 1;
            //invoke the method
            Found = AnStaff.Find(StaffNo);
            //check the staff No
            if (AnStaff.FirstName != "Jimby")
            {
                OK = false;
            }
            //test the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 1;
            //invoke the method
            Found = AnStaff.Find(StaffNo);
            //check the staff No
            if (AnStaff.LastName != "Bimblor")
            {
                OK = false;
            }
            //test the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffPhoneNoFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 1;
            //invoke the method
            Found = AnStaff.Find(StaffNo);
            //check the staff No
            if (AnStaff.StaffPhoneNo != 988812345)
            {
                OK = false;
            }
            //test the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffPostcodeFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 1;
            //invoke the method
            Found = AnStaff.Find(StaffNo);
            //check the staff No
            if (AnStaff.StaffPostCode != "CV34 BCD")
            {
                OK = false;
            }
            //test the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffAddressFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 1;
            //invoke the method
            Found = AnStaff.Find(StaffNo);
            //check the staff No
            if (AnStaff.StaffAddress != "68 markfield lane")
            {
                OK = false;
            }
            //test the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string FirstName = "";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMin()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string FirstName = "a";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMinplusOne()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string FirstName = "aa";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string FirstName = "";
            FirstName = FirstName.PadRight(29, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMax()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string FirstName = "";
            FirstName = FirstName.PadRight(30, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string FirstName = "";
            FirstName = FirstName.PadRight(15, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMaxplusOne()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string FirstName = "";
            FirstName = FirstName.PadRight(31, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMaxExtreme()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string FirstName = "";
            FirstName = FirstName.PadRight(500, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LasttNameMinLessOne()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string LastName = "";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LasttNameMin()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string LastName = "a";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMinplusOne()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string LastName = "aa";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMaxlessOne()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string LastName = "";
            LastName = LastName.PadRight(49, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMax()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string LastName = "";
            LastName = LastName.PadRight(50, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string LastName = "";
            LastName = LastName.PadRight(25, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string LastName = "";
            LastName = LastName.PadRight(51, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string LastName = "";
            LastName = LastName.PadRight(500, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffAddressMin()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string StaffAddress = "aaaa";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffAddressMinlessOne()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string StaffAddress = "aaa";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffAddressMinPlusOne()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string StaffAddress = "aaaaa";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffAddressMaxlessOne()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(79, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffAddressMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(81, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffAddressMid()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(40, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffAddressMax()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(80, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffAddressExtremeMax()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(500, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPhoneNoMin()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string StaffPhoneNo = "1234567891";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffPhoneNoMinPlusOne()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string StaffPhoneNo = "12345678911";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffPhoneNoMinLessOne()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string StaffPhoneNo = "123456789";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffPhoneNoMid()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string StaffPhoneNo = "12345678";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffPhoneNoMax()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string StaffPhoneNo = "1234567812345678";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffPhoneNoMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string StaffPhoneNo = "12345678123456781";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffPhoneNoMaxLessOne()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string StaffPhoneNo = "123456781234567";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPhoneNoExtremeMax()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string StaffPhoneNo = "123456781234567";
            StaffPhoneNo = StaffPhoneNo.PadRight(500, '1');
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffPostCodeMin()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string staffPostCode = "a";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffPostCodeMinPlusOne()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string staffPostCode = "aa";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffPostCodeminLessOne()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string staffPostCode = "";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffPostCodemid()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string staffPostCode = "aaaa";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffPostCodemax()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string staffPostCode = "aaaaaaaaa";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        public void StaffPostCodemaxPlusOne()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string staffPostCode = "aaaaaaaaaa";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffPostCodemaxLessOne()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string staffPostCode = "aaaaaaaa";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffPostCodeExtremeMax()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //some test data to pass the method
            string staffPostCode = "";
            staffPostCode = staffPostCode.PadRight(500, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, StaffAddress, StaffPhoneNo, staffPostCode);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
    
}
