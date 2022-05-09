using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace excersice5_discontStudent
{
    public partial class formulario1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            double costCourse, numberCourse, costTotalCourses, averageCourses;
            numberCourse = Convert.ToDouble(txtnumbercourse.Text);
            averageCourses = Convert.ToDouble(txtaverage.Text);
            costCourse = Convert.ToDouble(txtcost.Text);
            if (averageCourses >= 9)
            {
                costTotalCourses = (numberCourse * costCourse) - (costCourse * 0.3);
                respuesta.Text = System.Convert.ToString(costTotalCourses);
            }
            else
            {
                costTotalCourses = (numberCourse * costCourse) + (costCourse * 0.1);
                respuesta.Text = System.Convert.ToString(costTotalCourses);
            
            }


        }
    }
}