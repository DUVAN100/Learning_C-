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
    public class Class1
    {
        
        CDCategoria odacategorias = new CDCategoria();
        public bool guardar_categoria(CECategoria oencategoria) 
        {
            return odacategorias.guardar_categoria(oencategoria);
        }
        public bool eliminar_categoria(CECategoria oencategoria)
        {
            return eliminar_categoria(oencategoria);
        }
        public bool actualizar_categoria(CECategoria oencategoria) 
        {
            return actualizar_categoria(oencategoria);
        }
        public bool consultar_categoria(CECategoria oencategoria) 
        {
            return consultar_categoria(oencategoria);
        }

    }
}
