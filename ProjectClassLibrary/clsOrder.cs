using System;

namespace ProjectClassLibrary
{
    public class clsOrder
    {
        public int OrderNo { get; set; }
        public int CustomerNo { get; set; }
        public string OrderName { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal OrderPrice { get; set; }

        public bool Find(int orderNo)
        {
            return true;
        }

        public string Valid( string orderName, string orderDate, string orderPrice)
        {
            return "";
        }
    }
}