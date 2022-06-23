using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using CapaEntidad;

namespace CapaDatos
{
     public class CDProducto
    {
        conexion oconexion = new conexion();
        SqlCommand ocmd = new SqlCommand();
        //------------------------------------------------------------------------------------------
        public bool guardar_productos(CEProducto oproducto)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDCompraventa");
                ocmd.CommandText = "guardar_productos";
                ocmd.Parameters.Add("@cod_producto", oproducto.Cod_producto);
                ocmd.Parameters.Add("@desr_producto", oproducto.Descr_producto);
                ocmd.Parameters.Add("@valor_prodcuto", oproducto.Valor_producto);
                ocmd.Parameters.Add("@cantidad", oproducto.Cantidad);
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }
        //-------------------------------------------------------------------------------------------------------------
        public bool actualizar_producto(CEProducto oproducto)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDCompraventa");
                ocmd.CommandText = "actualizar_producto";
                ocmd.Parameters.Add("@cod_producto", oproducto.Cod_producto);
                ocmd.Parameters.Add("@desr_producto", oproducto.Descr_producto);
                ocmd.Parameters.Add("@valor_prodcuto", oproducto.Valor_producto);
                ocmd.Parameters.Add("@cantidad", oproducto.Cantidad);
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }
        //---------------------------------------------------------------------------------------------------------------
        public bool eliminar_producto(CEProducto oproducto)

        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDCompraventa");
                ocmd.CommandText = ("eliminar_producto");
                ocmd.Parameters.Add("@cod_producto", oproducto.Cod_producto);
                ocmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }
        //----------------------------------------------------------------------------------------------------------
        public DataSet consultar_producto(CEProducto oproducto)

        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDCompraventa");
                ocmd.CommandText = "consultar_producto";
                ocmd.Parameters.Add("@cod_producto", oproducto.Cod_producto);
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception error)
            {

                throw new Exception(error.Message);
            }

        }
    }
}
