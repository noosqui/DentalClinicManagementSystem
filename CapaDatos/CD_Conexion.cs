﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace CapaDatos
{
    public class CD_Conexion
    {
        
        private SqlConnection Conectarbd = new SqlConnection("server=(local);DataBase= clinica;Integrated Security=True");

        public SqlConnection abrir()
        {
            
                if (Conectarbd.State ==ConnectionState.Closed)
                    Conectarbd.Open();

                return Conectarbd;
             }

        public SqlConnection cerrar()
        {
            if (Conectarbd.State == ConnectionState.Open)
                Conectarbd.Close();
            return Conectarbd;
        }

      

    }
}
