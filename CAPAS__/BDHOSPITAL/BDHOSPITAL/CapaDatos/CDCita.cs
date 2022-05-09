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
    public class CDCita
    {
        conexion oconexion = new conexion();
        SqlCommand ocmd = new SqlCommand();

        public bool guardar_cita(CECita ocitas)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDHOSPITAL");
                ocmd.CommandText = "Guardar cita";
                ocmd.Parameters.Add  ("@cod_cita", ocitas.Cod_cita);
                ocmd.Parameters.Add  ("@fecha", ocitas.Fecha);
                ocmd.Parameters.Add  ("@hora", ocitas.Hora);
                ocmd.Parameters.Add  ("@id_paciente", ocitas.Id_paciente);
                ocmd.Parameters.Add  ("@valor", ocitas.Valor);
                ocmd.Parameters.Add  ("@diagnostico", ocitas.Diagnostico);
                ocmd.Parameters.Add  ("@nom_acompanante", ocitas.Nom_acompanante);
                ocmd.Parameters.Add  ("@activo", ocitas.Activo);
                ocmd.Parameters.Add("@id_medico", ocitas.Id_medico);
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }
        public bool actualizar_cita(CECita ocitas)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDHOSPITAL");
                ocmd.CommandText = ("actualizar_cita");
                ocmd.Parameters.Add("@cod_cita", ocitas.Cod_cita);
                ocmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }
        public bool anular_cita(CECita ocitas)
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
         public DataSet consultar_cita(CECita ocitas) 
        {
            try
            {

                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDHOSPITAL");
                ocmd.CommandText = "consultar_cita";
                ocmd.Parameters.Add("@cod_cita", ocitas.Cod_cita);
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception error)
            {

                throw  new Exception(error.Message);
            }
        
        }
        //hacer las demas capas en paciente y medico
    }
}
