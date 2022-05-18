using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocios
{
    public class CNMedico
    {
        CDMedio odacmedico = new CDMedio();
        public bool guardar_medico(CEMedico oenmedico) 
        {
            return odacmedico.guardar_medico(oenmedico);
        }
        public bool consultar_medico(CEMedico oemedico) 
        {
            return odacmedico.guardar_medico(oemedico);
        }
        public bool eliminar_medico(CEMedico oenmedico) 
        {
            return odacmedico.
        }
    }
}
