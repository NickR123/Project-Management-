using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ManufacturerClassLibrary;

public partial class AnManufacturer : System.Web.UI.Page
{
    //Variable to store the manufacturer number
    Int32 ManufacturerNo;

    //Event handler for the page load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //Get the Manufacturer mumber from the session object
        ManufacturerNo = Convert.ToInt32(Session["ManufacturerNo"]);
        //If this is the first time the page has loaded
        if (IsPostBack == false)
        {

            //If we are not adding a new record
            if (ManufacturerNo != -1)
            {
                //Update the fields on the page with the data from the record
                DisplayManufacturer();
            }
            else//This is a new record
            {
                //Set the date to todays date
                txtDateAdded.Text = DateTime.Today.Date.ToString("dd/MM/yyyy"); ;
            }
        }
        
    }
    //function for creating new records
    void Add()
    {
        
        //Create an instance of the manufacturer class
        clsManufacturerCollection Manufacturer = new clsManufacturerCollection();
        //Use the objects validation method to test the data
        String Error = Manufacturer.ThisManufacturer.Valid(txtManufacturerNo.Text, txtManufacturerName.Text, txtTown.Text, txtPostCode.Text, txtDateAdded.Text, txtAddress.Text, txtTelephoneNo.Text, txtEmail.Text);
        //If there is no error message
        if (Error == "")
        {
            Manufacturer.ThisManufacturer.ManufacturerName = txtManufacturerName.Text;
            //Set the town property
            Manufacturer.ThisManufacturer.Town = txtTown.Text;
            //set the telephone number property
            Manufacturer.ThisManufacturer.TelephoneNo = txtTelephoneNo.Text;
            //Set the email property 
            Manufacturer.ThisManufacturer.Email = txtEmail.Text;
            //Set the Post Code property
            Manufacturer.ThisManufacturer.PostCode = txtPostCode.Text;
            //set the date added property
            Manufacturer.ThisManufacturer.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            //Set the check property
            Manufacturer.ThisManufacturer.Check = chkCheck.Checked;
            //Update the record with the new data
            Manufacturer.Add();
            //All done so redirect back to the main page
            Response.Redirect("Default.aspx");
        }
        else
        {
            lblError.Text = "There were problems with the data entered" + Error;
        }

    }
    //function for updating records
    void Update()
    {
        
        
        //Create an instance of the manufacturer class
        clsManufacturerCollection Manufacturer = new clsManufacturerCollection();
        //Use the objects validation method to test the data
       String Error = Manufacturer.ThisManufacturer.Valid(txtManufacturerNo.Text, txtManufacturerName.Text, txtTown.Text, txtPostCode.Text, txtDateAdded.Text, txtAddress.Text, txtTelephoneNo.Text, txtEmail.Text);
        //If there is no error message
        if (Error == "")
        {
            //Find the record to be updated
            Manufacturer.ThisManufacturer.Find(ManufacturerNo);
            //Set the manufacturer name property
            Manufacturer.ThisManufacturer.ManufacturerName = txtManufacturerName.Text;
            //Set the town property
            Manufacturer.ThisManufacturer.Town = txtTown.Text;
            //set the telephone number property
            Manufacturer.ThisManufacturer.TelephoneNo = txtTelephoneNo.Text;
            //Set the email property 
            Manufacturer.ThisManufacturer.Email = txtEmail.Text;
            //Set the Post Code property
            Manufacturer.ThisManufacturer.PostCode = txtPostCode.Text;
            //set the date added property
            Manufacturer.ThisManufacturer.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            //Set the check property
            Manufacturer.ThisManufacturer.Check = chkCheck.Checked;
            //Update the record with the new data
            Manufacturer.Update();
            //All done so redirect back to the main page
            Response.Redirect("Default.aspx");
        }
        else
        {
            lblError.Text = "There were problems with the data entered" + Error;
        }
    }
    //This function displays the data for manufacturer on the web form
    void DisplayManufacturer()
    {
        //create an instance of my manufacturer class
        clsManufacturerCollection MyManufacturer = new clsManufacturerCollection();
        //Find the record we want to display
        MyManufacturer.ThisManufacturer.Find(ManufacturerNo);
        //display the manufacturer name 
        txtManufacturerName.Text = MyManufacturer.ThisManufacturer.ManufacturerNo.ToString();
        //Display the address
        txtAddress.Text = MyManufacturer.ThisManufacturer.Address;
        //Display the town
        txtTown.Text = MyManufacturer.ThisManufacturer.Town;
        //Display the post code
        txtPostCode.Text = MyManufacturer.ThisManufacturer.PostCode;
        //Display the telephone number
        txtTelephoneNo.Text = MyManufacturer.ThisManufacturer.TelephoneNo;
        //Display the email
        txtEmail.Text = MyManufacturer.ThisManufacturer.Email;
        //Disply the date added
        txtDateAdded.Text = MyManufacturer.ThisManufacturer.DateAdded.ToString("dd/MM/yyyy");
        //Display the check state
        chkCheck.Checked = MyManufacturer.ThisManufacturer.Check;
       
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main page
        Response.Redirect("Default.aspx");

    }
    //This is the event handler for the OK button
    protected void btnOk_Click1(object sender, EventArgs e)
    {
        if (ManufacturerNo == -1)
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
}

        