using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HootHoot
{
    public partial class CourseCatalogPage : System.Web.UI.Page
    {
        DBConnect dbcon = new DBConnect();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                displayData()
            }

        }
        //temp?
        public void displayData()
        {
            string term = ddlTerm.SelectedItem.Text;
            try
            {
                string sql = "Select * FROM Courses WHERE SemesterOffering = " + term;

                DataSet mydata = dbcon.GetDataSet(sql);
                rptCourses.DataSource = mydata;
                rptCourses.DataBind();
            }
            catch
            {
                //something wrong with GV data
            }
        }

        protected System.Void ddlTerm_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            displayGVData();
        }

        protected System.Void btnRegister_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                for (int row = 0; row < rptCourses.Items.Count; row++)
                {
                    CheckBox cb;


                    cb = (CheckBox)rptCourses.Items[row].FindControl("cbRegister");
                    if (cb.Checked)
                    {

                        //add course to student roster
                    }

                }
            catch
            {

            }
        }

        protected System.Void btnDetails_Click(System.Object sender, System.EventArgs e)
        {
            try
            {

            }
            catch
            {

            }
        }

    }
}