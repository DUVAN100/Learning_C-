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
    public class CNProducto
    {
        CDProducto odaproducto = new CDProducto();
        public bool guardar_producot(CEProducto oenproducto) 
        {
            return odaproducto.guardar_producot(oenproducto);
        }
        public bool actualizar_producto(CEProducto oenproducto)
        {
            return odaproducto.actualizar_producto(oenproducto);
        }
        public bool eliminar_producto(CEProducto oenproducto)
        {
            return odaproducto.eliminar_producto(oenproducto);
        }
        public DataSet consultar_producto(CEProducto oenproducto) 
        {
            return odaproducto.consultar_producto(oenproducto);
        }
    }
}
