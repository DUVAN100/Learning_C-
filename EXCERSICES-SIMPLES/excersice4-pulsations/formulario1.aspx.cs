using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace excersice4_pulsations
{
    public partial class formulario1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double edad, numberpulsations;
            edad = Convert.ToDouble(txtedad.Text);
            numberpulsations = (220 - edad) / 10;
            respuesta.Text = System.Convert.ToString(numberpulsations);
        }
    }
}