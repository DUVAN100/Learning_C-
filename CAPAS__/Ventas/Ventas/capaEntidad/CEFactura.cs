using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class CEFactura
    {
        private int cod_factura;
        private DateTime fecha_factura;
        private string num_productos;

        public int Cod_factura { get => cod_factura; set => cod_factura = value; }
        public DateTime Fecha_factura { get => fecha_factura; set => fecha_factura = value; }
        public string Num_productos { get => num_productos; set => num_productos = value; }
    }
}
    