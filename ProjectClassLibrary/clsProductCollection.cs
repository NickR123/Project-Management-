using System;
using System.Collections.Generic;
namespace ProjectClassLibrary
{
    public class clsProductCollection
    {
        List<clsProduct> mProductList = new List<clsProduct>();
        clsProduct mThisProduct = new clsProduct();

        public clsProductCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblProduct_SelectAll");
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
            mProductList = new List<clsProduct>();
            //while there are records to process
            while (Index < RecordCount)
            {
                clsProduct AnProduct = new clsProduct();
                AnProduct.ProductNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductNo"]);
                AnProduct.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                AnProduct.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                AnProduct.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                AnProduct.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);

                mProductList.Add(AnProduct);
                Index++;
            }
        }

        public List<clsProduct> ProductList
        {
            get
            {
                return mProductList;
            }
            set
            {
                mProductList = value;
            }
        }
        public int Count
        {
            get
            {

                //return the count of the list
                return mProductList.Count;
            }
            set
            {
                // we shall worry about this later
            }
        }
        public clsProduct ThisProduct
        {
            get
            {
                //return the private data
                return mThisProduct;
            }
            set
            {
                //set the private data
                mThisProduct = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the valyes of mThisProduct
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters
            DB.AddParameter("@ProductName", mThisProduct.ProductName);
            DB.AddParameter("@Description", mThisProduct.Description);
            DB.AddParameter("@Price", mThisProduct.Price);
            DB.AddParameter("@Active", mThisProduct.Active);
            
            //execute quey return the primary key value
            return DB.Execute("sproc_tblProduct_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisproduct
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ProductNo", mThisProduct.ProductNo);
            //execute the stored procedure
            DB.Execute("sproc_tblProduct_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisProduct
            //database connection
            clsDataConnection DB = new clsDataConnection();
            //set the parameters fpr the stored procedure
            DB.AddParameter("@ProductName", mThisProduct.ProductName);
            DB.AddParameter("@Description", mThisProduct.Description);
            DB.AddParameter("@Price", mThisProduct.Price);
            DB.AddParameter("@Active", mThisProduct.Active);
            //execute the stored procedure
            DB.Execute("sproc_tblProduct_Update");
        }

        public void ReportByProductName(string ProductName)
        {
            //filters the records based on a full or partial First name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the postcode parameter to the database
            DB.AddParameter("@ProductName", ProductName);
            //execute the stored procedure
            DB.Execute("sproc_tbl_FilterByProductName");
            //populate the array list with the data table
            PopulateArray(DB);
        }
    }
}