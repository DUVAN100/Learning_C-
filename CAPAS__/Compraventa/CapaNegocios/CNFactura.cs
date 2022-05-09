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
    public class CNFactura
    {
        CDFactura odacfactura = new CDFactura();
        public bool guardar_factura(CEFactura oenfactura)
        {
            return odacfactura.guardar_factura(oenfactura);
        }
        public bool actualizar_factura(CEFactura oenfactura)
        {
            return odacfactura.actualizar_factura(oenfactura);
        }
        public bool eliminar_factura(CEFactura oenfactura)
        {
            return odacfactura.eliminar_factura(oenfactura);
        }
        public DataSet consultar_faactura(CEFactura oenfactura) 
        {
            return odacfactura.consultar_factrua(oenfactura);
        }
    }
}
