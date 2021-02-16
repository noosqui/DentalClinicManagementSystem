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
    public class CN_Tratamiento
    {
        private CD_Tratamiento trata = new CD_Tratamiento();

        public DataTable mostrartratamientos()
        {
            DataTable tabla = new DataTable();
            tabla = trata.mostrartratamiento();
            return tabla;
        }

        public DataTable mostrarUsos(string idm)
        {
            DataTable tabla = new DataTable();
            tabla = trata.mostraruso(Convert.ToInt32(idm));
            return tabla;
        }
        public DataTable tratamientoesp (string nombre)
        {
            DataTable tabla = new DataTable();
            return tabla = trata.tratamientoesp(nombre);
            
        }
    }
}
