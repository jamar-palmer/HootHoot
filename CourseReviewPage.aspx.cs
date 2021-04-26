using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OwlSpace
{
    public partial class CourseReviewPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                showReview(false);
            }
        }

        public void showReview(Boolean tf)
        {
            lblReview.Visible = tf;
            lblReview1.Visible = tf;
            lblReview2.Visible = tf;
            lblReview3.Visible = tf;
            lblReview4.Visible = tf;
            lblReview5.Visible = tf;
            ddlReview1.Visible = tf;
            ddlReview2.Visible = tf;
            ddlReview3.Visible = tf;
            ddlReview4.Visible = tf;
            ddlReview5.Visible = tf;
            btnSubmit.Visible = tf;
        }

        protected Void rptCourses_ItemCommand(Object sender, System.Web.UI.WebControls.RepeaterCommandEventArgs e)
        {
            try
            {
                int row = e.Item.ItemIndex;
                Label course = (Label)
            }
            catch
            {
                //something went wrong
            }
        }
        protected System.Void btnSubmit_Click(System.Object sender, System.EventArgs e)
        {
            try
            {

            }
            catch
            {
                //something went wrong
            }
        }
    }
}