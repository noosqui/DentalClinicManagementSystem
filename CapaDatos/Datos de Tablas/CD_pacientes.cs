using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_pacientes
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public DataTable mostrarpaciente(string id)
        {

            SqlDataReader lee;
            DataTable tablaa = new DataTable();
            SqlCommand comandoo = new SqlCommand();
            comandoo.Connection = conexion.abrir();
            comandoo.CommandText = "Mostrarpac";
           comandoo.CommandType = CommandType.StoredProcedure;
           comandoo.Parameters.AddWithValue("@id",id);
            lee = comandoo.ExecuteReader();
            tablaa.Load(lee);
            conexion.cerrar();
            return tablaa;
        }

        public void insertarpac(string id,string nombre,string apellido, long telefono,int edad, string genero )
        {
            SqlCommand comandoo = new SqlCommand();
            comandoo.Connection = conexion.abrir();
            comandoo.CommandText = "IngresoPacientes";
            comandoo.CommandType = CommandType.StoredProcedure;
            comandoo.Parameters.AddWithValue("@id", id);
            comandoo.Parameters.AddWithValue("@nombre", nombre);
            comandoo.Parameters.AddWithValue("@apellido", apellido);
            comandoo.Parameters.AddWithValue("@telefono", telefono);
            comandoo.Parameters.AddWithValue("@edad", edad);
            comandoo.Parameters.AddWithValue("@genero", genero);
            comandoo.ExecuteNonQuery();

        }


        public void editarpac(string id, string nombre, string apellido, long telefono, int edad, string genero)
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "EditarPacientes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@edad", edad);
            comando.Parameters.AddWithValue("@genero", genero);
            comando.ExecuteNonQuery();

        }

        public DataTable listarpacientes()
        {
            DataTable tablaa = new DataTable();
            SqlCommand comandoo = new SqlCommand();
            comandoo.Connection = conexion.abrir();
            comandoo.CommandText = "Mostrarpacientes";
            comandoo.CommandType = CommandType.StoredProcedure;
            leer = comandoo.ExecuteReader();
            tablaa.Load(leer);
            leer.Close();
            conexion.cerrar();
            return tablaa;
        }
        }
}
