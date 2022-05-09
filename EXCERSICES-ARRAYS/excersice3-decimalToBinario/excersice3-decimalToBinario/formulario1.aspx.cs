using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace excersice3_decimalToBinario
{
    public partial class formulario1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double number, binario=0;
            number = Convert.ToSingle(txtdecimal.Text);
            double i = 1;
            while (number >= 1)
            { 
                if (number % 2 == 1) 
                {
                    binario += i; 
                }
                //centencia para redondear el numero decimal 
                number = Math.Round(number/2);

                i *= 10;
            }
            respuesta.Text = System.Convert.ToString(binario);
        }
    }
}