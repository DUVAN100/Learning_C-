using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEProducto
    {
        private int cod_producto;
        private string descr_producto;
        private float valor_producto;
        private int cantidad;

        public int Cod_producto { get => cod_producto; set => cod_producto = value; }
        public string Descr_producto { get => descr_producto; set => descr_producto = value; }
        public float Valor_producto { get => valor_producto; set => valor_producto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
