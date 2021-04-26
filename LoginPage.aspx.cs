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
            if(Request.Cookies["passwordHoot"] != null && !IsPostBack)
            {
                HttpCookie cookie = Request.Cookies["passwordHoot"];
                txtPass.Text = cookie.Value.ToString();
            }
        }

        protected void Login_Button_Click(object sender, EventArgs e)
        {
            String login = Request["loginText"];
            String pw = txtPass.Text;

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
                    if (chkRemember.Checked)
                    {
                        writeCookie(pw);
                    }
                    else
                    {
                        removeCookie();
                    }
                    Session["student"] = ds;
                    Response.Redirect("HomePage.aspx");
                }
                else
                {
                    if (chkRemember.Checked)
                    {
                        writeCookie(pw);
                    }
                    else
                    {
                        removeCookie();
                    }
                    Session["admin"] = ds;
                    Response.Redirect("AdminPage.aspx");
                }
            }
            else
            {
                Response.Write("<script>alert('Please Enter Both Fields.')</script>");
            }
        }

        public void writeCookie(String pw)
        {
            HttpCookie password = new HttpCookie("passwordHoot");
            password.Value = pw;
            Response.Cookies.Add(password);

        }

        public void removeCookie()
        {

            HttpCookie password = HttpContext.Current.Request.Cookies["passwordHoot"];
            if (password != null)
            {
                password.Expires = DateTime.Now.AddDays(-10);
                password.Value = null;
                HttpContext.Current.Response.SetCookie(password);
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

        protected void txtPass_TextChanged(object sender, EventArgs e)
        {
           
        }
    }

}