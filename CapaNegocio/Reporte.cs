using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Reporte
    {
    
       public CD_Caja caja = new CD_Caja();
        public CD_Material invent = new CD_Material();
        
   
        private DataTable tabtmp = null;
       
       


        public List<ReporteCaja> reporteCajas ()
            {
            List<ReporteCaja> listmp = new List<ReporteCaja>();
            tabtmp = caja.mostrarcaja(); 
            foreach(DataRow row in tabtmp.Rows)
            {
                     ReporteCaja ReporteCaja = new ReporteCaja();
                     ReporteCaja.tipo = row[1].ToString();
                    ReporteCaja.cant = int.Parse(row[2].ToString());
                ReporteCaja.dat = row[3].ToString();
                    listmp.Add(ReporteCaja);
                  
               
            }

            return listmp;
            }

        public List<ReporteInventario> reporteInventarios()
        {
            List<ReporteInventario> listmp = new List<ReporteInventario>();
            tabtmp = invent.mostrarmaterial();
            
            foreach (DataRow row in tabtmp.Rows)
            {
                     ReporteInventario reporteInventario = new ReporteInventario();
                     reporteInventario.id = int.Parse(row[0].ToString());
                    reporteInventario.nombre = row[1].ToString();
                    reporteInventario.cantidad = int.Parse(row[2].ToString());
                
                    listmp.Add(reporteInventario);
                
               
            }

            return listmp;
        }
    }
}
