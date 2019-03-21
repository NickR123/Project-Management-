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
        //variable to store the primary key with page level scope
        Int32 ProductNo;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the  number of the Staff to be processed
            ProductNo = Convert.ToInt32(Session["ProductNo"]);
            if (StaffNo != -1)
            {
                //display the current data for the record
                DisplayProduct();
            }
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
        //function for updating records
        void Update()
        {
            clsProductCollection ProductCollect = new clsProductCollection();
            String Error = ProductCollect.ThisProduct.Valid(txtProductName.Text, txtDescription.Text, txtPrice.Text, txtActive.Text);
            //if the data is OK then add it to the objct
            if (Error == "")
            {
                //find the record to update
                ProductCollect.ThisProduct.Find(ProductNo);
                //get data entered by the user
                ProductCollect.ThisProduct.ProductName = TxtProductName.Text;
                ProductCollect.ThisProduct.Description = TxtDescription.Text;
                ProductCollect.ThisProduct.Price = TxtPrice.Text;
                ProductCollect.ThisProduct.Active = Convert.ToInt32(TxtActive.Text);
                
                //update the record
                ProductCollect.Update();
                //all done so redirect to the main page
                Response.Redirect("ProductDefault.aspx");
            }
            else
            {
                //report an error
                LblError.Text = "There were problems with the data entered " + Error;
            }
        }
        void DisplayProduct()
        {
            //create an instance of staff collect
            clsProductCollection ProductCollect = new clsProductCollection();
            //find the record to update
            ProductCollect.ThisProduct.Find(StaffNo);
            //display the data for this record
            TxtProductName.Text = ProductCollect.ThisProduct.ProductName;
            TxtDescription.Text = ProductCollect.ThisProduct.Description;
            TxtPrice.Text = ProductCollect.ThisProduct.Price;
            TxtActive.Text = ProductCollect.ThisProduct.Active;
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