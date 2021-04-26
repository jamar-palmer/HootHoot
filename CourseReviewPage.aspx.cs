using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HootHootLibrary;

namespace OwlSpace
{
    public partial class CourseReviewPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Review rv = new Review();
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
                Label course = (Label)rptCourses_ItemCommand.Items[row].FindControl("lblTitle");
                string title = course;
                rv.course = title;
                showReview = true;

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
                double total = 0;
                //1st question
                if (ddlReview1.SelectedItem.Text == "Strongly Agree")
                {
                    total = total + 5;
                } 
                else if (ddlReview1.SelectedItem.Text == "Agree")
                {
                    total = total + 4;
                }
                else if (ddlReview1.SelectedItem.Text == "Neutral")
                {
                    total = total + 3;
                }
                else if (ddlReview1.SelectedItem.Text == "Disagree")
                {
                        total = total + 2;
                }
                else if (ddlReview1.SelectedItem.Text == "Strongly Disagree")
                {
                        total = total + 1;
                }
                //2nd question
                if (ddlReview2.SelectedItem.Text == "Strongly Agree")
                {
                    total = total + 5;
                }
                else if (ddlReview2.SelectedItem.Text == "Agree")
                {
                    total = total + 4;
                }
                else if (ddlReview2.SelectedItem.Text == "Neutral")
                {
                    total = total + 3;
                }
                else if (ddlReview2.SelectedItem.Text == "Disagree")
                {
                    total = total + 2;
                }
                else if (ddlReview2.SelectedItem.Text == "Strongly Disagree")
                {
                    total = total + 1;
                }
                //3rd question
                if (ddlReview3.SelectedItem.Text == "Strongly Agree")
                {
                    total = total + 5;
                }
                else if (ddlReview3.SelectedItem.Text == "Agree")
                {
                    total = total + 4;
                }
                else if (ddlReview3.SelectedItem.Text == "Neutral")
                {
                    total = total + 3;
                }
                else if (ddlReview3.SelectedItem.Text == "Disagree")
                {
                    total = total + 2;
                }
                else if (ddlReview3.SelectedItem.Text == "Strongly Disagree")
                {
                    total = total + 1;
                }
                //4th question
                if (ddlReview4.SelectedItem.Text == "Strongly Agree")
                {
                    total = total + 5;
                }
                else if (ddlReview4.SelectedItem.Text == "Agree")
                {
                    total = total + 4;
                }
                else if (ddlReview4.SelectedItem.Text == "Neutral")
                {
                    total = total + 3;
                }
                else if (ddlReview4.SelectedItem.Text == "Disagree")
                {
                    total = total + 2;
                }
                else if (ddlReview4.SelectedItem.Text == "Strongly Disagree")
                {
                    total = total + 1;
                }
                //5th question
                if (ddlReview5.SelectedItem.Text == "Strongly Agree")
                {
                    total = total + 5;
                }
                else if (ddlReview5.SelectedItem.Text == "Agree")
                {
                    total = total + 4;
                }
                else if (ddlReview5.SelectedItem.Text == "Neutral")
                {
                    total = total + 3;
                }
                else if (ddlReview5.SelectedItem.Text == "Disagree")
                {
                    total = total + 2;
                }
                else if (ddlReview5.SelectedItem.Text == "Strongly Disagree")
                {
                    total = total + 1;
                }

                double avg = total / 5;
                rv.rating = avg;
                rv.rev = txtReview.Text;

            }
            catch
            {
                //something went wrong
            }
        }
    }
}