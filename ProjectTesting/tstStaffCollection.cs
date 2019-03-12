using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectClassLibrary;
using System.Collections.Generic;

namespace ProjectTesting
{
    [TestClass]
    public class tstStaffCollection
    {
       [TestMethod]
       public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test that it exists
            Assert.IsNotNull(AllStaff);
        }

    }
}
