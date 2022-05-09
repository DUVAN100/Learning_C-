using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace excersice1_purchaseOfTires
{
    public partial class formulario_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            double cantidadpesos, cantidaddolar;
            cantidadpesos = Convert.ToDouble(txtcanpesos.Text);
            cantidaddolar = cantidadpesos * 0.000254656;
            respuesta.Text = System.Convert.ToString(cantidaddolar);

        }
    }
}