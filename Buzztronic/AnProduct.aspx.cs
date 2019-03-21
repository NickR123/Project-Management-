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
            //get the  number of the Product to be processed
            ProductNo = Convert.ToInt32(Session["ProductNo"]);
            if (ProductNo != -1 & IsPostBack==false)
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
            String Error = ProductCollect.ThisProduct.Valid(txtProductName.Text, txtDescription.Text, txtPrice.Text);
            //if the data is OK then add it to the objct
            if (Error == "")
            {
                //find the record to update
                ProductCollect.ThisProduct.Find(ProductNo);
                //get data entered by the user
                ProductCollect.ThisProduct.ProductName = txtProductName.Text;
                ProductCollect.ThisProduct.Description = txtDescription.Text;
                ProductCollect.ThisProduct.Price = Convert.ToDecimal(txtPrice.Text);
                ProductCollect.ThisProduct.Active = chkActive.Checked;
                
                //update the record
                ProductCollect.Update();
                //all done so redirect to the main page
                Response.Redirect("ProductDefault.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }
        void DisplayProduct()
        {
            //create an instance of Product Collection
            clsProductCollection ProductCollect = new clsProductCollection();
            //find the record to update
            ProductCollect.ThisProduct.Find(ProductNo);
            //display the data for this record
            txtProductName.Text = ProductCollect.ThisProduct.ProductName;
            txtDescription.Text = ProductCollect.ThisProduct.Description;
            txtPrice.Text = ProductCollect.ThisProduct.Price.ToString();
            chkActive.Checked = ProductCollect.ThisProduct.Active;
        }

        protected void btnOkay_Click(object sender, EventArgs e)
        {
            if (ProductNo == -1)
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

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductDefault.aspx");
        }
    }
}