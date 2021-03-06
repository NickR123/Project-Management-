﻿using System;
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

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.FirstName = "John";
            TestItem.LastName = "Smith";
            TestItem.StaffAddress = "Some Address";
            TestItem.StaffPhoneNo = 1234567891;
            TestItem.StaffPostCode = "LE7 6AB";
            //set ThisStaff to test the data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set primary key of 
            TestItem.StaffNo = PrimaryKey;
            //modify the test data
            TestItem.FirstName = "Alex";
            TestItem.LastName = "Jones";
            TestItem.StaffAddress = "Other Address";
            TestItem.StaffPhoneNo = 0987654329;
            TestItem.StaffPostCode = "LE4 6AF";
            //set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            //update the record
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see ThisStaff matches the test data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);

        }

        [TestMethod]
        public void ReportByFirstNameOK()
        {
            //create an instance of the class containing unfiltered results
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a blank string(Should return all records);
            FilteredStaff.ReportByFirstName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByFirstNameNoneFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a First name that doesn't exist
            FilteredStaff.ReportByFirstName("qqqqq");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStaff.Count);

        }






    }
}
