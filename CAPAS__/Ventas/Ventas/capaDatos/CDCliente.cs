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
    public class CDCliente
    {
        conexion oconexion = new  conexion();
        SqlCommand ocmd = new SqlCommand();
        public bool guardar_cliente(CECliente ocliente) 
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDVENTAS");
                ocmd.CommandText = "guardar_cliente";
                ocmd.Parameters.Add("@Cod_cliente", ocliente.Cod_cliente1);
                ocmd.Parameters.Add("@nom_cliente", ocliente.Nom_cliente);
                ocmd.Parameters.Add("@cell_cliente", ocliente.Cell_cliente);
                ocmd.Parameters.Add("@gmail_cliente", ocliente.Gmail_cliente);
                ocmd.ExecuteNonQuery();
                return true;
            }   
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }
        public bool actualizar_cliente(CECliente ocliente) 
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDVENTAS");
                ocmd.CommandText = "actualizar_cliente";
                ocmd.Parameters.Add("@Cod_cliente", ocliente.Cod_cliente1);
                ocmd.Parameters.Add("@nom_cliente", ocliente.Nom_cliente);
                ocmd.Parameters.Add("@cell_cliente", ocliente.Cell_cliente);
                ocmd.Parameters.Add("@gmail_cliente", ocliente.Gmail_cliente);
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }
        public bool eliminar_cliente(CECliente ocliente) 
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDVENTAS");
                ocmd.CommandText = "eliminar_cliente";
                ocmd.Parameters.Add("@Cod_cliente", ocliente.Cod_cliente1);
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }

        }
        public DataSet consultar_cliente(CECliente ocliente) 
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDVENTAS");
                ocmd.CommandText = "consultar_cliente";
                ocmd.Parameters.Add("@Cod_cliente", ocliente.Cod_cliente1);
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
