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
    public class CDFactura
    {
        conexion oconexion = new conexion();
        SqlCommand ocmd = new SqlCommand();
        public bool guardar_factura(CEFactura ofactura) 
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDVENTAS");
                ocmd.CommandText = "guardar_factura";
                ocmd.Parameters.Add("@cod_factura", ofactura.Cod_factura);
                ocmd.Parameters.Add("@fecha_factura", ofactura.Fecha_factura);
                ocmd.Parameters.Add("@num_productos", ofactura.Num_productos);
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }
        public bool actualizr_fatura(CEFactura ofactura)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDVENTAS");
                ocmd.CommandText = "actualizr_fatura";
                ocmd.Parameters.Add("@cod_factura", ofactura.Cod_factura);
                ocmd.Parameters.Add("@fecha_factura", ofactura.Fecha_factura);
                ocmd.Parameters.Add("@num_productos", ofactura.Num_productos);
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }
        public bool eliminar_factura(CEFactura ofactura) 
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDVENTAS");
                ocmd.CommandText = "eliminar_factura";
                ocmd.Parameters.Add("@cod_factura", ofactura.Cod_factura);
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }
        public DataSet consultar_factura(CEFactura ofactura)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDVENTAS");
                ocmd.CommandText = "consultar_factura";
                ocmd.Parameters.Add("@cod_factura", ofactura.Cod_factura);
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
