using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SampleASPNETProject.DataModels;
using SampleASPNETProject.DataAccessLayer;


namespace SampleASPNETProject
{
    public partial class Confirmation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CustomerData"] != null)
            {
                Customer customer = (Customer)Session["CustomerData"];

                lblFirstName.Text = customer.firstName;
                lblMiddleName.Text = customer.middleName;
                lblLastName.Text = customer.lastName;
                lblAdress.Text = customer.address;
                lblAPT.Text = customer.adress2;
                lblCity.Text = customer.city;
                lblState.Text = customer.state;
                lblZip.Text = customer.zip.ToString();
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }
        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            CustomerTier customerTier = new CustomerTier();
            Customer customer = (Customer)Session["CustomerData"];

            customerTier.insertCustomer(customer);

            Session["CustomerData"] = null;

            Response.Redirect("CustomerData.aspx");
        }


    }
}