using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using CourseLibrary;
using System.Web.UI.WebControls;
using System.Data;

namespace OwlSpace
{
    public partial class AdminPage : System.Web.UI.Page
    {
        UserService.Users proxy;
        Admin admin;
        DataSet ds;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            proxy = new UserService.Users();
            if (!IsPostBack)
            {
                getCourses();

            }
            admin = (Admin)Session["admin"];
            lblName.Text = admin.FirstName + " " + admin.LastName;

        }

        public void getCourses()
        {
             ds = proxy.adminView();
            gvCourses.DataSource = ds;
            gvCourses.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //AJAX
            Panel1.Visible = true;
            hide();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            CheckBox check;
            int count = gvCourses.Rows.Count;    
            for(int i = 0; i < count; i++)
            {
                check = (CheckBox) gvCourses.Rows[i].FindControl("chkDelete");
                String asdasd = gvCourses.Rows[i].Cells[3].Text;
                if (check.Checked)
                {
                    String program = gvCourses.Rows[i].Cells[1].Text;
                    String title = gvCourses.Rows[i].Cells[3].Text;
                    String crn = gvCourses.Rows[i].Cells[2].Text;
                    

                    //delete checked course
                    Boolean result = proxy.deleteCourse(title, program, crn);
                    if (result)
                    {
                        Response.Write("<script>alert('Course Delete Success.')</script>");
                        getCourses();
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
                String repeat = ddlRepeat.Text;
                String semester = Request["semester"];
                String prereq = Request["prereq"];
                String description = Request["description"];
                CheckBox check = chkPreReq;

                bool prereqCheck = true;

                if (!check.Checked)
                {
                    prereq = "0";
                }
                else
                {
                    int number;
                    bool attempt = int.TryParse(prereq, out number);
                    if (attempt)
                    {
                        prereqCheck = proxy.fetchPrereq(prereq);
                    }
                    else
                    {
                        prereqCheck = false;
                    }
                   
                }

                if (prereqCheck)
                {
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
                    Response.Write("<script>alert('Course Pre-req not found.')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Enter all fields')</script>");
            }
            show();
        }

        public bool validation()
        {

            String program = Request["program"];
            String hours = Request["hours"];
            String title = Request["title"];
            String crn = Request["crn"];
            String repeat = ddlRepeat.Text;
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

        protected void btnMod_Click(object sender, EventArgs e)
        {
            pnlMod.Visible = true;
            hide();
        }

        protected void btnCancelAdd_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            show();
        }

        protected void btnCancelMod_Click(object sender, EventArgs e)
        {
            pnlMod.Visible = false;
            show();
        }
        protected void btnModify_Click(object sender, EventArgs e)
        {
            bool checking = validation();

            if (checking)
            {
                String program = Request["program"];
                String hours = Request["hours"];
                String title = Request["title"];
                String crn = Request["crn"];
                String repeat = ddlRepeat.Text;
                String semester = Request["semester"];
                String prereq = Request["prereq"];
                String description = Request["description"];
                CheckBox check = chkPreReq;


                if (!check.Checked)
                {
                    prereq = "0";
                }

                Boolean result = proxy.modCourse(title, description, hours, program, crn, prereq, repeat, semester);

                if (result)
                {
                    Response.Write("<script>alert('Course Modification Success.')</script>");
                    Panel1.Visible = false;

                    getCourses();
                }
                else
                {
                    Response.Write("<script>alert('Course Modification Failed.')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Enter all fields')</script>");
            }

            show();
        }

        public void hide()
        {
            btnMod.Visible = false;
            btnAdd.Visible = false;
            btnDelete.Visible = false;
        }

        public void show()
        {
            btnMod.Visible = true;
            btnAdd.Visible = true;
            btnDelete.Visible = true;
        }

        protected void gvCourses_PageIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void gvCourses_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvCourses.PageIndex = e.NewPageIndex;
            gvCourses.DataSource = ds;
            gvCourses.DataBind();
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["admin"] = null;
            Response.Redirect("LoginPage.aspx");
        }

        protected void gvCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}