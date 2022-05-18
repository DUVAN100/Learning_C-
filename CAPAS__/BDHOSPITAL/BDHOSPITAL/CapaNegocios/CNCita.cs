using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data;
namespace CapaNegocios
{
    public class CNCita
    {
        CDCita odatcita = new CDCita();
        public bool guardar_cita(CECita oencita)
        {
            return odatcita.guardar_cita(oencita);

        }
        public DataSet consultar_cita(CECita oencita)
        {
            return odatcita.consultar_cita(oencita);
        }
        public bool anular_cita(CECita oencita)
        {
            return odatcita.anular_cita(oencita);
        }
        public bool actualizar_cita(CECita oencita) 
        {
            return odatcita.actualizar_cita(oencita);
        }
    }
}
