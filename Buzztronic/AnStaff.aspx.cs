using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectClassLibrary;

namespace Buzztronic
{
    public partial class AnStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        //function for creating new records
        void Add()
        {
            clsStaffCollection StaffCollect = new clsStaffCollection();
            String Error = StaffCollect.ThisStaff.Valid(TxtFirstName.Text, TxtLastName.Text, TxtStaffAddress.Text, TxtStaffPhoneNo.Text, TxtStaffPostCode.Text);
            //if the data is OK then add it to the objct
            if (Error == "")
            {
                StaffCollect.ThisStaff.FirstName = TxtFirstName.Text;
                StaffCollect.ThisStaff.LastName = TxtLastName.Text;
                StaffCollect.ThisStaff.StaffAddress = TxtStaffAddress.Text;
                StaffCollect.ThisStaff.StaffPhoneNo = Convert.ToInt32(TxtStaffPhoneNo.Text);
                StaffCollect.ThisStaff.StaffPostCode = TxtStaffPostCode.Text;
                //add the record
                StaffCollect.Add();
                //all done so redirect back to the main page
                Response.Redirect("StaffDefault.aspx");
            }
            else
            {
                LblError.Text = "There were problems with the data entered" + Error;
            }
        }

        protected void BtnOkay_Click(object sender, EventArgs e)
        {
            //add the new record
            Add();
            //all done so go back to the main page
            Response.Redirect("StaffDefault.aspx");
        }
    }
}