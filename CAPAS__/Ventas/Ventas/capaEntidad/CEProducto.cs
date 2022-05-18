using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class CEProducto
    {
        private int cod_producto;
        private string nom_producto;
        private string valor_producto;
        private string cantidad;

        public int Cod_producto { get => cod_producto; set => cod_producto = value; }
        public string Nom_producto { get => nom_producto; set => nom_producto = value; }
        public string Valor_producto { get => valor_producto; set => valor_producto = value; }
        public string Cantidad { get => cantidad; set => cantidad = value; }
    }
}
