using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace CapaDatos
{
   public class CDMedio
    {
        conexion oconexion = new conexion();
        SqlCommand ocmd = new SqlCommand();

        public bool guardar_medico(CEMedico omedico)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDHOSPITAL");
                ocmd.CommandText = "guardar_medico";
                ocmd.Parameters.Add("@id_medico", omedico.Id_medico);
                ocmd.Parameters.Add("@nom_medico", omedico.Nom_medicp);
                ocmd.Parameters.Add("@especialida", omedico.Especialida);
                ocmd.Parameters.Add("@cell_medico", omedico.Cell_medico);
                ocmd.Parameters.Add("@activo", omedico.Activo);
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }
        public bool actualizar_medico(CEMedico omedico)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDHOSPITAL");
                ocmd.CommandText = ("actualizar_medico");
                ocmd.Parameters.Add("@id_medico", omedico.Id_medico);
                ocmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }
        public bool anular_medico(CEMedico omedico)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDHOSPITAL");
                ocmd.CommandText = ("eliminar_cita");
                ocmd.Parameters.Add("@cod_cita", ocitas.Cod_cita);
                ocmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }
        public DataSet consultar_cita(CEMedico omedico)
        {
            try
            {

                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDHOSPITAL");
                ocmd.CommandText = "onsultar_medico";
                ocmd.Parameters.Add("@id_medico", omedico.Id_medico);
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
