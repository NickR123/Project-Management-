using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectClassLibrary;

namespace Buzztronic
{
    public partial class StaffDefault : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          if(IsPostBack == false)
            {
                //update the list box
                DisplayStaff();
            }
        }
        void DisplayStaff()
        {
            //create an instance of the staff collection
            clsStaffCollection Staff = new clsStaffCollection();
            //set the source to the list of staff in the collection
            LstStaff.DataSource = Staff.StaffList;
            //get the primary key
            LstStaff.DataValueField = "StaffNo";
            //set the data field to display
            LstStaff.DataTextField = "FirstName";
            //bind data to the list
            LstStaff.DataBind();
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            Session["StaffNo"] = -1;
            //redirects to the data entry page
            Response.Redirect("AnStaff.aspx");
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 StaffNo;
            //if a record has been selected from the list
            if(LstStaff.SelectedIndex != -1)
            {
                //get the primary key value of the record to be deleted
                StaffNo = Convert.ToInt32(LstStaff.SelectedValue);
                //store the data in the session object
                Session["StaffNo"] = StaffNo;
                //redirect to the delete page
                Response.Redirect("StaffDefault.aspx");
            }
            else // if no record has been selected
            {
                //display an error
                LblError.Text = "Please select a record to delete from the list";
            }
        }
    }

}