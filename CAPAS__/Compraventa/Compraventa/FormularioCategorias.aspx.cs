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
    public partial class FormularioCategorias : System.Web.UI.Page
    {
        CECategoria oncategoria = new CECategoria();
        Class1 oecategoria = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //Boton Guardar
        protected void Button1_Click(object sender, EventArgs e)
        {
            oncategoria.Cod_categoria = Convert.ToInt32(txtcod_categoria.Text);
            oncategoria.Categoria = Convert.ToString(txtcategoria.Text);
            if (oecategoria.guardar_categoria(oncategoria))
            {
                lblmensaje.Text = "CITA GUARDADA CON EXITO";
            }
            else 
            {
                lblmensaje.Text = "VERIFIQUE LOS CAMPOS REGISTRADOS HAY UN ERROR";
            }
        }
        //Boton Consultar 
        protected void Button3_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            oncategoria.Cod_categoria = Convert.ToInt32(txtcod_categoria.Text);

        }
    }
}