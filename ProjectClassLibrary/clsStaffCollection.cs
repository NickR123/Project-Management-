using System;
using System.Collections.Generic;
namespace ProjectClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();

        public clsStaffCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            RecordCount = DB.Count;
            while(Index < RecordCount)
            {
                clsStaff AnStaff = new clsStaff();
                AnStaff.StaffNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffNo"]);
                AnStaff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AnStaff.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AnStaff.StaffAddress = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnStaff.StaffPhoneNo = Convert.ToInt32(DB.DataTable.Rows[Index]["PhoneNo"]);
                AnStaff.StaffPostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                mStaffList.Add(AnStaff);
                Index++;
            }
        }

        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }
        public int Count
        {
            get
            {
     
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                // we shall worry about this later
            }
        }
        public clsStaff ThisStaff { get; set; }
    }
}