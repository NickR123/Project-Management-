using System;

namespace ProjectClassLibrary
{
    public class clsProduct
    {
        private Int32 mProductNo;
        private string mProductName;
        private string mDescription;
        private decimal mPrice;
        private bool mActive;

        public int ProductNo
        {
            get
            {
                return mProductNo;
            }
            set
            {
                mProductNo = value;
            }
        }
        public string ProductName
        {
            get
            {
                return ProductName;
            }
            set
            {
                mProductName = value;
            }
        }
        public string Description
        {
            get
            {
                return Description;
            }
            set
            {
                mDescription = value;
            }
        }
        public decimal Price
        {
            get
            {
                //return the private data
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }
        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }

        public bool Find(int ProductNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductNo", ProductNo);
            DB.Execute("sproc_tblProduct_FilterByProductNo");
            if (DB.Count == 1)
            {
                mProductNo = Convert.ToInt32(DB.DataTable.Rows[0]["ProductNo"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);

                // return that everything worked ok
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string ProductName, string Description, string Price)
        {
            // create a string variable to store the error
            String Error = "";
            //if Product Name is blank
            if (ProductName.Length == 0)
            {
                //record the error
                Error = Error + "Product name may not be left blank : ";
            }
            //if Product Name is greater than 40 characters
            if (ProductName.Length > 40)
            {
                //record the error
                Error = Error + "Product Name must be less than 25 characters : ";

            }
            if (Description.Length == 0)
            {
                //record the error
                Error = Error + "Description may not be left blank : ";
            }
            //if description is greater than 30 characters
            if (Description.Length > 50)
            {
                //record the error
                Error = Error + "Description must be less than 30 characters : ";

            }
            if (Price.Length < 3)
            {
                //record the error
                Error = Error + "Price cannot be less than 2 characters : ";
            }
            //if Price is greater than 30 characters
            if (Price.Length > 8)
            {
                //record the error
                Error = Error + "Price must be less than 8 characters : ";

            }

            return Error;
        }
      }
    }

