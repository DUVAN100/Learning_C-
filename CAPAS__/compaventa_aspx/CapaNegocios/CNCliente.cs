using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
using System.Data;
namespace CapaNegocios
{
    public class CNCliente
    {
        CDCliente odaclientes = new CDCliente();
        public bool guardar_cliente(CECleinte oencliente) 
        {
            return odaclientes.guardar_cliente(oencliente);
        }
        public bool actualizar_cliente(CECleinte oencliente) 
        {
            return odaclientes.actualizar_cliente(oencliente);
        }
        public bool eliminar_cliente(CECleinte oencliente)
        {
            return odaclientes.eliminar_cliente(oencliente);
        }
        public DataSet consultar_cliente(CECleinte oencliente)
        {
            return odaclientes.consultar_cliente(oencliente);
        }

    }
}
