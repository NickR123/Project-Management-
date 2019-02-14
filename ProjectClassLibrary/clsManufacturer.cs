using System;

namespace ProjectClassLibrary
{
    public class clsManufacturer
    {
        public bool Check { get; set; }
        public DateTime DateAdded { get; set; }
        public int ManufacturerNo { get; set; }
        public string ManufacturerName { get; set; }
        public int Count { get; set; }

        public bool Find(int manufacturerNo)
        {
            return true;
        }

        public string Valid(string someManufacturer)
        {
            //If the name of the manufacturer is not blank
            if (someManufacturer != "")
            {
                //Return a blank string 
                return "";
            }
            else
            {
                //Otherwise return an error message 
                return "The Manufacturer name may not be blank";
            }
        }
    }
}