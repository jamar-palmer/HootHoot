using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using CourseLibrary;

namespace HootHoot
{
    public partial class HomePage : System.Web.UI.Page
    {
        Admin student;
        protected void Page_Load(object sender, EventArgs e)
        {
            student = (Admin) Session["student"];
            loadData();
            getRoster();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("CourseCatalogPage.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProfilePage.aspx");
        }

        public void loadData()
        {
            getimage(student.Image);
            lblFullName.Text = student.FirstName + " " + student.LastName;
            lblName2.Text = student.FirstName + " " + student.LastName;
            lblCredits.Text = student.Credits.ToString();
            lblEmail.Text = student.Email;
            lblMajor.Text = student.Major;
        }

        public void getRoster()
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

            List<Course> ds = js.Deserialize<List<Course>>(data);

            buildDynamic(ds);

        }

        public void buildDynamic(List<Course> courseList)
        {
            String strHTML = "";
            strHTML = strHTML + "<table> <tr> <td>Program </td> <td>CRN </td> <td>Course</td> </tr>";

            for(int i = 0; i < courseList.Count; i++)
            {
                strHTML = strHTML + "<tr> <td> " + courseList[i].Program + "</td> <td> " + courseList[i].Crn + "</td> <td> " + courseList[i].Title + "</td> </tr>";
            }
            strHTML += "</table";
            currentSemester.InnerHtml = strHTML;

        }
        public void getimage(String picture)
        {
            switch (picture)
            {
                case "avatar1":
                    Image1.ImageUrl = "~/Images/avatar1.jpg";
                    break;
                case "avatar2":
                    Image1.ImageUrl = "~/Images/avatar2.jpg";
                    break;
                case "avatar3":
                    Image1.ImageUrl = "~/Images/avatar3.jpg";
                    break;
                case "avatar4":
                    Image1.ImageUrl = "~/Images/avatar4.jpg";
                    break;
                case "avatar5":
                    Image1.ImageUrl = "~/Images/avatar5.jpg";
                    break;
                case "avatar6":
                    Image1.ImageUrl = "~/Images/avatar6.jpg";
                    break;
                case "avatar7":
                    Image1.ImageUrl = "~/Images/avatar7.jpg";
                    break;
                case "avatar8":
                    Image1.ImageUrl = "~/Images/avatar8.png";
                    break;
                case "avatar9":
                    Image1.ImageUrl = "~/Images/avatar9.jpg";
                    break;
                case "avatar10":
                    Image1.ImageUrl = "~/Images/avatar10.jpg";
                    break;
                default:
                    break;
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["student"] = null;
            Response.Redirect("LoginPage.aspx");
        }
    }
}