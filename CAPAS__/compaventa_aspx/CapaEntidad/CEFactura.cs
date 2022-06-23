using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
     public class CEFactura
    {
        private int nro_factura;
        private DateTime fecha_factura;

        public int Nro_factura { get => nro_factura; set => nro_factura = value; }
        public DateTime Fecha_factura { get => fecha_factura; set => fecha_factura = value; }
    }
}
