using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Clinica_Dental_Familiar
{
    public partial class frminicio : Form
    {
        private string id;
   
        public frminicio(string id_)
        {
            InitializeComponent();
            id = id_;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
   
            lblhora.Text = DateTime.Now.ToString("hh:mm");
            lblhora.ForeColor = Color.FromArgb(3, 121, 113);
            
        }
        private void redimensionar()
        {
           
            lblbienvenida.MinimumSize = new Size(this.Width * 3 / 4, this.Width * 3 / 4);
            lblfecha.MinimumSize = new Size(this.Width / 4, this.Height /4);
            lblhora.MinimumSize= new Size(this.Width / 4, this.Height / 4);
            label2.MinimumSize = new Size(this.Width / 2, this.Height / 2);
        }
        private void frminicio_Load(object sender, EventArgs e)
        {
            DataTable tab = new DataTable();
            CN_Empleados emp = new CN_Empleados(id);
            tab = emp.empesp();


            lblfecha.Text = DateTime.Now.ToString("dddd, dd MMMMM yyyy");
            lblhora.Text = DateTime.Now.ToString("hh:mm");
            redimensionar();
            switch (tab.Rows[0][6].ToString())
            {
                case "Masculino":
                case "Otro":
                    lblbienvenida.Text = "Bienvenido Dr. " + tab.Rows[0]["apellido"].ToString(); 
                    break;
                case "Femenino":
                    lblbienvenida.Text = "Bienvenido Dra. " + tab.Rows[0]["apellido"].ToString();
                    break;
              

            }

        }

        private void frminicio_Resize(object sender, EventArgs e)
        {
            redimensionar();
        }

      

      
    }
}
