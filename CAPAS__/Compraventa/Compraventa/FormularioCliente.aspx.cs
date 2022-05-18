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
    public partial class FormularioCliente : System.Web.UI.Page
    {
        CECleinte oncliente = new CECleinte();
        CNCliente oecliente = new CNCliente();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtdir_cliente_TextChanged(object sender, EventArgs e)
        {

        }
        //Boton Guardar
        protected void Button1_Click(object sender, EventArgs e)
        {
            oncliente.Ref_cliente = Convert.ToInt32(txtref_cliente.Text);
            oncliente.Nom_cliente = Convert.ToString(txtnom_cliente.Text);
            oncliente.Dir_cliente = Convert.ToString(txtdir_cliente.Text);
            oncliente.Tell_cliente = Convert.ToString(txttell_cliente.Text);
            if (oecliente.guardar_cliente(oncliente))
            {
                lblmensaje.Text = "CLIENTE GUARDADO";
            }
            else 
            {
                lblmensaje.Text = "VERIFIQUE LA INFORMACION";
            }


        }
    }
}