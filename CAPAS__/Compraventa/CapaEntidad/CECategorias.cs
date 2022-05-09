using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CECategoria
    {
        private int cod_categoria;
        private string categoria;

        public int Cod_categoria { get => cod_categoria; set => cod_categoria = value; }
        public string Categoria { get => categoria; set => categoria = value; }
    }
}
