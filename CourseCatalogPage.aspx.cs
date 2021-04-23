using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using PizzaLibrary;
using System.Data;
using System.Collections;
using System.Globalization;

namespace HootHoot
{
    public partial class CourseCatalogPage : System.Web.UI.Page
    {
        DBConnect dbcon = new DBConnect();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                displayGVData()
            }

        }
        //temp?
        public void displayGVData()
        {
            string term = ddlTerm.SelectedItem.Text;
            try
            {
                string sql = "Select * FROM Courses WHERE SemesterOffering = " + term;

                DataSet mydata = dbcon.GetDataSet(sql);
                gvCourses.DataSource = mydata;
                gvCourses.DataBind();
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
                for (int row = 0; row < gvCourses.Rows.Count; row++)
                {
                    CheckBox cb;


                    cb = (CheckBox)gvCourses.Rows[row].FindControl("cbRegister");
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