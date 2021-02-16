using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Material
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();
        DataTable tabla = new DataTable();

        public DataTable mostrarmaterial()
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "MostrarInventario";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.cerrar();
            return tabla;
        }

        public void actinv(int cantidad,string mat)
        {
            SqlCommand c = new SqlCommand();
            c.Connection = conexion.abrir();
            c.CommandText = "actCantidad";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.AddWithValue("@cantidad", cantidad);
            c.Parameters.AddWithValue("@mat", mat);
            c.ExecuteNonQuery();
        }

        public void cantnueva(int cantidad, string mat)
        {
            SqlCommand c = new SqlCommand();
            c.Connection = conexion.abrir();
            c.CommandText = "actmaterial";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.AddWithValue("@cantidad", cantidad);
            c.Parameters.AddWithValue("@material", mat);
            c.ExecuteNonQuery();
        }


    }
}
