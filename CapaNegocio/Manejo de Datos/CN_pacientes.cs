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
    public class CN_pacientes:CN_Persona
    {
        public string edad;
        public string genero;
        private CD_pacientes obcd = new CD_pacientes();
        //Constructor

        public CN_pacientes(string id_, string nombre_, string apellido_, string telefono_, string edad_, string genero_ ) 
                :base (id_, nombre_, apellido_, telefono_,genero_)
        {
            edad = edad_;
        }

        public CN_pacientes() { }

        public CN_pacientes(string id_) : base(id_) { }


    

        public DataTable MostrarPac()
        {
            DataTable tabla = new DataTable();
            tabla = obcd.mostrarpaciente(id_);
            return tabla;
        }

        public override void insertar()
        {
            obcd.insertarpac(id_,nombre_, apellido_, long.Parse(telefono_), int.Parse(edad), genero_);
        }

        public override void editar()
        {
            obcd.editarpac(id_, nombre_, apellido_, long.Parse(telefono_), int.Parse(edad), genero_);
        }

        public DataTable listarpacc()
        {
            DataTable tabla = new DataTable();
            tabla = obcd.listarpacientes();
            return tabla;
        }
    }

    
}
