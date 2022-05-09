using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CECita
    {
        private string cod_cita;
        private DateTime fecha;
        private DateTime hora;
        private string id_paciente;
        private int valor;
        private string diagnostico;
        private string nom_acompanante;
        private byte activo;
        private string id_medico;

        public string Cod_cita { get => cod_cita; set => cod_cita = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public DateTime Hora { get => hora; set => hora = value; }
        public string Id_paciente { get => id_paciente; set => id_paciente = value; }
        public int Valor { get => valor; set => valor = value; }
        public string Diagnostico { get => diagnostico; set => diagnostico = value; }
        public string Nom_acompanante { get => nom_acompanante; set => nom_acompanante = value; }
        public byte Activo { get => activo; set => activo = value; }
        public string Id_medico { get => id_medico; set => id_medico = value; }
    }
}
