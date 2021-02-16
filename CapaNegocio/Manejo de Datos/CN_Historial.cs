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
    public class CN_Historial
    {
        CD_Historial objh = new CD_Historial();

        public void ingresoh(string idp,DateTime date,long idt)
        {
            objh.ingresHistorial(idp, date, idt);
        }

        public DataTable usomaterial(long id)
        {
            DataTable tabla = new DataTable();
            tabla = objh.matnec(id);
            return tabla;
        }

        public DataTable muestrahisto(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objh.histoshow(id);
            return tabla;
        }
    }
}
