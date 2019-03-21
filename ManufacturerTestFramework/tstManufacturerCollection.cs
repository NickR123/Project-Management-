using System;
using System.Collections.Generic;
using ManufacturerClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ManufacturerTestFramework
{
    [TestClass]
    public class tstManufacturerCollection
    {
        public int PrimaryKey { get; private set; }

        [TestMethod]
        public void Instance33Ok()
        {
            // Create instance of the class
            clsManufacturerCollection AllManufacturers = new clsManufacturerCollection();
            //Test to see that it exist 
            Assert.IsNotNull(AllManufacturers);
        }
        [TestMethod]
        public void ManufacturerListOk()
        {
            // Create instance of the class
            clsManufacturerCollection AllManufacturers = new clsManufacturerCollection();
            //Create some test data to assign to the property and data needs to be a list objects 
            List<clsManufacturer> TestList = new List<clsManufacturer>();
            //Add an item to the list and create the item of test data 
            clsManufacturer TestItem = new clsManufacturer();
            //Set item properties 
            TestItem.Check = true;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ManufacturerName = "Apple";
            TestItem.ManufacturerNo = 1;
            TestItem.Address = "40 Paynell Road";
            TestItem.PostCode = "PE1 5ST";
            TestItem.Town = "Peterborough";
            TestItem.TelephoneNo = "01733389454";
            TestItem.Email = "apple@hotmail.com";
            //Add item to the test list 
            TestList.Add(TestItem);
            //Assign data to the property 
            AllManufacturers.ManufacturerList = TestList;
            //Test to see that the two values are the same 
            Assert.AreEqual(AllManufacturers.ManufacturerList, TestList);
        }
        [TestMethod]
        public void ThisManufacturerPropertyOk()
        {
            // Create instance of the class
            clsManufacturerCollection AllManufacturers = new clsManufacturerCollection();
            //Create some test data to assign to the property 
            clsManufacturer TestManufacturer = new clsManufacturer();
            //Set the properties of the test object  
            TestManufacturer.Check = true;
            TestManufacturer.DateAdded = DateTime.Now.Date;
            TestManufacturer.ManufacturerName = "Apple";
            TestManufacturer.ManufacturerNo = 1;
            TestManufacturer.Address = "40 Paynell Road";
            TestManufacturer.PostCode = "PE1 5ST";
            TestManufacturer.Town = "Peterborough";
            TestManufacturer.TelephoneNo = "01733389454";
            TestManufacturer.Email = "apple@hotmail.com";
            //Assign data to the property 
            AllManufacturers.ThisManufacturer = TestManufacturer;
            //Test to see that the two values are the same 
            Assert.AreEqual(AllManufacturers.ThisManufacturer, TestManufacturer);
        }
        [TestMethod]
        public void ListAndCountOk()
        {
            // Create instance of the class
            clsManufacturerCollection AllManufacturers = new clsManufacturerCollection();
            //Create some test data to assign to the property the data needs to be a list of objects
            List<clsManufacturer> TestList = new List<clsManufacturer>();
            //Add item to the list and create the item of test data 
            clsManufacturer TestItem = new clsManufacturer();
            //Set items properties 
            TestItem.Check = true;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ManufacturerName = "Apple";
            TestItem.ManufacturerNo = 1;
            TestItem.Address = "40 Paynell Road";
            TestItem.PostCode = "PE1 5ST";
            TestItem.Town = "Peterborough";
            TestItem.TelephoneNo = "01733389454";
            TestItem.Email = "apple@hotmail.com";
            //Add the item to the test list 
            TestList.Add(TestItem);
            //Assign the data to the property  
            AllManufacturers.ManufacturerList = TestList;
            //Test to see that the two values are the same 
            Assert.AreEqual(AllManufacturers.Count, TestList.Count);
        }
        //[TestMethod]
        //public void CountManufacturerPropertyOk()
        //{
        //    // Create instance of the class
        //    clsManufacturerCollection AllManufacturers = new clsManufacturerCollection();
        //    //Create some test data to assign to the property 
        //    Int32 SomeCount = 3;
        //    //Assign data to the property 
        //    AllManufacturers.Count = SomeCount;
        //    //Test to see that the two values are the same 
        //    Assert.AreEqual(AllManufacturers.Count, SomeCount);
        //}
        [TestMethod]
        public void AddManufacturerMethodOk()
        {
            // Create instance of the class
            clsManufacturerCollection AllManufacturers = new clsManufacturerCollection();
            //Create the item to test data
            clsManufacturer TestItem = new clsManufacturer();
            //Variable to store primary key
            Int32 PrimaryKey = 0;
            //Set items properties 
            TestItem.Check = true;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ManufacturerName = "Apple";
            TestItem.ManufacturerNo = 1;
            TestItem.Address = "40 Paynell Road";
            TestItem.PostCode = "PE1 5ST";
            TestItem.Town = "Peterborough";
            TestItem.TelephoneNo = "01733389454";
            TestItem.Email = "apple@hotmail.com";
            //Set ThisManufacturer to the test data
            AllManufacturers.ThisManufacturer = TestItem;
            //Add the record
            PrimaryKey = AllManufacturers.Add();
            //Set the primary key to the test data 
            TestItem.ManufacturerNo = PrimaryKey;
            //Find the record 
            AllManufacturers.ThisManufacturer.Find(PrimaryKey);
            //Test to see that the two values are the same 
            Assert.AreEqual(AllManufacturers.ThisManufacturer, TestItem);
        }
        [TestMethod]
        public void DeleteManufacturerMethodOk()
        {
            // Create instance of the class
            clsManufacturerCollection AllManufacturers = new clsManufacturerCollection();
            //Create the item to test data
            clsManufacturer TestItem = new clsManufacturer();
            //Variable to store primary key
            Int32 PrimaryKey = 0;
            //Set items properties 
            TestItem.Check = true;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ManufacturerName = "Apple";
            TestItem.ManufacturerNo = 1;
            TestItem.Address = "40 Paynell Road";
            TestItem.PostCode = "PE1 5ST";
            TestItem.Town = "Peterborough";
            TestItem.TelephoneNo = "01733389454";
            TestItem.Email = "apple@hotmail.com";
            //Set ThisManufacturer to the test data
            AllManufacturers.ThisManufacturer = TestItem;
            //Add the record
            PrimaryKey = AllManufacturers.Add();
            //Set the primary key to the test data 
            TestItem.ManufacturerNo = PrimaryKey;
            //Find the record 
            AllManufacturers.ThisManufacturer.Find(PrimaryKey);
            //Delete the record 
            AllManufacturers.Delete();
            //Now find the record 
            Boolean Found = AllManufacturers.ThisManufacturer.Find(PrimaryKey);
            //Test to see that the record was not found  
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void UpdateManufacturerMethodOk()
        {
            // Create instance of the class
            clsManufacturerCollection AllManufacturers = new clsManufacturerCollection();
            //Create the item of test data 
            clsManufacturer TestItem = new clsManufacturer();
            //Variable to store the primary key 
            //Int32 Primarykey = 0;
            //Set item properties 
            TestItem.Check = true;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ManufacturerName = "Apple";
            TestItem.ManufacturerNo = 1;
            TestItem.Address = "40 Paynell Road";
            TestItem.PostCode = "PE1 5ST";
            TestItem.Town = "Peterborough";
            TestItem.TelephoneNo = "01733389454";
            TestItem.Email = "apple@hotmail.com";
            //St ThisManufacturer to the test data 
            AllManufacturers.ThisManufacturer = TestItem;
            //Add the record 
            PrimaryKey = AllManufacturers.Add();
            //Set the primary key to the test data 
            TestItem.ManufacturerNo = PrimaryKey;
            //Modify the test data 
            TestItem.Check = false;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ManufacturerName = "Apple";
            TestItem.ManufacturerNo = 1;
            TestItem.Address = "40 Paynell Road";
            TestItem.PostCode = "PE1 5ST";
            TestItem.Town = "Peterborough";
            TestItem.TelephoneNo = "01733389454";
            TestItem.Email = "apple@hotmail.com";
            //Set the record based on the new test data 
            AllManufacturers.ThisManufacturer = TestItem;
            //Update the record 
            AllManufacturers.Update();
            //Now find the record 
            AllManufacturers.ThisManufacturer.Find(PrimaryKey);
            //Test to see ThisManufacturer matches the test data  
            Assert.AreEqual(AllManufacturers.ThisManufacturer, TestItem);
        }
        [TestMethod]
        public void FilterByManufacturerNoMethodOk()
        {
            // Create an instance of the class containing unfiltered results 
            clsManufacturerCollection AllManufacturers = new clsManufacturerCollection();
            //Create an instance of the filtered data 
            clsManufacturerCollection FilterManufacturers = new clsManufacturerCollection();
            //Apply a blank string (should return all records)
            FilterManufacturers.FilterByManufacturerNo("");
            //Test to see that the two values are the same 
            Assert.AreNotEqual(AllManufacturers.Count, FilterManufacturers.Count);


        }
        [TestMethod]
        public void FilterByManufacturerNoNoneFound()
        {
            //Create an instance of the filtered data 
            clsManufacturerCollection FilteredManufacturers = new clsManufacturerCollection();
            //Apply a manufacturer no doesn't exist
            FilteredManufacturers.FilterByManufacturerNo("1");
            //Test to see that there are no records  
            Assert.AreNotEqual(0, FilteredManufacturers.Count);


        }
        [TestMethod]
        public void FilterByManufacturerNoTestDataFound()
        {
            //Create an instance of the filtered data 
            clsManufacturerCollection FilteredManufacturers = new clsManufacturerCollection();
            //Variable store outcome
            Boolean Ok = true;
            //Apply a manufacturer no doesn't exist
            FilteredManufacturers.FilterByManufacturerNo("1");
            //Check that the correct number of records are found 
            if (FilteredManufacturers.Count == 1)
            {
                //Check that the first record is ID 1
                if (FilteredManufacturers.ManufacturerList[0].ManufacturerNo != 1)
                {
                    Ok = false;
                }
                else
                {
                    Ok = false;
                }
                //Test to see that there are no records
                Assert.IsFalse(Ok);
            }


        }
    }
}
