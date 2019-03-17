using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectClassLibrary;


namespace Buzztronic
{
    public partial class ProductDelete : System.Web.UI.Page
    {
        // var to store the primary key value of the record to be deleted
        Int32 ProductNo;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the address to be deleted from the session object
            ProductNo = Convert.ToInt32(Session["ProductNo"]);
        }

        void DeleteProduct()
        {
            clsProductCollection ProductCollect = new clsProductCollection();
            //find the record to delete
            ProductCollect.ThisProduct.Find(ProductNo);
            //delete the record
            ProductCollect.Delete();
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            //delete the record
            DeleteProduct();
            //redirects back to the default page
            Response.Redirect("ProductDefault.aspx");
        }
    }
}