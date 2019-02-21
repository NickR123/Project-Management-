using System;

namespace ProjectClassLibrary
{
    public class clsProduct
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public decimal Price { get; set; }

        public bool Find(string productName)
        {
            return true;
        }

        public string Valid(string someProductName)
        {
            return "";
        }
    }
}