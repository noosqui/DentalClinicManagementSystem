using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class CD_Tratamiento
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
      
        DataTable tabla = new DataTable();

        public DataTable mostrartratamiento()
        {
            SqlCommand comando = new SqlCommand();
            DataTable tab = new DataTable();
            comando.Connection = conexion.abrir();
            comando.CommandText = "MostrarTratamiento";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tab.Load(leer);
            conexion.cerrar();
            return tab;
        }
        public DataTable tratamientoesp(string nombre)
        {
            SqlCommand comando = new SqlCommand();
            DataTable tab = new DataTable();
            comando.Connection = conexion.abrir();
            comando.CommandText = "mostrarT";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@name", nombre);
            leer = comando.ExecuteReader();
            tab.Load(leer);
            conexion.cerrar();
            return tab;
        }

        public DataTable mostraruso(int idm)
        {
            SqlCommand comandoo = new SqlCommand();
            DataTable tab = new DataTable();
            comandoo.Connection = conexion.abrir();
            comandoo.CommandText = "MostrarUso";
            comandoo.CommandType = CommandType.StoredProcedure;
            comandoo.Parameters.AddWithValue("@id", idm);
            leer = comandoo.ExecuteReader();
            tab.Load(leer);
            conexion.cerrar();
            return tab;
        }
    }
}
