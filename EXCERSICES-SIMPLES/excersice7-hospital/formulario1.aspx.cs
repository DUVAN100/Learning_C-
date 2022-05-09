using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace excersice6_hospital
{
    public partial class formulario1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncalcular_Click(object sender, EventArgs e)
        {
            double presupuesto, preginecologia, pretraumatologia, prepediatria;
            presupuesto = Convert.ToDouble(txtpresupuesto.Text);

            preginecologia = presupuesto * 0.4;
            pretraumatologia = presupuesto * 0.3;
            prepediatria = presupuesto * 0.3;
            respuesta1.Text = System.Convert.ToString(preginecologia);
            respuesta2.Text = System.Convert.ToString(pretraumatologia);
            respuesta3.Text = System.Convert.ToString(prepediatria);
        }
    }
}