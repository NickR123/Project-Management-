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

        public string Valid(string StaffNo, string FirstName, string LastName, string StaffAddress, string StaffPhoneNo, string StaffPostCode)
        {
            return "";
        }
    }
}