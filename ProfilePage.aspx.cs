using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using CourseLibrary;

namespace OwlSpace
{
    public partial class ProfilePage : System.Web.UI.Page
    {

        UserService.Users proxy;
        Admin student;
        List<Course> ds;

        protected void Page_Load(object sender, EventArgs e)
        {
            proxy = new UserService.Users();
            student = (Admin)Session["student"];
            if (!IsPostBack)
            {
                ddlSemester.DataSource = proxy.getSemesters();
                ddlSemester.DataTextField = "SemesterOffering";
                ddlSemester.DataValueField = "SemesterOffering";
                ddlSemester.DataBind();

                Session["ddl"] = ddlSemester.SelectedValue;
                loadRegistration();
               
            }
            

        }

        public void loadRegistration()
        {
            String url = "https://localhost:44358/api/Course/Roster";

            JavaScriptSerializer js = new JavaScriptSerializer();
            String jsonFile = js.Serialize(student);

            WebRequest request = WebRequest.Create(url);
            request.Method = "POST";
            request.ContentLength = jsonFile.Length;
            request.ContentType = "application/json";

            StreamWriter writer = new StreamWriter(request.GetRequestStream());
            writer.Write(jsonFile);
            writer.Flush();
            writer.Close();

            WebResponse response = request.GetResponse();
            Stream theDataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(theDataStream);
            String data = reader.ReadToEnd();
            reader.Close();
            response.Close();

            ds = js.Deserialize<List<Course>>(data);
            if(ds != null) { 
            buildRoster(ds);
            }
            else
            {
                Label label = new Label();
                label.Text = "Register for classes through catalog";
                coursesDiv.Controls.Add(label);
            }
        }

        public void buildRoster(List<Course> courseList)
        {
            if (courseList.Count == 0)
            {
                Label label = new Label();
                label.Text = "No courses for this semster";
                coursesDiv.Controls.Add(label);
            }
            else
            { 

                for (int i = 0; i < courseList.Count; i++)
                {
                    CatalogControl catalogControl = (CatalogControl)LoadControl("CatalogControl.ascx");
                    catalogControl.Program = courseList[i].Program;
                    catalogControl.CRN = courseList[i].Crn;
                    catalogControl.CreditHours = courseList[i].CreditHours;
                    catalogControl.Title = courseList[i].Title;
      
                    coursesDiv.Controls.Add(catalogControl);
                }
            }
        }

        protected void ddlSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["ddl"] = ddlSemester.SelectedValue;

            String url = "https://localhost:44358/api/Course/SemesterUpdate/";
            url += student.Email + "/" + Session["ddl"].ToString();

            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream theDataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(theDataStream);
            String data = reader.ReadToEnd();
            reader.Close();
            response.Close();
            JavaScriptSerializer js = new JavaScriptSerializer();
            ds = js.Deserialize<List<Course>>(data);

            buildRoster(ds);
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            String email = student.Email;
            proxy.removeRoster(email);

            Response.Redirect("HomePage.aspx");
        }
    }
}