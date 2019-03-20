using System;
using System.Collections.Generic;
namespace ProjectClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();

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
        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the valyes of mThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@Address", mThisStaff.StaffAddress);
            DB.AddParameter("@PhoneNo", mThisStaff.StaffPhoneNo);
            DB.AddParameter("@PostCode", mThisStaff.StaffPostCode);
            //execute quey return the primary key value
            return DB.Execute("sproc_TblStaff_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters fpr the stored procedure
            DB.AddParameter("@StaffNo", mThisStaff.StaffNo);
            //execute the stored procedure
            DB.Execute("sproc_TblStaff_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisStaff
            //database connection
            clsDataConnection DB = new clsDataConnection();
            //set the parameters fpr the stored procedure
            DB.AddParameter("@StaffNo", mThisStaff.StaffNo);
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@Address", mThisStaff.StaffAddress);
            DB.AddParameter("@PhoneNo", mThisStaff.StaffPhoneNo);
            DB.AddParameter("@PostCode", mThisStaff.StaffPostCode);
            //execute the stored procedure
            DB.Execute("sproc_TblStaff_Update");
        }
    }
}