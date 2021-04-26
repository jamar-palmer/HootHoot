using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace OwlSpace
{
    public partial class AdminPage : System.Web.UI.Page
    {
        UserService.Users proxy;

        protected void Page_Load(object sender, EventArgs e)
        {
            proxy = new UserService.Users();
            getCourses();
        }

        public void getCourses()
        {
            DataSet ds = proxy.adminView();
            gvCourses.DataSource = ds;
            gvCourses.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //AJAX
            Panel1.Visible = true;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int count = gvCourses.Rows.Count;    
            for(int i = 0; i < count; i++)
            {
                CheckBox check;
                check = (CheckBox) gvCourses.Rows[i].FindControl("chkDelete");
                if (check.Checked)
                {
                    String program = gvCourses.Rows[i].Cells[2].Text;
                    String title = gvCourses.Rows[i].Cells[3].Text;
                    String crn = gvCourses.Rows[i].Cells[4].Text;
                    

                    //delete checked course
                    Boolean result = proxy.deleteCourse(program, title, crn);
                    if (result)
                    {
                        Response.Write("<script>alert('Course Delete Success.')</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('Course Delete Failed.')</script>");
                    }
                

            }
            }
        }

        protected void btnAddCourse_Click(object sender, EventArgs e)
        {
            

            bool checking = validation();

            if (checking)
            {
                String program = Request["program"];
                String hours = Request["hours"];
                String title = Request["title"];
                String crn = Request["crn"];
                String repeat = Request["repeat"];
                String semester = Request["semester"];
                String prereq = Request["prereq"];
                String description = Request["description"];
                CheckBox check = chkPreReq;


                if (!check.Checked)
                {
                    prereq = "0";
                }

                Boolean result = proxy.addCourse(title, description, hours, program, crn, prereq, repeat, semester);

                if (result)
                {
                    Response.Write("<script>alert('Course Add Success.')</script>");
                    Panel1.Visible = false;

                    getCourses();
                }
                else
                {
                    Response.Write("<script>alert('Course Add Failed.')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Enter all fields')</script>");
            }  
        }

        public bool validation()
        {

            String program = Request["program"];
            String hours = Request["hours"];
            String title = Request["title"];
            String crn = Request["crn"];
            String repeat = Request["repeat"];
            String semester = Request["semester"];
            String prereq = Request["prereq"];
            String description = Request["description"];
            CheckBox check = chkPreReq;

            //check for dropdown lists
            if (String.IsNullOrWhiteSpace(program) || String.IsNullOrWhiteSpace(hours) || String.IsNullOrWhiteSpace(title) ||
                String.IsNullOrWhiteSpace(crn) || String.IsNullOrWhiteSpace(repeat) || String.IsNullOrWhiteSpace(semester) ||
                (check.Checked && String.IsNullOrWhiteSpace(prereq)) || String.IsNullOrWhiteSpace(description))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}