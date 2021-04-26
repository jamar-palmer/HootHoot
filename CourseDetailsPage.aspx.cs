using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HootHoot
{
    public partial class CourseDetailsPage : System.Web.UI.Page
    {
        DBConnect dbcon = new DBConnect();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostback)
            {
                displaydata()
            }
        }
        public void displayData()
        {
            rptDetails.DataSource =;
            rptDetails.DataBind();
        }
    }
}