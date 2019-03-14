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
    }

}