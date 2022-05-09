using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace excersice4_salaryhours
{
    public partial class formulario1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double numberHours, numberExtraHours, salary;
            numberHours = Convert.ToDouble(txtnumberhours.Text);
            if (numberHours > 40)
            {
                numberExtraHours = numberHours - 40;
                salary = (numberExtraHours * 20) + (40 * 16);
                totalsalary.Text = System.Convert.ToString(salary);
            }
            else 
            {
                salary = numberHours * 16;
                totalsalary.Text = System.Convert.ToString(salary);
            
            }
            
        }
    }
}