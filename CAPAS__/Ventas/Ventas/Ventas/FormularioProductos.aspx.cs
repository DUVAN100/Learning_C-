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
    public partial class FormularioProductos : System.Web.UI.Page
    {
        CEProducto oeproducto = new CEProducto();
        CNProducto onproducto = new CNProducto();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void gguardar_producto_Click(object sender, EventArgs e)
        {
            oeproducto.Cod_producto = Convert.ToInt32(txtcod_product.Text);
            oeproducto.Nom_producto = Convert.ToString(txtnom_product.Text);
            oeproducto.Valor_producto = Convert.ToString(txtvalue_product.Text);
            oeproducto.Cantidad = Convert.ToString(txtamout_product.Text);
            if (onproducto.guardar_producot(oeproducto))
            {
                lblmensaje.Text = "PRODUCTO GUARDADO";
            }
            else
            {
                lblmensaje.Text = "ERROR AL GUARDAR EL PRODUCTO";
            }
        }

        protected void txtactualizar_producto_Click(object sender, EventArgs e)
        {
            txtcod_product.Text = " ";
            txtnom_product.Text = " ";
            txtvalue_product.Text = " ";
            txtamout_product.Text = " ";
        }

        protected void eliminar_producto_Click(object sender, EventArgs e)
        {
            oeproducto.Cod_producto = Convert.ToInt32(txtcod_product.Text);
            if (onproducto.eliminar_producto(oeproducto))
            {
                lblmensaje.Text = "PRODUCTO ELIMINADO CON EXITO";
            }
            else 
            {
                lblmensaje.Text = "ERROR";
            }

        }

        protected void consultar_producto_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            oeproducto.Cod_producto = Convert.ToInt32(txtcod_product.Text);
            ds = onproducto.consultar_producto(oeproducto);
            if (ds.Tables[0].Rows.Count == 0)
            {
                lblmensaje.Text = "PRODUCTO NO EXISTENTE";
            }
            else
            {
                lblmensaje.Text = ds.Tables[0].Rows[0]["Cod_producto"].ToString();
                txtnom_product.Text = ds.Tables[0].Rows[0]["Nom_producto"].ToString();
                txtvalue_product.Text = ds.Tables[0].Rows[0]["Valor_producto"].ToString();
                txtamout_product.Text = ds.Tables[0].Rows[0]["Cantidad"].ToString();
            }
        }
    }
}