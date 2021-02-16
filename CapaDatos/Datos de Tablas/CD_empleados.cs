using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_empleados
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;

        DataTable tabla = new DataTable();

        public SqlDataReader verifica(string user, string pass)
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            comando.Connection = conexion.abrir();
            comando.CommandText = "autent";
            comando.Parameters.AddWithValue("@user", user);
            comando.Parameters.AddWithValue("@pass", pass);
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();

            return leer;

        }

        public DataTable mostrarempleado()
        {
            SqlDataReader lee;
            DataTable tablaa = new DataTable();
            SqlCommand comandoo = new SqlCommand();
            comandoo.Connection = conexion.abrir();
            comandoo.CommandText = "MostrarEmpleados";
            comandoo.CommandType = CommandType.StoredProcedure;
            lee = comandoo.ExecuteReader();
            tablaa.Load(lee);
            conexion.cerrar();
            return tablaa;
        }

        public void ingresarempleado(string id, string nombre, string apellido, long telefono, string correo, string puesto, string contra, string genero)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.abrir();
            comando.CommandText = "IngresoEmpleados";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@puesto", puesto);
            comando.Parameters.AddWithValue("@contraseña", contra);
            comando.Parameters.AddWithValue("@genero", genero);

            comando.ExecuteNonQuery();
        }

        public void editarempleado(string id, string nombre, string apellido, long telefono, string correo, string puesto, string contra, string genero)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.abrir();
            comando.CommandText = "EditarEmpleados";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@puesto", puesto);
            comando.Parameters.AddWithValue("@contraseña", contra);
            comando.Parameters.AddWithValue("@genero", genero);
            comando.ExecuteNonQuery();
        }
        public DataTable empesp(string id)
        {
            SqlDataReader lee;
            DataTable tablaa = new DataTable();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.abrir();
            comando.CommandText = "empesp";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@user", id);
            comando.ExecuteNonQuery();
            lee = comando.ExecuteReader();
            tablaa.Load(lee);
            conexion.cerrar();
            return tablaa;
        }
        public void eliminarempleado(string id)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.abrir();
            comando.CommandText = "EliminarEmp";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
        }

        public void derechos(string id)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.abrir();
            comando.CommandText = "derechos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
        }


    }
}
