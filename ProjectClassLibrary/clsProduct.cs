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

        public string Valid(string someProductName)
        {
            return "";
        }
    }
}

