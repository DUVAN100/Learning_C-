using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEMedico
    {
        private string id_medico;
        private string nom_medicp;
        private string especialida;
        private string cell_medico;
        private byte activo;

        public string Id_medico { get => id_medico; set => id_medico = value; }
        public string Nom_medicp { get => nom_medicp; set => nom_medicp = value; }

        public string Cell_medico { get => cell_medico; set => cell_medico = value; }
        public byte Activo { get => activo; set => activo = value; }
        public string Especialida { get => especialida; set => especialida = value; }
    }
}
