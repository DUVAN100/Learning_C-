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
    public class CDPaciente
    {
        conexion oconexion = new conexion();
        SqlCommand ocmd = new SqlCommand();
        public bool guardar_paciente(CEPaciente opacientes)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDHOSPITAL");
                ocmd.CommandText = "guardar_paciente";
                ocmd.Parameters.Add("@id_paciente", opacientes.Id_paciente);
                ocmd.Parameters.Add("@tipo_documento", opacientes.Tipo_documento);
                ocmd.Parameters.Add("@nom_paciente", opacientes.Nom_paciente);
                ocmd.Parameters.Add("@dir_paciente", opacientes.Dir_paciente);
                ocmd.Parameters.Add("@cell_paciente", opacientes.Cell_paciene);
                ocmd.Parameters.Add("@activo", opacientes.Ativo);
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception error)
            {

                throw new Exception(error.Message);
            }
        }


        public bool actualizar_paciente(CEPaciente opaciente)
        {
            try
            {
                ocmd.CommandType =CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDHOSPITAL");
                ocmd.CommandText = ("actualizar_paciente");
                ocmd.Parameters.Add("@id_paciente", opaciente.Id_paciente);
                ocmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }

        }
        public DataSet consultar_paciente(CEPaciente opaciente) 
        {
            try
            {

                ocmd.CommandType = System.Data.CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDHOSPITAL");
                ocmd.CommandText = "consultar_pciente";
                ocmd.Parameters.Add("@id´paciente", opaciente.Id_paciente);
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
