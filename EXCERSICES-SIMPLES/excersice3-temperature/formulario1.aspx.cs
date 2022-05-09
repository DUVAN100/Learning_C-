using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace excersice3_pulsations
{
    public partial class formulario1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double volumen, masa, temperatura, presion;
            presion = Convert.ToDouble(txtpresion.Text);
            volumen = Convert.ToDouble(txtvolumen.Text);
            temperatura = Convert.ToDouble(txttemperatura.Text);
            masa = (presion * volumen) / (0.37 * (temperatura + 460));
            respuesta.Text = System.Convert.ToString(masa);
        }
    }
}