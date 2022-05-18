using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidad;
using System.Data;
namespace capaNegocios
{
    public class CNCliente
    {
        CDCliente odaclinte = new CDCliente();
        public bool guardar_cliente(CECliente oencliente) 
        {
            return odaclinte.guardar_cliente(oencliente);
        }
        public bool actualizar_cliente(CECliente oencliente) 
        {
            return odaclinte.actualizar_cliente(oencliente);
        }
        public bool eliminar_cliente(CECliente oencliente) 
        {
            return odaclinte.eliminar_cliente(oencliente);
        }
        public DataSet consultar_cliente(CECliente oencliente) 
        {
            return odaclinte.consultar_cliente(oencliente);
        }

    }
}
