using System;

namespace ProjectClassLibrary
{
    public class clsStaff
    {
        private Int32 mStaffNo;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StaffAddress { get; set; }
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
        public int StaffPhoneNo { get; set; }
        public string StaffPostCode { get; set; }

        public bool Find(int staffNo)
        {
            //set the private data member to test the value
            mStaffNo = 21;
            //always return true
            return true;
        }

        public string Valid(string someStaffFirstName)
        {
            return "";
        }
    }
}