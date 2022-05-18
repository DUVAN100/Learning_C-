using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidad;
using CapaNegocios;
using System.Data;

namespace Compraventa
{
    public partial class FormularioFactura : System.Web.UI.Page
    {
        CEFactura oefactura = new CEFactura();
        CNFactura onfactura = new CNFactura();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            oefactura.Nro_factura = Convert.ToInt32(txtnro_factura.Text);
            oefactura.Fecha_factura = Convert.ToDateTime(txtfecha_factura.Text);
            if (onfactura.guardar_factura(oefactura))
            {
                lblmensaje.Text = "FACTURA GUARDADA";
            }
            else 
            {
                lblmensaje.Text = "VERIFIQUE LA INFORMACION";
            }
        }
    }
}