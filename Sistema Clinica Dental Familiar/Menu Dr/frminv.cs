using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
using System.Data.SqlClient;
using Sistema_Clinica_Dental_Familiar.Reportes;
using System.CodeDom.Compiler;
using System.Media;

namespace Sistema_Clinica_Dental_Familiar
{
    public partial class frminv : Form
    {
       
        CN_Material objCN = new CN_Material();
        CN_Tratamiento objt = new CN_Tratamiento();
        DataTable tabla = new DataTable();
     
        public frminv()
        {
            InitializeComponent();
        }

        private void frminv_Load(object sender, EventArgs e)
        {
            mostrarmaterial();
            dgvmaterial[0, 0].Selected = true;
            txtmaterial.Text = dgvmaterial.SelectedRows[0].Cells["Nombre"].Value.ToString();
            txtcantidad.Text = dgvmaterial.SelectedRows[0].Cells[2].Value.ToString();
            mostrarTratamiento();
           
        }
     

        private void mostrarmaterial()
        {
            CN_Material obj = new CN_Material();
            dgvmaterial.DataSource = obj.mostrarmate();
            dgvmaterial.Columns[0].HeaderText = "Código";
            dgvmaterial.Columns[1].HeaderText = "Nombre";
            dgvmaterial.Columns[2].HeaderText = "Cantidad Disponible";
            
            
        }
       
        private void mostrarTratamiento()
        {

            dgvtratamientos.DataSource = objt.mostrarUsos(dgvmaterial.SelectedRows[0].Cells[0].Value.ToString());
            dgvtratamientos.Refresh();
            dgvtratamientos.Columns[0].HeaderText = "Nombre";
             dgvtratamientos.Columns[1].HeaderText = "Precio";
            dgvtratamientos.Columns[2].HeaderText = "Cantidad";
            
        }



        private void btnreport_Click(object sender, EventArgs e)
        {
            frmReporteinv frm = new frmReporteinv();
            frm.Show();
        }

      
      
        private void btnreabastecer_Click(object sender, EventArgs e)
        {
           
     
            txtcantidad.Enabled = true;
            btnsave.Enabled = true;
            dgvmaterial.Enabled = false;
            btncancel.Enabled = true;

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
           
                txtcantidad.Enabled = false;
                btnsave.Enabled = false;
                dgvmaterial.Enabled = true;
            btncancel.Enabled = false;
            objCN.cantnueva(txtcantidad.Text, txtmaterial.Text);
            mostrarmaterial();



        }

        private void dgvmaterial_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvmaterial.Columns[e.ColumnIndex].Index==2)
            {
                if (Convert.ToInt32(e.Value) <= 50)

                    e.CellStyle.ForeColor = Color.Red;
                  
            }
        }

        private void dgvmaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmaterial.Text = dgvmaterial.SelectedRows[0].Cells["Nombre"].Value.ToString();
            txtcantidad.Text = dgvmaterial.SelectedRows[0].Cells[2].Value.ToString();
            mostrarTratamiento();
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
                SystemSounds.Exclamation.Play();
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtcantidad.Enabled = false;
            btnsave.Enabled = false;
            dgvmaterial.Enabled = true;
            btncancel.Enabled = false;
        }
    }
}
