using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidad;

namespace CapaDatos
{
    public class CDCliente
    {
        conexion oconexion = new conexion();
        SqlCommand ocmd = new SqlCommand();
        //------------------------------------------------------------------------------------------
        public bool guardar_cliente(CECleinte ocliene)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDCompraventa");
                ocmd.CommandText = "guardar_cliente";
                ocmd.Parameters.Add("@ref_cliente", ocliene.Ref_cliente);
                ocmd.Parameters.Add("@nom_cliente", ocliene.Nom_cliente);
                ocmd.Parameters.Add("@dir_clinte", ocliene.Dir_cliente);
                ocmd.Parameters.Add("@tel_cliente", ocliene.Tell_cliente);
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }
        //-------------------------------------------------------------------------------------------------------------
        public bool actualizar_cliente(CECleinte ocliente)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDCompraventa");
                ocmd.CommandText = ("actualizar_cliente");
                ocmd.Parameters.Add("@ref_cliente", ocliente.Ref_cliente);
                ocmd.Parameters.Add("@nom_cliente", ocliente.Nom_cliente);
                ocmd.Parameters.Add("@dir_cliene", ocliente.Dir_cliente);
                ocmd.Parameters.Add("@tell_cliente", ocliente.Tell_cliente);
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }
        //---------------------------------------------------------------------------------------------------------------
        public bool eliminar_cliente(CECleinte ocliente)

        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDCompraventa");
                ocmd.CommandText = ("eliminar_cliente");
                ocmd.Parameters.Add("qref_cliente", ocliente.Ref_cliente);
                ocmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }

        //----------------------------------------------------------------------------------------------------------
        public DataSet consultar_cliente(CECleinte ocliente)

        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDCompraventa");
                ocmd.CommandText = "consultar_cliente";
                ocmd.Parameters.Add("@ref_cliente", ocliente.Ref_cliente);
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

