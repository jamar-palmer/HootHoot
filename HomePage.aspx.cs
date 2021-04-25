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

        public void getRoster()
        {
            String url = "https://localhost:44358/api/Course/Roster/";
            url = url + student.Email;

            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream theDataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(theDataStream);
            String data = reader.ReadToEnd();
            reader.Close();
            response.Close();

            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Course> ds = js.Deserialize<List<Course>>(data);

            



        }

        public void buildDynamic()
        {
            String strHTML = "";
            strHTML = strHTML + "<table> <tr> <td>Program </td> <td>CRN </td> <td>Course</td> </tr> </table>";
        }
    }
}