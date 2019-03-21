using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ManufacturerClassLibrary;

public partial class _Default : System.Web.UI.Page
{
    //This function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //If this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //Update the list box 
            DisplayManufacturers();
        }

    }
    void DisplayManufacturers()
    {
        //Create an instance of the manufacturer collection
        clsManufacturerCollection Manufacturers = new clsManufacturerCollection();
        //Set the data source to the list of manufacturer in the collection 
        lstManufacturers.DataSource = Manufacturers.ManufacturerList;
        //Set the name data of the primary key
        lstManufacturers.DataValueField = "ManufacturerNo";
        //Bind the data to the list 
        lstManufacturers.DataBind();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //Store into the session object to indicate this is a new record
        Session["ManufacturerNo"] = -1;
        //Redirect to the data entry page
        Response.Redirect("AnManufacturer.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //Variable to store the primary key value of the record to be edited  
        Int32 ManufacturerNo;
        //If a record has been selected from the list 
        if (lstManufacturers.SelectedIndex != -1)
        {
            //Get the primary key value of the rercord to delete 
            ManufacturerNo = Convert.ToInt32(lstManufacturers.SelectedValue);
            //Store the data in the session object 
            Session["ManufacturerNo"] = ManufacturerNo;
            //Redirect to the edit page
            Response.Redirect("AnManufacturer.aspx");
        }
        else//If no record has been selected 
        {
            //Display an error 
            lblError.Text = "Please select a record to edit from the list";
        }

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //Variable to store the primary key value of the record to be deleted 
        Int32 ManufacturerNo;
        //If a record has been selected from the list 
        if (lstManufacturers.SelectedIndex != -1)
        {
            //Get the primary key value of the rercord to delete 
            ManufacturerNo = Convert.ToInt32(lstManufacturers.SelectedValue);
            //Store the data in the session object 
            Session["ManufacturerNo"] = ManufacturerNo;
            //Redirect to the data entry page
            Response.Redirect("DeleteManufacturer.aspx");
        }
        else//If no record has been selected 
        {
            //Display an error 
            lblError.Text = "Please select a record to delete from the list";
        }
    }
    //event handler for the apply button
    protected void btnApply_Click(object sender, EventArgs e)
    {

    }
    //event hanlder for the display all button
    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {

    }
}

