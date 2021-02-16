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
    public class CN_Empleados:CN_Persona
    {

        public string correo;
        public string puesto;
        public string contraseña;
        
        private CD_empleados obje = new CD_empleados();

        public CN_Empleados(string id_, string nombre_, string apellido_, string telefono_, string correo_, string puesto_,string contraseña_,string genero_):base (id_, nombre_, apellido_, telefono_,genero_)
        {
            correo = correo_;
           puesto = puesto_;
            contraseña = contraseña_;
        }

        public CN_Empleados(string _id):base(_id)
        {
            
        }
        public CN_Empleados() { }

        public CN_Empleados(string id_,string contraseña_) : base(id_) {
            contraseña = contraseña_;
        }

        public DataTable muestraemp()
        {
            DataTable tab = new DataTable();
            tab = obje.mostrarempleado();
            return tab;
        }
        public SqlDataReader verifica ()
        {
            return (obje.verifica(id_, contraseña));
        }

        public DataTable empesp()
        {
            DataTable tab = new DataTable();
            tab = obje.empesp(id_);
                return tab;
        }

        public override void insertar()
        {
            obje.ingresarempleado(id_, nombre_,apellido_,long.Parse(telefono_), correo, puesto, contraseña,genero_);
        }
        public override void editar()
        {
            obje.editarempleado(id_, nombre_, apellido_, long.Parse(telefono_), correo, puesto, contraseña,genero_);
        }
        public void eliminar()
        {
            obje.eliminarempleado(id_);
        }
        public void derechos()
        {
            obje.derechos(id_);
        }
    }
}
