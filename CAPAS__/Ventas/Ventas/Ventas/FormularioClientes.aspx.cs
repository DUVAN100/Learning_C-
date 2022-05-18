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
    public partial class FormularioClientes : System.Web.UI.Page
    {
        CNCliente oncliente = new CNCliente();
        CECliente oecliente = new CECliente();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void guardar_cliente_Click(object sender, EventArgs e)
        {
            oecliente.Cod_cliente1 = Convert.ToInt32(txtcod_cliente.Text);
            oecliente.Nom_cliente = Convert.ToString(txtnom_cliente.Text);
            oecliente.Cell_cliente = Convert.ToString(txtcell_cliente.Text);
            oecliente.Gmail_cliente = Convert.ToString(txtgmail.Text);
            if (oncliente.guardar_cliente(oecliente))
            {
                lblmensaje.Text = "CLIENTE GUARDADO";
            }
            else 
            {
                lblmensaje.Text = "ERROR AL GUARDAR EL CLIENTE";
            }
        }

        protected void actualizar_cliente_Click(object sender, EventArgs e)
        {
            txtcod_cliente.Text = " ";
        }

        protected void eliminar_cliente_Click(object sender, EventArgs e)
        {
            oecliente.Cod_cliente1 = Convert.ToInt32(txtcod_cliente.Text);
            if (oncliente.eliminar_cliente(oecliente))
            {
                lblmensaje.Text = "CLIENTE ELIMINADO EXITOSAMENTE";
            }
            else 
            {
                lblmensaje.Text = "ERROR AL ELIMINAR";
            }
        }

        protected void consultar_cliente_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            oecliente.Cod_cliente1 = Convert.ToInt32(txtcod_cliente.Text);
            ds = oncliente.consultar_cliente(oecliente);
            if (ds.Tables[0].Rows.Count == 0)
            {
                   lblmensaje.Text = "VERIFIQUE SU IDENTIFICCION";
            }
            else 
            {
                lblmensaje.Text = ds.Tables[0].Rows[0]["Cod_cliente"].ToString();
                txtnom_cliente.Text = ds.Tables[0].Rows[0]["Nom_cliente"].ToString();
                txtcell_cliente.Text = ds.Tables[0].Rows[0]["Cell_cliente"].ToString();
                txtgmail.Text = ds.Tables[0].Rows[0]["Gmail_cliente"].ToString();
            }
        }
    }
}   