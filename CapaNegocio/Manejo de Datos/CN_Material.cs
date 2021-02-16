using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Material
    {
        private CD_Material mate = new CD_Material();

        public DataTable mostrarmate()
        {
            DataTable tabla = new DataTable();
            tabla = mate.mostrarmaterial();
            return tabla;
        }

        public void actualizar(int cantidad,string mat)
        {
            mate.actinv(cantidad,mat);
        }

        public void cantnueva(string cantidad, string mat)
        {
            mate.cantnueva(int.Parse(cantidad), mat);
        }

    }
}
