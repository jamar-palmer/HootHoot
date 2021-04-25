using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace OwlSpace
{
    public partial class CourseDetailsPage : System.Web.UI.Page
    {
        UserService.Users proxy;
        protected void Page_Load(object sender, EventArgs e)
        {
            proxy = new UserService.Users();
            if(Session["program"]!= null)
            {
                String program = Session["program"].ToString();
                String title = Session["title"].ToString();
                String crn = Session["crn"].ToString();

                DataSet ds = proxy.detailsView(title, program, crn);
                lblCreds.Text = ds.Tables[0].Rows[0]["CreditHours"].ToString();
                lblDescript.Text = ds.Tables[0].Rows[0]["Description"].ToString();
                lblRepeatability.Text = ds.Tables[0].Rows[0]["Repeatability"].ToString();
                lblSemester.Text =  ds.Tables[0].Rows[0]["SemesterOffering"].ToString();

                String titling = ds.Tables[0].Rows[0]["Program"].ToString() + " " +  ds.Tables[0].Rows[0]["CourseNumber"].ToString() + ": " +
                    ds.Tables[0].Rows[0]["Title"].ToString();
                lblTitleProgram.Text = titling;

            }
        }

        protected void btnCatalogReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("CourseCatalogPage.aspx");
        }

        protected void btnAddRoster_Click(object sender, EventArgs e)
        {

        }
    }
}