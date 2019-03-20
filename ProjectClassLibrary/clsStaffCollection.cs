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
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //Var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                clsStaff AnStaff = new clsStaff();
                AnStaff.StaffNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffNo"]);
                AnStaff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AnStaff.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AnStaff.StaffAddress = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnStaff.StaffPhoneNo = Convert.ToInt32(DB.DataTable.Rows[Index]["PhoneNo"]);
                AnStaff.StaffPostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                //add the record to the private data member
                mStaffList.Add(AnStaff);
                //point at the next record
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

        public void ReportByFirstName(string FirstName)
        {
            //filters the records based on a full or partial First name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the postcode parameter to the database
            DB.AddParameter("@FirstName", FirstName);
            //execute the stored procedure
            DB.Execute("sproc_TblStaff_FilterByFirstName");
            //populate the array list with the data table
            PopulateArray(DB);
        }
    }
}