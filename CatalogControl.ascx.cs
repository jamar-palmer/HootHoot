using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OwlSpace
{
    public partial class CatalogControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public String Program
        {
            get { return lblProgram.Text;}
            set { lblProgram.Text = value; }
        }

        public String CRN
        {
            get { return lblCRN.Text; }
            set { lblCRN.Text = value; }
        }

        public String CreditHours
        {
            get { return lblHours.Text; }
            set { lblHours.Text = value; }
        }

        public String Title
        {
            get { return lnkTitle.Text; }
            set { lnkTitle.Text = value; }
        }

        protected void lnkTitle_Click(object sender, EventArgs e)
        {
            Session["crn"] = lblCRN.Text;
            Session["program"] = lblProgram.Text;
            Session["title"] = lnkTitle.Text;
            Response.Redirect("CourseDetailsPage.aspx");
        }
    }
}