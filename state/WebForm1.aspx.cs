using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace state
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Initialize the counter when the page is loaded for the first time
                Session["Counter"] = 0;
            }

            // Update the label text with the current counter value
            lblCounterValue.Text = Session["Counter"].ToString();
        }

        protected void btnIncrement_Click(object sender, EventArgs e)
        {
            // Increment the counter when the button is clicked and update Session state
            int counter = Convert.ToInt32(Session["Counter"]);
            counter++;
            Session["Counter"] = counter;

            // Update the label text with the updated counter value
            lblCounterValue.Text = Session["Counter"].ToString();
        }
    }
}