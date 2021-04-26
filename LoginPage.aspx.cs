using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CourseLibrary;

namespace HootHoot
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //tu email login
            //password
            //forgot password link
            //login button
            //creAte account button
        }

        protected void Login_Button_Click(object sender, EventArgs e)
        {
            String login = Request["loginText"];
            String pw = Request["pwText"];

            if(validation(login, pw))
            {
                String url = "https://localhost:44358/api/Course/Login/";
                url = url + login + "/" + pw;

                WebRequest request = WebRequest.Create(url);
                WebResponse response = request.GetResponse();
                Stream theDataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(theDataStream);
                String data = reader.ReadToEnd();
                reader.Close();
                response.Close();

                JavaScriptSerializer js = new JavaScriptSerializer();
                Admin ds = js.Deserialize<Admin>(data);

                String oo = ds.FirstName;
                if (ds.FirstName == null)
                {
                    Response.Write("<script>alert('Incorrect Username or password. Please Try Again.')</script>");
                }

                else if (ds.UserType.Equals("Student"))
                {
                    Session["student"] = ds;
                    Response.Redirect("HomePage.aspx");
                }
                else
                {
                    Session["admin"] = ds;
                    Response.Redirect("AdminPage.aspx");
                }
            }
            else
            {
                Response.Write("<script>alert('Please Enter Both Fields.')</script>");
            }
            


        }

        public bool validation(String email, String pw)
        {
            if (String.IsNullOrWhiteSpace(email) || String.IsNullOrWhiteSpace(pw))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        protected void Register_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUpPage.aspx");
        }

        protected void Forgot_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("ForgotPassword.aspx");
        }
    }

}