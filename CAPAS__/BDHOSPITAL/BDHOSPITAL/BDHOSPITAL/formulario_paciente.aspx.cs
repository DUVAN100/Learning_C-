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
    public partial class formulario_paciente : System.Web.UI.Page
    {
        CNPaciente onpaciente = new CNPaciente();
        CEPaciente oePaciente = new CEPaciente();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtnom_paciente_TextChanged(object sender, EventArgs e)
        {

        }


    }
}