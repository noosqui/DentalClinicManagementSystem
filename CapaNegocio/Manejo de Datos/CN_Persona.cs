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
    public class CN_Persona
    {
        private string id;
        private string nombre;
        private string apellido;
        private string telefono;
        private string genero;

        public CN_Persona(string id_,string nombre_,string apellido_,string telefono_,string genero_)
        {
            id = id_;
            nombre = nombre_;
            apellido = apellido_;
            telefono = telefono_;
            genero = genero_;

        }

        public CN_Persona(string id_)
        {
            id = id_;

        }
        public CN_Persona()
        {


        }

        public string id_
        {
            get { return id; }
            set { id = value; }
        }

        public string nombre_
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string genero_
        {
            get { return genero; }
            set { genero = value; }
        }
        public string apellido_
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string telefono_
        {
            get { return telefono; }
            set { telefono = value; }
        }


        public virtual void insertar()
        {

        }

        public virtual void editar()
        {
            
        }

    }
}
