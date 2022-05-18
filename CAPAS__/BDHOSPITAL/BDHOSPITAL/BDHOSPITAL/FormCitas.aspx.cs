using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidad;
using CapaNegocios;
using System.Data;

namespace BDHOSPITAL
{
    public partial class FormCitas : System.Web.UI.Page
    {
        CNCita oncitas = new CNCita();
        CECita oecitas = new CECita();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            oecitas.Cod_cita = Convert.ToString(txtcod_cita.Text);
            oecitas.Fecha = Convert.ToDateTime(txtfecha_cita.Text);
            oecitas.Hora = Convert.ToDateTime(hora.Text);
            oecitas.Id_paciente = Convert.ToString(id_paciente.Text);
            oecitas.Id_medico = Convert.ToString(id_medico.Text);
            oecitas.Valor = Convert.ToInt32(valor.Text);
            oecitas.Diagnostico = Convert.ToString(diagnostico.Text);
            oecitas.Nom_acompanante = Convert.ToString(nombre_acompanante.Text);
            if (oncitas.guardar_cita(oecitas))
            {
                lblmensaje.Text = "Cita guardada";
            }
            else
            {
                lblmensaje.Text = "Cita no guardada";
            
            }
        }
 
    }
}