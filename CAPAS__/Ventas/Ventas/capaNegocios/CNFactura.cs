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
    public class CNFactura
    {
        CDFactura odafactura = new CDFactura();
        public bool guardar_factura(CEFactura oenfactura) 
        {
            return odafactura.guardar_factura(oenfactura);
        }
        public bool actualizr_fatura(CEFactura oenfactura)
        {
            return odafactura.actualizr_fatura(oenfactura);
        }
        public bool eliminar_factura(CEFactura oenfactura)
        {
            return odafactura.eliminar_factura(oenfactura);
        }
        public DataSet consultar_factura(CEFactura oenfactura) 
        {
            return odafactura.consultar_factura(oenfactura);
        }
    }
}
