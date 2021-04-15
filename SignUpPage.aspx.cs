using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HootHoot
{
    public partial class SignUpPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
             * login in navbar or go back
             * first last name
             * email (must be TU
             * password (make sure its at least 8 digits and has 1 number
             * birthday
             * gender
             */
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            validation();
        }

        public void validation()
        {
            //ADD ERROR TEXT TO ALL INPUT

            //check for null textboxes and blank radio buttons
            String email = Request["emailid"];
            String password = Request["password"];
            String confirm = Request["cpassword"];
            String first = Request["mem_name"];
            String last = Request["last_name"];
            String major = Request["major"];
            String credits = Request["credits"];
            String student = Request["student"];
            String admin = Request["admin"];

            //check for dropdown lists
            if (String.IsNullOrWhiteSpace(email) || String.IsNullOrWhiteSpace(password) || String.IsNullOrWhiteSpace(confirm) ||
                String.IsNullOrWhiteSpace(first) || String.IsNullOrWhiteSpace(last) || String.IsNullOrWhiteSpace(major) ||
                String.IsNullOrWhiteSpace(credits) || (String.IsNullOrWhiteSpace(student) && String.IsNullOrWhiteSpace(admin)))
            {
                //throw error
            }
            else
            {
                Response.Redirect("LoginPage.aspx");
            }

                //email validation

            }
    }
}