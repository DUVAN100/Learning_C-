using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using capaEntidad;
namespace capaDatos
{
    public class conexion
    {

        public SqlConnection conectar(string cmx)
        {
            try
            {
                SqlConnection oconectar = new SqlConnection(ConfigurationSettings.AppSettings[cmx].ToString());
                oconectar.Open();
                return oconectar;

            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }
    }
}
