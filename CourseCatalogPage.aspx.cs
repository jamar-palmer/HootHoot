using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace OwlSpace
{
    public partial class CourseCatalogPage : System.Web.UI.Page
    {

        UserService.Users proxy;

        protected void Page_Load(object sender, EventArgs e)
        {
            proxy = new UserService.Users();
            if (!IsPostBack)
            {
                getCatalog();
            }
            
            
        }

        public void getCatalog()
        {
            DataSet ds  = proxy.catalogView();
            rptCourses.DataSource = ds;
            rptCourses.DataBind();
        }

        protected void rptCourses_ItemCommand(object source, System.Web.UI.WebControls.RepeaterCommandEventArgs e)
        {
            int rowIndex = e.Item.ItemIndex;
            Label program = (Label)rptCourses.Items[rowIndex].FindControl("lblProgram");
            LinkButton title = (LinkButton)rptCourses.Items[rowIndex].FindControl("lnkTitle");
            Label crn = (Label)rptCourses.Items[rowIndex].FindControl("lblCRN");


            Session["crn"] = crn.Text;
            Session["program"] = program.Text;
            Session["title"] = title.Text;

            //encryption for secure transfer of data
            Session["secureInfo"] = proxy.encrypt("b14ca5898a4e4133bbce2ea2315a1916", title.Text);

            Response.Redirect("CourseDetailsPage.aspx");
        }
    }
}