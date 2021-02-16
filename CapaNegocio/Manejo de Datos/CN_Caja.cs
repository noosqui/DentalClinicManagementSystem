using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Caja
    {
        CD_Caja objh = new CD_Caja();

        public DataTable mostrarcaja()
        {
            DataTable tabla = new DataTable();
            tabla = objh.mostrarcaja();
            return tabla;
        }

        public void insertarcaja(string tipo, string cantidad, string dd)
        {
            if (tipo == "ingreso") 
            objh.insertarcaja(tipo, int.Parse(cantidad),int.Parse(dd)+ int.Parse(cantidad));
            if(tipo== "egreso")
                objh.insertarcaja(tipo, int.Parse(cantidad), int.Parse(dd) - int.Parse(cantidad));
        }
    }
}
