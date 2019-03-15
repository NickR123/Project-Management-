using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectClassLibrary;


namespace Buzztronic
{
    public partial class StaffDelete : System.Web.UI.Page
    {
        // var to store the primary key value of the record to be deleted
        Int32 StaffNo;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the address to be deleted from the session object
            StaffNo = Convert.ToInt32(Session["StaffNo"]);
        }

        void DeleteStaff()
        {
            clsStaffCollection StaffCollect = new clsStaffCollection();
            //find the record to delete
            StaffCollect.ThisStaff.Find(StaffNo);
            //delete the record
            StaffCollect.Delete();
        }

        protected void BtnYes_Click(object sender, EventArgs e)
        {
            //delete the record
            DeleteStaff();
            //redirects back to the default page
            Response.Redirect("StaffDefault.aspx");
        }
    }
}