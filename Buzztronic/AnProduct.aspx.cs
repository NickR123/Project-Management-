using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectClassLibrary;

namespace Buzztronic
{
    public partial class AnProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //function for creating new records
        void Add()
        {
            clsProductCollection ProductCollect = new clsProductCollection();
            String Error = ProductCollect.ThisProduct.Valid(txtProductName.Text, txtDescription.Text, txtPrice.Text);
            //if the data is OK then add it to the objct
            if (Error == "")
            {
                ProductCollect.ThisProduct.ProductName = txtProductName.Text;
                ProductCollect.ThisProduct.Description = txtDescription.Text;
                ProductCollect.ThisProduct.Price = Convert.ToDecimal(txtPrice.Text);
                ProductCollect.ThisProduct.Active = chkActive.Checked;
                //add the record
                ProductCollect.Add();
                //all done so redirect back to the main page
                Response.Redirect("ProductDefault.aspx");
            }
            else
            {
                lblError.Text = "There were problems with the data entered" + Error;
            }
        }

        protected void btnOkay_Click(object sender, EventArgs e)
        {
            //add the new record
            Add();
            //all done so go back to the main page
            Response.Redirect("ProductDefault.aspx");
        }
    }
}