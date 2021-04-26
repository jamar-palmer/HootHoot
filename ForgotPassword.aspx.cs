using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OwlSpace
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        int question = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            Random random = new Random();
             question = random.Next(1, 4);
            generateQuestion(question);

            /*
             * email textbox
             * Ask user security question and show password
             *search or cancel
             *login options in navbar or go back
             *
             */
        }

        private void generateQuestion(int question)
        {
            if(question == 1)
            {
                lblSec.Text = "What city were you born in?";

            }
            else if(question == 2)
            {
                lblSec.Text = "What is your mother's maiden name?";

            }
            else
            {
                lblSec.Text = "What is your favorite food?";

            } 
            
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }

        protected void btnVerify_Click(object sender, EventArgs e)
        {
            if (!validation())
            {
                Response.Write("<script>alert('Please fill out both entry boxes.')</script>");

            }
            else
            {

                String url = "https://localhost:44358/api/Course/Recover/";
                url += question + "/" + txtAnswer.Text + "/" + txtEmailEnter.Text;
                WebRequest request = WebRequest.Create(url);
                WebResponse response = request.GetResponse();
                Stream theDataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(theDataStream);
                String data = reader.ReadToEnd();
                reader.Close();
                response.Close();

                Response.Write("<script>alert('" + data + "')</script>");
            }
        }

        public bool validation()
        {
            if(String.IsNullOrWhiteSpace(txtAnswer.Text) || String.IsNullOrWhiteSpace(txtEmailEnter.Text)){
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}