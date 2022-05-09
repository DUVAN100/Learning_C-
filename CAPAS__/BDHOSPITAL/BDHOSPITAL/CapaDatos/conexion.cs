using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace CapaDatos
{
    public class conexion
    {
        public SqlConnection conectar(string cnx)
        {
            try
            {
                SqlConnection oconectar = new SqlConnection(ConfigurationSettings.AppSettings[cnx].ToString());
                oconectar.Open();
                return oconectar;
            }
            catch (Exception ERR)
            {

                throw new Exception(ERR.Message);
            }




        }
        
    }
}
