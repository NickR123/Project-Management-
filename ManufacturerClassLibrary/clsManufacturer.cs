using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ManufacturerClassLibrary
{
    public class clsManufacturer
    {
        //Private data member for the ManufacturerNo property
        private Int32 mManufacturerNo;
        //Private data member for check
        private Boolean mCheck;
        //Private data member for Address
        private string mAddress;
        //Private data member for post code
        private string mPostCode;
        //Private data member for date added data member
        private DateTime mDateAdded;
        //Private data member for manufacturer name 
        private string mManufacturerName;
        //Private data member for Town 
        private string mTown;
        //Private data member for telephone no 
        private string mTelephoneNo;
        //Private data member for Email 
        private string mEmail;

        //public property for check
        public bool Check
        {
            get
            {
                //return the private data 
                return mCheck;
            }
            set
            {
                //set the private data
                mCheck = value;
            }
        }
        //public property for address
        public string Address
        {
            get
            {
                //return the private data 
                return mAddress;
            }
            set
            {
                //set the private data
                mAddress = value;
            }
        }
        //public property for post code
        public string PostCode
        {
            get
            {
                //return the private data 
                return mPostCode;
            }
            set
            {
                //set the private data
                mPostCode = value;
            }
        }
        //public property for date added
        public DateTime DateAdded
        {
            get
            {
                //return the private data 
                return mDateAdded;
            }
            set
            {
                //set the private data
                mDateAdded = value;
            }
        }
        //public property for ManufacturerNo
        public int ManufacturerNo
        {
            get
            {
                //return the private data 
                return mManufacturerNo;
            }
            set
            {
                //set the private data
                mManufacturerNo = value;
            }
        }
        //public property for manufacturer name
        public string ManufacturerName
        {
            get
            {
                //return the private data 
                return mManufacturerName;
            }
            set
            {
                //set the private data
                mManufacturerName = value;
            }
        }

        //public property for Town 
        public string Town
        {
            get
            {
                //return the private data 
                return mTown;
            }
            set
            {
                //set the private data
                mTown = value;
            }

        }
        //public property for telephone no
        public string TelephoneNo
        {
            get
            {
                //return the private data 
                return mTelephoneNo;
            }
            set
            {
                //set the private data
                mTelephoneNo = value;
            }
        }
        //public property for email
        public string Email
        {
            get
            {
                //return the private data 
                return mEmail;
            }
            set
            {
                //set the private data
                mEmail = value;
            }
        }
        public bool Find(int ManufacturerNo)
        {

            ////Set the private data members to the test data value 
            //mManufacturerNo = 1;
            //mManufacturerName = "Apple";
            //mAddress = "40 Paynell Road";
            //mTown = "Peterboough";
            //mPostCode = "PE1 5ST";
            //mTelephoneNo = "01733389454";
            //mEmail = "ple@hotmail.com";
            //mDateAdded = Convert.ToDateTime("14/03/2019 00:00:00");
            //mCheck = true;
            ////Always return true
            //return true;

            //Create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //Add the parameter for the ManufacturerNo to search for 
            DB.AddParameter("@ManufacturerNo", ManufacturerNo);
            //Execute the stored procedure 
            DB.Execute("sproc_tblManufacturer_FilterByManufacturerNo");
            //If onre record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //Copy the data from the database to the private data members 
                mManufacturerNo = Convert.ToInt32(DB.DataTable.Rows[0]["ManufacturerNo"]);
                mCheck = Convert.ToBoolean(DB.DataTable.Rows[0]["Check"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mManufacturerName = Convert.ToString(DB.DataTable.Rows[0]["ManufacturerName"]);
                mTown = Convert.ToString(DB.DataTable.Rows[0]["Town"]);
                mTelephoneNo = Convert.ToString(DB.DataTable.Rows[0]["TelephoneNo"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                //Return that everything worked Ok
                return true;

            }
            //If no record was found 
            else
            {
                //Return false indicating a problem 
                return false;
            }
        }


        public string Valid(string ManufacturerNo, string ManufacturerName, string Address, string PostCode, string Town, string TelephoneNo, string Email, string DateAdded)
        {

            //Create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the Manufacturer Name is blank
            if (ManufacturerName.Length == 0)
            {
                //record the error
                Error = Error + "The Manufacturer name may not be blank : ";
            }
            //if the house no is greater than 50 characters
            if (ManufacturerName.Length > 50)
            {
                //Record the error
                Error = Error + "The Manufacturer name must be less than 50 characters : ";
            }
            try
            {
                //Copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(DateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            //is the post code blank
            if (PostCode.Length == 0)
            {
                //record the error
                Error = Error + "The post code may not be blank : ";
            }
            //if the post code is too long
            if (PostCode.Length > 8)
            {
                //record the error
                Error = Error + "The post code must be less than 8 characters : ";
            }
            //is the address blank
            if (Address.Length == 0)
            {
                //record the error
                Error = Error + "The address may not be blank : ";
            }
            //if the street is too long
            if (Address.Length > 50)
            {
                //record the error
                Error = Error + "The address must be less than 50 characters : ";
            }
            //is the town blank
            if (Town.Length == 0)
            {
                //record the error
                Error = Error + "The town may not be blank : ";
            }
            //if the town is too long
            if (Town.Length > 50)
            {
                //record the error
                Error = Error + "The town must be less than 50 characters : ";
            }

            //is the telephone no blank
            if (TelephoneNo.Length == 0)
            {
                //record the error
                Error = Error + "The telephone no may not be blank : ";
            }
            //if the telephone no is too long
            if (TelephoneNo.Length > 16)
            {
                //record the error
                Error = Error + "The telephone no must be less than 16 characters : ";
            }
            //is the email blank
            if (Email.Length == 0)
            {
                //record the error
                Error = Error + "The email may not be blank : ";
            }
            //if the email is too long
            if (Email.Length > 60)
            {
                //record the error
                Error = Error + "The email must be less than 60 characters : ";
            }

            //return any error messages
            return Error;
        }
    }
}