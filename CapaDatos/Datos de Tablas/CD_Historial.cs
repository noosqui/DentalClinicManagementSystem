using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Historial
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();
        DataTable tabla = new DataTable();

        public void ingresHistorial(string idp,DateTime date,long idt)
        {
            SqlCommand coman = new SqlCommand();
            coman.Connection=conexion.abrir();
            coman.CommandText = "IngresoHistorial";
            coman.CommandType = CommandType.StoredProcedure;
            coman.Parameters.AddWithValue("@idpaciente", idp);
            coman.Parameters.AddWithValue("@fecha", date);
            coman.Parameters.AddWithValue("@idtratamiento", idt);
            coman.ExecuteNonQuery();
        }

        public DataTable matnec(long id)
        {
            DataTable tabla = new DataTable();
            SqlCommand com = new SqlCommand();
            com.Connection = conexion.abrir();
            com.CommandText = "matnec";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id", id);
            leer = com.ExecuteReader();
            tabla.Load(leer);
            return tabla;
        }

        public DataTable histoshow(string id)
        {
            DataTable table = new DataTable();
            SqlCommand co = new SqlCommand();
            SqlDataReader lee;
            co.Connection = conexion.abrir();
            co.CommandText = "MostrarHistorial";
            co.CommandType = CommandType.StoredProcedure;
            co.Parameters.AddWithValue("@idpac", id);
            lee = co.ExecuteReader();
            table.Load(lee);
            return table;
        }
    }
}
