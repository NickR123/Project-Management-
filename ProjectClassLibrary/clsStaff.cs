using System;

namespace ProjectClassLibrary
{
    public class clsStaff
    {
        //private data members for the properties
        private Int32 mStaffNo;
        private string mFirstName;
        private string mLastName;
        private string mStaffAddress;
        private Int32 mStaffPhoneNo;
        private string mStaffPostCode;
        public string FirstName
        {
            get
            {
                //return the private data
                return mFirstName;
            }
            set
            {
                //set private data
                mFirstName = value;
            }
        }
        public string LastName
        {
            get
            {
                //return the private data
                return mLastName;
            }
            set
            {
                //set private data
                mLastName = value;
            }
        }
        public string StaffAddress
        {
            get
            {
                //return the private data
                return mStaffAddress;
            }
            set
            {
                //set private data
                mStaffAddress = value;
            }
        }
        public int StaffNo
        {
            get
            {
                //return the private data
                return mStaffNo;
            }
            set
            {
                //set private data
                mStaffNo = value;
            }
        }
        public int StaffPhoneNo
        {
            get
            {
                //return the private data
                return mStaffPhoneNo;
            }
            set
            {
                //set private data
                mStaffPhoneNo = value;
            }
        }
        public string StaffPostCode
        {
            get
            {
                //return the private data
                return mStaffPostCode;
            }
            set
            {
                //set private data
                mStaffPostCode = value;
            }
        }

        public bool Find(int staffNo)
        {
            //instance of the data conntection
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffNo", staffNo);
            //execute the stored procedure
            DB.Execute("sproc_TblStaff_FilterByStaffNo");
            if(DB.Count == 1)
            {
                //copy the data from the database into the private data members
                mStaffNo = Convert.ToInt32(DB.DataTable.Rows[0]["StaffNo"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mStaffAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mStaffPhoneNo = Convert.ToInt32(DB.DataTable.Rows[0]["PhoneNo"]);
                mStaffPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                // return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string FirstName, string LastName, string StaffAddress, string StaffPhoneNo, string StaffPostCode)
        {
            // create a string variable to store the error
            String Error = "";
            //if FirstName is blank
            if(FirstName.Length == 0)
            {
                //record the error
                Error = Error + "First name may not be left blank : ";
            }
            //if FirstName is greater than 30 characters
            if (FirstName.Length > 30)
            {
                //record the error
                Error = Error + "FirstName must be less than 30 characters : ";

            }
            if (LastName.Length == 0)
            {
                //record the error
                Error = Error + "Lastname may not be left blank : ";
            }
            //if FirstName is greater than 30 characters
            if (LastName.Length > 50)
            {
                //record the error
                Error = Error + "LastName must be less than 30 characters : ";

            }
            if (StaffAddress.Length < 4)
            {
                //record the error
                Error = Error + "Staff Address cannot be less than 4 characters : ";
            }
            //if FirstName is greater than 30 characters
            if (StaffAddress.Length > 80)
            {
                //record the error
                Error = Error + "StaffAddress must be less than 80 characters : ";

            }
            if (StaffPhoneNo.Length < 10)
            {
                //record the error
                Error = Error + "StaffPhoneNo cannot be less than 10 characters : ";
            }
            //if FirstName is greater than 30 characters
            if (StaffPhoneNo.Length > 16)
            {
                //record the error
                Error = Error + "StaffPhoneNo must be less than 16 characters : ";

            }
            if (StaffPostCode.Length == 0)
            {
                //record the error
                Error = Error + "StaffPostCode cannot be Null : ";
            }
            //if FirstName is greater than 30 characters
            if (StaffPostCode.Length > 9)
            {
                //record the error
                Error = Error + "StaffPostCode must be less than 9 characters : ";

            }
            return Error;
        }
    }
}