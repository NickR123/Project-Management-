using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Buzztronic
{
    public partial class MainMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnStaffMenu_Click(object sender, EventArgs e)
        {
            //go to staff page
            Response.Redirect("StaffDefault.aspx");
        }

        protected void BtnProductMenu_Click(object sender, EventArgs e)
        {
            //go to product page
            Response.Redirect("ProductDefault.aspx");
        }

        protected void BtnOrderMenu_Click(object sender, EventArgs e)
        {

        }

        protected void BtnManufacturerMenu_Click(object sender, EventArgs e)
        {

        }
    }
}