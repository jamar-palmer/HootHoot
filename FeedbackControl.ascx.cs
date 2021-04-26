using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OwlSpace
{
    public partial class FeedbackControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public String Name
        {
            get { return lblStudentName.Text; }
            set { lblStudentName.Text = value; }
        }

        public String Date
        {
            get { return lblDate.Text; }
            set { lblDate.Text = value; }
        }

        public String Content
        {
            get { return lblContent.Text; }
            set { lblContent.Text = value; }
        }

    }
}