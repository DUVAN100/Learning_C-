using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEPaciente
    {
        private string id_paciente;
        private string tipo_documento;
        private string nom_paciente;
        private string dir_paciente;
        private string cell_paciene;
        private byte ativo;

        public string Id_paciente { get => id_paciente; set => id_paciente = value; }
        public string Tipo_documento { get => tipo_documento; set => tipo_documento = value; }
        public string Nom_paciente { get => nom_paciente; set => nom_paciente = value; }
        public string Dir_paciente { get => dir_paciente; set => dir_paciente = value; }
        public string Cell_paciene { get => cell_paciene; set => cell_paciene = value; }
        public byte Ativo { get => ativo; set => ativo = value; }
    }
}
