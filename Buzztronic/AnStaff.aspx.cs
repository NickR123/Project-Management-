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
        //variable to store the primary key with page level scope
        Int32 StaffNo;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the  number of the Staff to be processed
            StaffNo = Convert.ToInt32(Session["StaffNo"]);
            if (StaffNo != -1 & IsPostBack==false)
            {
                //display the current data for the record
                DisplayStaff();
            }
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
        //function for updating records
        void Update()
        {
            clsStaffCollection StaffCollect = new clsStaffCollection();
            String Error = StaffCollect.ThisStaff.Valid(TxtFirstName.Text, TxtLastName.Text, TxtStaffAddress.Text, TxtStaffPhoneNo.Text, TxtStaffPostCode.Text);
            //if the data is OK then add it to the objct
            if (Error == "")
            {
                //find the record to update
                StaffCollect.ThisStaff.Find(StaffNo);
                //get data entered by the user
                StaffCollect.ThisStaff.FirstName = TxtFirstName.Text;
                StaffCollect.ThisStaff.LastName = TxtLastName.Text;
                StaffCollect.ThisStaff.StaffAddress = TxtStaffAddress.Text;
                StaffCollect.ThisStaff.StaffPhoneNo = Convert.ToInt32(TxtStaffPhoneNo.Text);
                StaffCollect.ThisStaff.StaffPostCode = TxtStaffPostCode.Text;
                //update the record
                StaffCollect.Update();
                //all done so redirect to the main page
                Response.Redirect("StaffDefault.aspx");
            }
            else
            {
                //report an error
                LblError.Text = "There were problems with the data entered " + Error;
            }
        }
        void DisplayStaff()
        {
            //create an instance of staff collect
            clsStaffCollection StaffCollect = new clsStaffCollection();
            //find the record to update
            StaffCollect.ThisStaff.Find(StaffNo);
            //display the data for this record
            TxtFirstName.Text = StaffCollect.ThisStaff.FirstName;
            TxtLastName.Text = StaffCollect.ThisStaff.LastName;
            TxtStaffAddress.Text = StaffCollect.ThisStaff.StaffAddress;
            TxtStaffPhoneNo.Text = StaffCollect.ThisStaff.StaffPhoneNo.ToString();
            TxtStaffPostCode.Text = StaffCollect.ThisStaff.StaffPostCode;
        }

        protected void BtnOkay_Click(object sender, EventArgs e)
        {
           if (StaffNo == -1)
            {
                //add the new record
                Add();
            }
            else
            {
                //update the record
                Update();
            }
        }

        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            //redirect to the default page
            Response.Redirect("StaffDefault.aspx");
        }
    }
}