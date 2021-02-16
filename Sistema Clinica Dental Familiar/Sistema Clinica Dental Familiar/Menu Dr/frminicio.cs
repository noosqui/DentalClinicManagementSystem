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
        public frminicio()
        {
            InitializeComponent();
            lblfecha.Text = DateTime.Now.ToString("dddd, dd MMMMM yyyy");
            lblhora.Text = DateTime.Now.ToString("hh:mm");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // lblhora.ForeColor = Color.White;
            
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
            redimensionar();
        }

        private void frminicio_Resize(object sender, EventArgs e)
        {
            redimensionar();
        }
    }
}
