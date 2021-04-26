using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net;
using CourseLibrary;
using System.Web.Script.Serialization;


namespace HootHoot
{
    public partial class SignUpPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            bool check = validation();
            if (check)
            {
                //if user or administrator
                String student = Request["student"];

                String url = "https://localhost:44358/api/Course/Register/";

                String email = Request["emailid"];
                String password = Request["password"];
                String first = Request["mem_name"];
                String last = Request["last_name"];
                String question1 = Request["question1"];
                String question2 = Request["question2"];
                String question3 = Request["question3"];
                if (student.Equals("Student"))
                {
                    String major = Request["major"];
                    String credits = Request["credit"];
                    String image = DropDownList1.SelectedValue;

                    url = url + first + "/" + last + "/" + password + "/" + email + "/" + image + "/" + major + "/" + credits + "/" + question1 + "/" + question2 + "/" + question3 + "/" + student;                   

                }
                else
                {
                    url = url + first + "/" + last + "/" + password + "/" + email + "/" + question1 + "/" + question2 + "/" + question3 + "/" + "Admin";

                }

                //use POST
                    WebRequest request = WebRequest.Create(url);
                    WebResponse response = request.GetResponse();
                    Stream theDataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(theDataStream);
                    String data = reader.ReadToEnd();
                    reader.Close();
                    response.Close();
                    if (data.Equals("true"))
                    {
                        Response.Write("<script>alert('Registration Successful ')</script>");
                        Response.Redirect("LoginPage.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('Registration Failed. Please Try Again.')</script>");
                    }                
            }
        }        

        public bool validation()
        {
            //ADD ERROR TEXT TO ALL INPUT

            //check for null textboxes and blank radio buttons
            String email = Request["emailid"];
            String password = Request["password"];
            String confirm = Request["cpassword"];
            String first = Request["mem_name"];
            String last = Request["last_name"];
            String major = Request["major"];
            String credits = Request["credit"];

            String question1 = Request["question1"];
            String question2 = Request["question2"];
            String question3 = Request["question3"];

            //check for dropdown lists
            if (String.IsNullOrWhiteSpace(email) || String.IsNullOrWhiteSpace(password) || String.IsNullOrWhiteSpace(confirm) ||
                String.IsNullOrWhiteSpace(first) || String.IsNullOrWhiteSpace(last) || String.IsNullOrWhiteSpace(major) ||
                String.IsNullOrWhiteSpace(credits) || String.IsNullOrWhiteSpace(question1) || String.IsNullOrWhiteSpace(question2) ||
                String.IsNullOrWhiteSpace(question3))
            {
                return false;
            }
            else
            {
                return true;
            }

            }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //AJAX C
            string picture = DropDownList1.SelectedValue;

            switch (picture)
            {
                case "avatar1":
                    imgAvatar.ImageUrl = "~/Images/avatar1.jpg";
                    break;
                case "avatar2":
                    imgAvatar.ImageUrl = "~/Images/avatar2.jpg";
                    break;
                case "avatar3":
                    imgAvatar.ImageUrl = "~/Images/avatar3.jpg";
                    break;
                case "avatar4":
                    imgAvatar.ImageUrl = "~/Images/avatar4.jpg";
                    break;
                case "avatar5":
                    imgAvatar.ImageUrl = "~/Images/avatar5.jpg";
                    break;
                case "avatar6":
                    imgAvatar.ImageUrl = "~/Images/avatar6.jpg";
                    break;
                case "avatar7":
                    imgAvatar.ImageUrl = "~/Images/avatar7.jpg";
                    break;
                case "avatar8":
                    imgAvatar.ImageUrl = "~/Images/avatar8.png";
                    break;
                case "avatar9":
                    imgAvatar.ImageUrl = "~/Images/avatar9.jpg";
                    break;
                case "avatar10":
                    imgAvatar.ImageUrl = "~/Images/avatar10.jpg";
                    break;
                default:
                    break;
            }
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }
    }
}