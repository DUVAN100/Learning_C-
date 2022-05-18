using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using capaEntidad;
using capaNegocios;
namespace Ventas
{
    public partial class FormularioFactura : System.Web.UI.Page
    {
        CEFactura oefactura = new CEFactura();
        CNFactura onfactura = new CNFactura();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void guardar_factua_Click(object sender, EventArgs e)
        {
            oefactura.Cod_factura = Convert.ToInt32(txtnumberinvoice.Text);
            oefactura.Fecha_factura = Convert.ToDateTime(txtinvoicedate.Text);
            oefactura.Num_productos = Convert.ToString(txtnumberproducts.Text);
            if (onfactura.guardar_factura(oefactura))
            {
              lblmesaje.Text = "FACTURA GUARDADO";
            }
            else
            {
                lblmesaje.Text = "ERROR AL GUARDAR LA FACTURA";
            }
        }

        protected void actualizar_factura_Click(object sender, EventArgs e)
        {

        }
        protected void elimnar_factura_Click(object sender, EventArgs e)
        {
            oefactura.Cod_factura = Convert.ToInt32(txtnumberinvoice.Text);
            if (onfactura.eliminar_factura(oefactura))
            {
                lblmesaje.Text = "FACTURA ELIMINADA";
            }
            else 
            {
                lblmesaje.Text = "ERROR";
            }
        }
        
        protected void consultar_factura_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            oefactura.Cod_factura = Convert.ToInt32(txtnumberinvoice.Text);
            ds = onfactura.consultar_factura(oefactura);
            if (ds.Tables[0].Rows.Count == 0)
            {
                lblmesaje.Text = "FACTURA NO EXISTE";
            }
            else 
            {
                lblmesaje.Text = ds.Tables[0].Rows[0]["cod_factura"].ToString();
                txtinvoicedate.Text = ds.Tables[0].Rows[0]["Fecha_factura"].ToString();
                txtnumberproducts.Text = ds.Tables[0].Rows[0]["Num_productos"].ToString();
            }
        }


    }
}