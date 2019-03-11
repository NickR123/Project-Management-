using System;

namespace ProjectClassLibrary
{
    public class clsStaff
    {
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
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
            }
        }
        public string StaffAddress
        {
            get
            {
                return mStaffAddress;
            }
            set
            {
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
                mStaffNo = value;
            }
        }
        public int StaffPhoneNo
        {
            get
            {
                return mStaffPhoneNo;
            }
            set
            {
                mStaffPhoneNo = value;
            }
        }
        public string StaffPostCode
        {
            get
            {
                return mStaffPostCode;
            }
            set
            {
                mStaffPostCode = value;
            }
        }

        public bool Find(int staffNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffNo", staffNo);
            DB.Execute("sproc_TblStaff_FilterByStaffNo");
            if(DB.Count == 1)
            {
                mStaffNo = Convert.ToInt32(DB.DataTable.Rows[0]["StaffNo"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mStaffAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mStaffPhoneNo = Convert.ToInt32(DB.DataTable.Rows[0]["PhoneNo"]);
                mStaffPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                // return that everything worked ok
                return true;
            }
            else
            {
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