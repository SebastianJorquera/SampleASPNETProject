using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SampleASPNETProject.DataModels;

namespace SampleASPNETProject
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CustomerData"] != null)
            {
                Customer customer = (Customer)Session["CustomerData"];

                txtFirstName.Text = customer.firstName;
                txtMiddleName.Text = customer.middleName;
                txtLastName.Text = customer.lastName;
                txtAdress.Text = customer.address;
                txtAPT.Text = customer.adress2;
                txtCity.Text = customer.city;
                txtState.Text = customer.state;
                txtZip.Text = customer.zip.ToString();

                Session["CustomerData"] = null;
            }
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {

            Customer theCustomer = new Customer();
            theCustomer.firstName = txtFirstName.Text;
            theCustomer.middleName = txtMiddleName.Text;
            theCustomer.lastName = txtLastName.Text;
            theCustomer.address = txtAdress.Text;
            theCustomer.adress2 = txtAPT.Text;
            theCustomer.city = txtCity.Text;
            theCustomer.state = txtState.Text;
            theCustomer.zip = int.Parse(txtZip.Text);

            Session["CustomerData"] = theCustomer;

            Response.Redirect("Confirmation.aspx");
           
        }
    }
}