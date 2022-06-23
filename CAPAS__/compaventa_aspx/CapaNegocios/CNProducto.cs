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
    public class CNProducto
    {
        CDProducto odacproducto = new CDProducto();
        public bool guardar_productos(CEProducto oenproducto) 
        {
            return odacproducto.guardar_productos(oenproducto);
        }
        public bool actualizar_producto(CEProducto oenproducto) 
        {
            return odacproducto.actualizar_producto(oenproducto);
        }
        public bool eliminar_producto(CEProducto oenproducto) 
        {
            return odacproducto.eliminar_producto(oenproducto);
        }
        public DataSet consultar_producto(CEProducto oenproducto) 
        {
            return odacproducto.consultar_producto(oenproducto);
        }



    }
}
