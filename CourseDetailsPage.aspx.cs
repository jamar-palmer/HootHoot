using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using CourseLibrary;

namespace OwlSpace
{
    public partial class CourseDetailsPage : System.Web.UI.Page
    {
        UserService.Users proxy;
        String program = " ";
        String title = " ";
        String crn = " ";
        Admin student;
        protected void Page_Load(object sender, EventArgs e)
        {
            proxy = new UserService.Users();
            if(Session["program"]!= null)
            {
                 program = Session["program"].ToString();
                 title = Session["title"].ToString();
                 crn = Session["crn"].ToString();
                student = (Admin) Session["student"];

                //decrypt the transfered file
                String secureTitle = proxy.decrypt("b14ca5898a4e4133bbce2ea2315a1916", Session["secureInfo"].ToString());

                DataSet ds = proxy.detailsView(title, program, crn);
                lblCreds.Text = ds.Tables[0].Rows[0]["CreditHours"].ToString();
                lblDescript.Text = ds.Tables[0].Rows[0]["Description"].ToString();
                lblRepeatability.Text = ds.Tables[0].Rows[0]["Repeatability"].ToString();
                lblSemester.Text =  ds.Tables[0].Rows[0]["SemesterOffering"].ToString();

                String titling = ds.Tables[0].Rows[0]["Program"].ToString() + " " +  ds.Tables[0].Rows[0]["CourseNumber"].ToString() + ": " +
                    ds.Tables[0].Rows[0]["Title"].ToString();
                lblTitleProgram.Text = titling;
                loadPreReq(ds.Tables[0].Rows[0]["PreReq"].ToString());

                DataSet ds2 = proxy.getFeedback(title, program, crn, student.Email);

                loadFeedback(ds2);
            }
        }

        protected void btnCatalogReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("CourseCatalogPage.aspx");
        }

        protected void btnAddRoster_Click(object sender, EventArgs e)
        {
            String url = "https://localhost:44358/api/Course/Roster/";
            url = url + title + "/" + program + "/" + crn + "/"  + student.Email;      

            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream theDataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(theDataStream);
            String data = reader.ReadToEnd();
            reader.Close();
            response.Close();

            if (data.Equals("true"))
            {
                Response.Write("<script>alert('Course Add Success.')</script>");
            }
            else
            {
                Response.Write("<script>alert('Course Add Failed.')</script>");
            }
            
        }

        protected void btnFeedback_Click(object sender, EventArgs e)
        {
            txtFeedback.Visible = true;
            btnSubmit.Visible = true;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            
            Boolean check = proxy.addFeedback(title, program, crn, student.Email, txtFeedback.Text);

            if (check)
            {
                Response.Write("<script>alert('Course Add Success.')</script>");
            }
            else
            {
                Response.Write("<script>alert('Course NOOOOOOOOOOOOOOOOOO Success.')</script>");
            }
            txtFeedback.Visible = false;
            btnSubmit.Visible = false;
        }

        public void loadFeedback(DataSet dataset)
        {
            for(int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                FeedbackControl feedbackControl = (FeedbackControl)LoadControl("FeedbackControl.ascx");
                feedbackControl.Name = dataset.Tables[0].Rows[i]["FirstName"].ToString();
                feedbackControl.Date = dataset.Tables[0].Rows[i]["DatePosted"].ToString();
                feedbackControl.Content = dataset.Tables[0].Rows[i]["Content"].ToString();

                Form.Controls.Add(feedbackControl);
            }
        }

        public void loadPreReq(String prerequisite)
        {
            if(!(prerequisite == "0"))
               {
                String result = proxy.getPreReq(prerequisite);
                lblPreRequis.Text = result;

            }
            else
            {
                lblPreRequis.Text = "No Pre-requisites needed.";
            }

       }
    }
}