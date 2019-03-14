using System;

namespace ProjectClassLibrary
{
    public class clsOrder
    {
        //private data member for the mOrderNo property
        private Int32 mOrderNo;
        //private data member for CustomerNo
        private Int32 mCustomerNo;
        //private data member for OrderName
        private string mOrderName;
        //private data member for OrderDate
        private DateTime mOrderDate;
        //private data member for OrderPrice
        private decimal mOrderPrice;

        public int OrderNo
        {
            get
            {
                //return the private data
                return mOrderNo;
            }
            set
            {
                //set the value of the private data member
                mOrderNo = value;
            }
        }
        public int CustomerNo
        {
            get
            {
                //return the private data
                return mCustomerNo;
            }
            set
            {
                //set the value of the private data member
                mCustomerNo = value;
            }
        }
        public string OrderName
        {
            get
            {
                //return the private data
                return mOrderName;
            }
            set
            {
                //set the value of the private data member
                mOrderName = value;
            }
        }
        public DateTime OrderDate
        {
            get
            {
                //return the private data
                return mOrderDate;
            }
            set
            {
                //set the value of the private data member
                mOrderDate = value;
            }
        }
        public decimal OrderPrice
        {
            get
            {
                //return the private data
                return mOrderPrice;
            }
            set
            {
                //set the value of the private data member
                mOrderPrice = value;
            }
        }


        public bool Find(int OrderNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order no to search for
            DB.AddParameter("@OrderNo", OrderNo);
            //execute the store procedure
            DB.Execute("sproc_tblOrder_FilterByOrderNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                mOrderName = Convert.ToString(DB.DataTable.Rows[0]["OrderName"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mOrderPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["OrderPrice"]);
                //return that everything worked OK            
                return true;
            }
            //if no record was found 
            else
            {
                //return false indicating a problem 
                return false;
            }
        }
           

        public string Valid( string orderName, string orderDate, string orderPrice)
        {
            //create a string variable to store the error
            String Error = "";
            //if the OrderName is blank
            if (orderName.Length == 0)
            {
                //record the error
                Error = Error + "The order name may not be blank :";
            }
            //return any error messages
            return Error;
        }
    }
}