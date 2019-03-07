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
            Error = AStaff.Valid(StaffNo,FirstName,LastName,StaffAddress,StaffPhoneNo,staffPostCode);
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
    }
    
}
