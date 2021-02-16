using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Caja
    {
        private CD_Conexion conexion = new CD_Conexion();

        public DataTable mostrarcaja()
        {

            SqlDataReader lee;
            DataTable tablaa = new DataTable();
            SqlCommand comandoo = new SqlCommand();
            comandoo.Connection = conexion.abrir();
            comandoo.CommandText = "MostrarTransaccion";
            comandoo.CommandType = CommandType.StoredProcedure;
            lee = comandoo.ExecuteReader();
            tablaa.Load(lee);
            conexion.cerrar();
            return tablaa;
        }

        public void insertarcaja(string tipo, int cantidad,int dd)
        {
            SqlCommand comandoo = new SqlCommand();
            comandoo.Connection = conexion.abrir();
            comandoo.CommandText = "IngresoTransaccion";
            comandoo.CommandType = CommandType.StoredProcedure;
            comandoo.Parameters.AddWithValue("@fecha", DateTime.Now);
            comandoo.Parameters.AddWithValue("@tipo", tipo);
            comandoo.Parameters.AddWithValue("@cantidad", cantidad);
            comandoo.Parameters.AddWithValue("@dd", dd);
            comandoo.ExecuteNonQuery();
            
        }


    }
}
