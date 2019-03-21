using System;
using System.Collections.Generic;

namespace ManufacturerClassLibrary
{
    public class clsManufacturerCollection
    {
        //private dats member for the list 
        List<clsManufacturer> mManufacturerList = new List<clsManufacturer>();
        //private data member thisManufacturer
        clsManufacturer mThisManufacturer = new clsManufacturer();

        //public property for the Manufacturer list
        public List<clsManufacturer> ManufacturerList
        {
            get
            {
                //Return the private data 
                return mManufacturerList;
            }
            set
            {
                //Set the private data
                mManufacturerList = value;
            }
        }

        //public property for ThisManufacturer
        public clsManufacturer ThisManufacturer
        {
            get
            {
                //return the private data 
                return mThisManufacturer;
            }
            set
            {
                //set the private data 
                mThisManufacturer = value;

            }
        }

        //public property for the count
        public int Count
        {
            get
            {
                //return the private data 
                return mManufacturerList.Count;
            }
            set
            {
                //set the private data 
                
            }
        }
        //Constructor for class
        public clsManufacturerCollection()
        {
            //Variable for the index
            //Int32 Index = 0;
            //Variable to store the record count 
            //Int32 RecordCount = 0;

            //Object for data connection 
            clsDataConnection DB = new clsDataConnection();
            //Excute the stored procedure 
            DB.Execute("sproc_tblManufacturer_SelectAll");
            //Populate the array list with the data table 
            PopulateArray(DB);

            ////Get the count of records 
            //RecordCount = DB.Count;
            ////While there are records to process
            //while (Index < RecordCount)
            //{
            //    //Create a blank manufacturer
            //    clsManufacturer AnManufacturer = new clsManufacturer();
            //    //Read in the fields from the current record
            //    AnManufacturer.ManufacturerNo = Convert.ToInt32(DB.DataTable.Rows[0]["ManufacturerNo"]);
            //    AnManufacturer.Check = Convert.ToBoolean(DB.DataTable.Rows[0]["Check"]);
            //    AnManufacturer.Address = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
            //    AnManufacturer.PostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
            //    AnManufacturer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
            //    AnManufacturer.ManufacturerName = Convert.ToString(DB.DataTable.Rows[0]["ManufacturerName"]);
            //    AnManufacturer.Town = Convert.ToString(DB.DataTable.Rows[0]["Town"]);
            //    AnManufacturer.TelephoneNo = Convert.ToString(DB.DataTable.Rows[0]["TelephoneNo"]);
            //    AnManufacturer.Email = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
            //    //Add the record to the private data member
            //    mManufacturerList.Add(AnManufacturer);
            //    //Point at next record 
            //    Index++;
            //}
        }
        void PopulateArray(clsDataConnection DB)
        {
            //Populates the array list based on the data table in the parameter DB
            //Variable for the index
            Int32 Index = 0;
            //Variable to store the record count 
            Int32 RecordCount = 0;
            //Get the count of records 
            RecordCount = DB.Count;
            //Clear the private array list 
            mManufacturerList = new List<clsManufacturer>();
            //While there are records to process
            while (Index < RecordCount)
            {
                //Create a blank manufacturer
                clsManufacturer AnManufacturer = new clsManufacturer();
                //Read in the fields from the current record
                AnManufacturer.ManufacturerNo = Convert.ToInt32(DB.DataTable.Rows[0]["ManufacturerNo"]);
                AnManufacturer.Check = Convert.ToBoolean(DB.DataTable.Rows[0]["Check"]);
                AnManufacturer.Address = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                AnManufacturer.PostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                AnManufacturer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                AnManufacturer.ManufacturerName = Convert.ToString(DB.DataTable.Rows[0]["ManufacturerName"]);
                AnManufacturer.Town = Convert.ToString(DB.DataTable.Rows[0]["Town"]);
                AnManufacturer.TelephoneNo = Convert.ToString(DB.DataTable.Rows[0]["TelephoneNo"]);
                AnManufacturer.Email = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                //Add the record to the private data member
                mManufacturerList.Add(AnManufacturer);
                //Point at next record 
                Index++;
            }
        }
        public void Delete()
        {
            //Deletes the record pointed to by ThisManufacturer and connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@ManufacturerNo", mThisManufacturer.ManufacturerNo);
            //Execute the stored procedure 
            DB.Execute("sproc_tblManufacturer_Delete");

        }

        public int Add()
        {
            //Adds a new record to the database based on the values of ThisManufacturer and connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure 
            DB.AddParameter("@ManufacturerNo", mThisManufacturer.ManufacturerNo);
            DB.AddParameter("@ManufacturerName", mThisManufacturer.ManufacturerName);
            DB.AddParameter("@Address", mThisManufacturer.Address);
            DB.AddParameter("@PostCode", mThisManufacturer.PostCode);
            DB.AddParameter("@DateAdded", mThisManufacturer.DateAdded);
            DB.AddParameter("@Check", mThisManufacturer.Check);
            DB.AddParameter("@Town", mThisManufacturer.Town);
            DB.AddParameter("@TelephoneNo", mThisManufacturer.TelephoneNo);
            DB.AddParameter("@Email", mThisManufacturer.Email);
            //Execute the query retuning the primary key value 
            return DB.Execute("sproc_tblManufacturer_Insert");
        }

        public void Update()
        {
            //Upadate an existing record base on the values of ThisManufacturer and connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure 
            DB.AddParameter("@ManufacturerNo", mThisManufacturer.ManufacturerNo);
            DB.AddParameter("@ManufacturerName", mThisManufacturer.ManufacturerName);
            DB.AddParameter("@Address", mThisManufacturer.Address);
            DB.AddParameter("@PostCode", mThisManufacturer.PostCode);
            DB.AddParameter("@DateAdded", mThisManufacturer.DateAdded);
            DB.AddParameter("@Check", mThisManufacturer.Check);
            DB.AddParameter("@Town", mThisManufacturer.Town);
            DB.AddParameter("@TelephoneNo", mThisManufacturer.TelephoneNo);
            DB.AddParameter("@Email", mThisManufacturer.Email);
            //Execute the stored procedure 
            DB.Execute("sproc_tblManufacturer_Update");
        }

        public void FilterByManufacturerNo(int ManufacturerNo)
        {
            //Filters the record based on ManufacturerNo and connect to the database
            clsDataConnection DB = new clsDataConnection();
            //Send the ManufacturerNo parameter to the database
            DB.AddParameter("@ManufacturerNo", ManufacturerNo);
            //Execute the stored procedure 
            DB.Execute("sproc_tblManufacturer_FilterByManufacturerNo");
            //Populate the array list with the data table
            PopulateArray(DB);

        }

        public void FilterByManufacturerNo(string ManufacturerNo)
        {
            //Filter the records based on Manufacturer no and connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Manufacturer no parameter to the database
            DB.AddParameter("@ManufacturerNo", ManufacturerNo);
            //execute the stored procedure
            DB.Execute("sproc_tblManufacturer_FilterByManufacturerNo");
            //populate the array list with the data table
            PopulateArray(DB);
        }
    }
}