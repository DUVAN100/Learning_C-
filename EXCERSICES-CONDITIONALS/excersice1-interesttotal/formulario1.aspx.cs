using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace conditional_excersice1
{
    public partial class formulario1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncalcular_Click(object sender, EventArgs e)
        {
            ///variables
            double capital, interestPercentage, interest, finalCapital;
            capital = Convert.ToDouble(txtcapital.Text);
            interestPercentage = Convert.ToDouble(txtinteres.Text);
            interest = capital * interestPercentage;
            if (interest > 7000)
            {
                finalCapital = capital + interest;
                lblrespuesta.Text = System.Convert.ToString(finalCapital);
            }
            else 
            {
                lblrespuesta.Text = System.Convert.ToString("no va a reinvertir");
            
            }
            




        }
    }
}