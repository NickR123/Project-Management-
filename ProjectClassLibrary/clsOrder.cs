using System;

namespace ProjectClassLibrary
{
    public class clsOrder
    {
        public int OrderNo { get; set; }
        public int CustomerNo { get; set; }
        public string OrderName { get; set; }
        public DateTime DateAdded { get; set; }
        public decimal OrderPrice { get; set; }
    }
}