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
    public class CDCategoria
    {
        conexion oconexion = new conexion();
        SqlCommand ocmd = new SqlCommand();
        public bool guardar_categoria(CECategoria ocategoria)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDCompraventa");
                ocmd.CommandText = "guardar_categoria";
                ocmd.Parameters.Add("@cod_categoria", ocategoria.Cod_categoria);
                ocmd.Parameters.Add("@categoria", ocategoria.Categoria);
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }
        public bool actualizar_categoria(CECategoria ocategoria)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDCompraventa");
                ocmd.CommandText = ("actualizar_categoria");
                ocmd.Parameters.Add("@cod_categoria", ocategoria.Cod_categoria);
                ocmd.Parameters.Add("qcategoria", ocategoria.Categoria);
                ocmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }
        public bool eliminar_categoria(CECategoria ocategoria)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDCompraventa");
                ocmd.CommandText = ("eliminar_categoria");
                ocmd.Parameters.Add("@cod_categoria", ocategoria.Cod_categoria);
                ocmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }
        public DataSet consultar_categoria(CECategoria ocategoria)

        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDCompraventa");
                ocmd.CommandText = "consultar_categoria";
                ocmd.Parameters.Add("@cod_categoria", ocategoria.Cod_categoria);
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
