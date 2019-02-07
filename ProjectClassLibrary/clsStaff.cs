using System;

namespace ProjectClassLibrary
{
    public class clsStaff
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StaffAddress { get; set; }
        public int StaffNo { get; set; }
        public int StaffPhoneNo { get; set; }
        public string StaffPostCode { get; set; }

        public bool Find(string staffFirstName)
        {
            return true;
        }

        public string Valid(string someStaffFirstName)
        {
            return "";
        }
    }
}