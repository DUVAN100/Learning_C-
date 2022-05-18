using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using capaEntidad;

namespace capaDatos
{
    public class CDProducto
    {
        conexion oconexion = new conexion();
        SqlCommand ocmd = new SqlCommand();
        public bool guardar_producot(CEProducto oproducto) 
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDVENTAS");
                ocmd.CommandText = "guardar_producot";
                ocmd.Parameters.Add("@cod_producto", oproducto.Cod_producto);
                ocmd.Parameters.Add("@nom_producto", oproducto.Nom_producto);
                ocmd.Parameters.Add("@valor_producto", oproducto.Valor_producto);
                ocmd.Parameters.Add("@cantidad", oproducto.Cantidad);
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }
        public bool actualizar_producto(CEProducto oproducto) 
        {
            try
            {

                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDVENTAS");
                ocmd.CommandText = "actualizar_producto";
                ocmd.Parameters.Add("@cod_producto", oproducto.Cod_producto);
                ocmd.Parameters.Add("@nom_producto", oproducto.Nom_producto);
                ocmd.Parameters.Add("@valor_producto", oproducto.Valor_producto);
                ocmd.Parameters.Add("@cantidad", oproducto.Cantidad);
                ocmd.ExecuteNonQuery();
                return true;


            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
       }
        public bool eliminar_producto(CEProducto oproducto)
        {
            try
            {

                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDVENTAS");
                ocmd.CommandText = "eliminar_producto";
                ocmd.Parameters.Add("@cod_producto", oproducto.Cod_producto);
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }
        public DataSet consultar_producto(CEProducto oproducto) 
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDVENTAS");
                ocmd.CommandText = "consultar_producto";
                ocmd.Parameters.Add("@cod_producto", oproducto.Cod_producto);
                SqlDataAdapter da = new SqlDataAdapter(ocmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }
    }
}
