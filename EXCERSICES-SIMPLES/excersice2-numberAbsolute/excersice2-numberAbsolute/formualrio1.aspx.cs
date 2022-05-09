using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace excersice2_numberAbsolute
{
    public partial class formualrio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void calcular_Click(object sender, EventArgs e)
        {
            double numberAbsolute, number;
            number = Convert.ToDouble(txtnumber.Text);
            if (number < 0)
            {
                numberAbsolute = Math.Abs(number);
                respuesta.Text = System.Convert.ToString(numberAbsolute);
            }
            else 
            {
                numberAbsolute = number;
                respuesta.Text = System.Convert.ToString(numberAbsolute);

            }
        }
    }
}