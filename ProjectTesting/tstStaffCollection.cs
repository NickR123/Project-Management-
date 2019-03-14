using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectClassLibrary;
using System.Collections.Generic;

namespace ProjectTesting
{
    [TestClass]
    public class tstStaffCollection
    {
       [TestMethod]
       public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test that it exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();

            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffNo = 1;
            TestItem.FirstName = "John";
            TestItem.LastName = "Smith";
            TestItem.StaffAddress = "Some Address";
            TestItem.StaffPhoneNo = 1234567891;
            TestItem.StaffPostCode = "LE7 6AB";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }


        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object
            TestStaff.StaffNo = 1;
            TestStaff.FirstName = "John";
            TestStaff.LastName = "Smith";
            TestStaff.StaffAddress = "Some Address";
            TestStaff.StaffPhoneNo = 1234567891;
            TestStaff.StaffPostCode = "LE7 6AB";
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();

            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffNo = 1;
            TestItem.FirstName = "John";
            TestItem.LastName = "Smith";
            TestItem.StaffAddress = "Some Address";
            TestItem.StaffPhoneNo = 1234567891;
            TestItem.StaffPostCode = "LE7 6AB";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffNo = 1;
            TestItem.FirstName = "John";
            TestItem.LastName = "Smith";
            TestItem.StaffAddress = "Some Address";
            TestItem.StaffPhoneNo = 1234567891;
            TestItem.StaffPostCode = "LE7 6AB";
            //set ThisStaff to test the data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            TestItem.StaffNo = PrimaryKey;
            //find the record 
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
            
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffNo = 1;
            TestItem.FirstName = "John";
            TestItem.LastName = "Smith";
            TestItem.StaffAddress = "Some Address";
            TestItem.StaffPhoneNo = 1234567891;
            TestItem.StaffPostCode = "LE7 6AB";
            //set ThisStaff to test the data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            TestItem.StaffNo = PrimaryKey;
            //find the record 
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaff.Delete();
            //now find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
            

        }





    }
}
