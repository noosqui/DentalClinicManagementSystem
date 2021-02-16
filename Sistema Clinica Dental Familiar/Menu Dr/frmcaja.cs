using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using Sistema_Clinica_Dental_Familiar.Reportes;

namespace Sistema_Clinica_Dental_Familiar
{
    public partial class frmcaja : Form
    { 
        public frmcaja()
        {
            InitializeComponent();
        }
        CN_Caja objc = new CN_Caja();
      

        private void btntrans_Click(object sender, EventArgs e)
        {
            lblcantidad.Visible = true;
            txtcantidad.Visible = true;
            grbtipo.Visible = true;
            btnsave.Enabled = true;
            btntrans.Enabled = false;

        }

        private void frmcaja_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = objc.mostrarcaja();
            dgvtrans.DataSource = tabla;
            if(tabla.Rows.Count>0)
            txtdinero.Text= tabla.Rows[tabla.Rows.Count-1]["dinero_dispobible"].ToString();
            else
                txtdinero.Text = "0";
            dgvtrans.Columns[0].HeaderText = "ID";
            dgvtrans.Columns[1].HeaderText = "Tipo transacción";
            dgvtrans.Columns[2].HeaderText = "Cantidad";
            dgvtrans.Columns[3].HeaderText = "Fecha";
            dgvtrans.Columns[4].HeaderText = "Dinero disponible";

            btnsave.IconZoom = 70;
            btnreport.IconZoom = 70;
            btntrans.IconZoom = 70;

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            
            if ((rdbingreso.Checked)&&(int.Parse(txtcantidad.Text)>0))
            {
                objc.insertarcaja("ingreso", txtcantidad.Text, txtdinero.Text);
                MessageBox.Show("Transacción realizada correctamente");
            }
            if (rdbegreso.Checked)
            {    
                if((int.Parse(txtdinero.Text)- int.Parse(txtcantidad.Text)) >= 0) { 
                objc.insertarcaja("egreso", txtcantidad.Text, txtdinero.Text);
                    MessageBox.Show("Transacción realizada correctamente");
                }
                else
                {
                    MessageBox.Show("Monto excede el dinero disponible");
                }
            }
            
            DataTable tabla = new DataTable();
            tabla = objc.mostrarcaja();
            dgvtrans.DataSource = tabla;
            txtdinero.Text = tabla.Rows[tabla.Rows.Count-1]["dinero_dispobible"].ToString();
            txtcantidad.Clear();
            lblcantidad.Visible = false;
            txtcantidad.Visible = false;
            grbtipo.Visible = false;
            btnsave.Enabled = false;
            btntrans.Enabled = true;

        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            frmReportecaja frm = new frmReportecaja();
            frm.Show();
        }

        private void frmcaja_Resize(object sender, EventArgs e)
        {

          
            btnsave.IconZoom = 75;
            btnreport.IconZoom = 80;
            btntrans.IconZoom = 80;
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e) //---------validacion numero
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            { 
                e.Handled = true;
            SystemSounds.Exclamation.Play();
        }

        }
    }
}
