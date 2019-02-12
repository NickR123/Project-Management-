using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectClassLibrary;

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
        [TestMethod]
        public void InstanceOK()
        {
            clsProduct AProduct = new clsProduct();
            Assert.IsNotNull(AProduct);
        }
        [TestMethod]
        public void ProductNameOK()
        {
            clsProduct AProduct = new clsProduct();
            string SomeProductName = "Fred";
            AProduct.ProductName = SomeProductName;
            Assert.AreEqual(AProduct.ProductName, SomeProductName);
        }

        [TestMethod]
        public void DescriptionOK()
        {
            clsProduct AProduct = new clsProduct();
            string SomeDescription = "Fred";
            AProduct.Description = SomeDescription;
            Assert.AreEqual(AProduct.Description, SomeDescription);
        }

        [TestMethod]
        public void ActiveProductOK()
        {
            clsProduct AProduct = new clsProduct();
            string SomeActive = "Jimblor";
            AProduct.Active = SomeActive;
            Assert.AreEqual(AProduct.Active, SomeActive);
        }



        [TestMethod]
        public void FindMethodOk()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            string ProductName = "john";
            Found = AProduct.Find(ProductName);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string SomeProductName = "john";
            Error = AProduct.Valid(SomeProductName);
            Assert.AreEqual(Error, "");
        }
    }
}
