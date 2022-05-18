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
    public partial class FormularioProductos : System.Web.UI.Page
    {
        CEProducto oeproducto = new CEProducto();
        CNProducto onproducto = new CNProducto();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            oeproducto.Cod_producto = Convert.ToInt32(txtcod_producto.Text);
            oeproducto.Descr_producto = Convert.ToString(txtdesc_producto.Text);
            oeproducto.Valor_producto = Convert.ToSingle(txtvalor_producto.Text);
            oeproducto.Cantidad = Convert.ToInt32(txtcantidad_producto.Text);
            if (onproducto.guardar_productos(oeproducto))
            {
                lblmensaje.Text = "producto guardado";
            }
            else 
            {
                lblmensaje.Text = "VERIFIQUE LA INFORMACION DEL PRODUCTO";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            oeproducto.Cod_producto = Convert.ToInt32(txtcod_producto.Text);
            ds = onproducto.consultar_producto(oeproducto);
            if (ds.Tables[0].Rows.Count == 0)
            {
                lblmensaje.Text = "no hay producto";
            }
            else 
            {
                lblmensaje.Text = ds.Tables[0].Rows[0]["Cod_producto"].ToString();
                txtdesc_producto.Text = ds.Tables[0].Rows[0]["desc_producto"].ToString();
                txtvalor_producto.Text = ds.Tables[0].Rows[0]["valor_producto"].ToString();
                txtcantidad_producto.Text = ds.Tables[0].Rows[0]["cantidad_producto"].ToString();
            }
        }
    }
}