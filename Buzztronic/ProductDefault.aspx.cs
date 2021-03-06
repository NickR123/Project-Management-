﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectClassLibrary;

namespace Buzztronic
{
    public partial class ProductDefault : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                //update the list box
                DisplayProduct();
            }
        }
        void DisplayProduct()
        {
            //create an instance of the Product collection
            clsProductCollection Product = new clsProductCollection();
            //set the source to the list of Product in the collection
            lstProduct.DataSource = Product.ProductList;
            //get the primary key
            lstProduct.DataValueField = "ProductNo";
            //set the data field to display
            lstProduct.DataTextField = "ProductName";
            //bind data to the list
            lstProduct.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Session["ProductNo"] = -1;
            //redirects to the data entry page
            Response.Redirect("AnProduct.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 ProductNo;
            //if a record has been selected from the list
            if (lstProduct.SelectedIndex != -1)
            {
                //get the primary key value of the record to be deleted
                ProductNo = Convert.ToInt32(lstProduct.SelectedValue);
                //store the data in the session object
                Session["ProductNo"] = ProductNo;
                //redirect to the delete page
                Response.Redirect("ProductDelete.aspx");
            }
            else // if no record has been selected
            {
                //display an error
                lblError.Text = "Please select a record to delete from the list";
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the primary key value
            Int32 ProductNo;
            //if a record has been selected from the list
            if (lstProduct.SelectedIndex != -1)
            {
                //get the primary key value of the record to edit
                ProductNo = Convert.ToInt32(lstProduct.SelectedValue);
                //store the data in the session object
                Session["ProductNo"] = ProductNo;
                //redirect to the edit page
                Response.Redirect("AnProduct.aspx");
            }
            else//if no record has been selected
            {
                //display an error
                lblError.Text = "Please select a record to delete from the list";
            }
        }

        protected void BtnProductReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainMenu.aspx");
        }

      

        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            //display all addresses
            DisplayProductName("");
        }


        Int32 DisplayProductName(string ProductNameFilter)
        {
            Int32 ProductNo; // var to store the primary key
            string ProductName; // var to store the surname
            
                              //create an instance of the address collection class
            clsProductCollection Product = new clsProductCollection();
            Product.ReportByProductName(ProductNameFilter);
            Int32 RecordCount; // var to store the count of records
            Int32 Index = 0; // var to store the index for the loop
            RecordCount = Product.Count; //get the count of records
            lstProduct.Items.Clear();
            while (Index < RecordCount) // while there are records to process
            {
                ProductNo = Product.ProductList[Index].ProductNo; //get the primary key
                ProductName = Product.ProductList[Index].ProductName; //get the Surnanme
                
                                                                               //create a new entry for the listbox
                ListItem NewEntry = new ListItem(ProductName, ProductNo.ToString());
                lstProduct.Items.Add(NewEntry);
                Index++;

            }
            return RecordCount;//return the count of records found
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            
            
                //display the player matching the text in the surname box
                DisplayProductName(txtProductName.Text);
            
        }
    }

}