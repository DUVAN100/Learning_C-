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
    public class CDFactura
    {
        conexion oconexion = new conexion();
        SqlCommand ocmd = new SqlCommand();
        //------------------------------------------------------------------------------------------
        public bool guardar_factura(CEFactura ofactura)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDCompraventa");
                ocmd.CommandText = "guardar_factura";
                ocmd.Parameters.Add("@nro_factura", ofactura.Nro_factura);
                ocmd.Parameters.Add("@fecha_factura", ofactura.Fecha_factura);
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }
        //-------------------------------------------------------------------------------------------------------------
        public bool actualizar_factura(CEFactura ofactura)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDCompraventa");
                ocmd.CommandText = ("actualizar_factura");
                ocmd.Parameters.Add("@nro_factura", ofactura.Nro_factura);
                ocmd.Parameters.Add("@fecha_factura", ofactura.Fecha_factura);
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }
        //---------------------------------------------------------------------------------------------------------------
        public bool eliminar_factura(CEFactura ofactura)

        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDCompraventa");
                ocmd.CommandText = ("eliminar_factura");
                ocmd.Parameters.Add("@nro_factura", ofactura.Nro_factura);
                ocmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }
        //----------------------------------------------------------------------------------------------------------
        public DataSet consultar_factrua(CEFactura ofactura)

        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDCompraventa");
                ocmd.CommandText = "consultar_factrua";
                ocmd.Parameters.Add("@nro_factura", ofactura.Nro_factura );
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
