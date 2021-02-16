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

namespace Sistema_Clinica_Dental_Familiar
{
    public partial class frmtratamiento : Form

    {
        CN_pacientes objCN = new CN_pacientes();
        CN_Tratamiento objt = new CN_Tratamiento();
        CN_Historial objh = new CN_Historial();
        CN_Material objm = new CN_Material();
       
        public frmtratamiento()
        {
            InitializeComponent();
        }

        private void cmbpaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            if (cmbpaciente.Text == "System.Data.DataRowView")
            {

            }
            else { 
            CN_pacientes obj = new CN_pacientes(cmbpaciente.Text);
            tabla=obj.MostrarPac();
            txtnombre.Text = tabla.Rows[0]["nombre"].ToString()+ " " + tabla.Rows[0]["apellido"].ToString();
            
            }
        }

        private void frmtratamiento_Load(object sender, EventArgs e)
        {
            listapac();
            mostratatamiento();
            
        }

        private void listapac()
        {
            DataTable tabla = new DataTable();
            tabla = objCN.listarpacc();
            cmbpaciente.DataSource = tabla;
            cmbpaciente.DisplayMember = "id_p";
            cmbpaciente.ValueMember = "id_p" ;

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in tabla.Rows)
            {
                coleccion.Add(Convert.ToString(row["id_p"]));
            }

            cmbpaciente.AutoCompleteCustomSource = coleccion;
            cmbpaciente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbpaciente.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void mostratatamiento()
        {
            DataTable tabla = new DataTable();
            tabla = objt.mostrartratamientos();
            cmbtrat.DataSource = tabla;
            cmbtrat.DisplayMember = "nombre";
            cmbtrat.ValueMember = "nombre";

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in tabla.Rows)
            {
                coleccion.Add(Convert.ToString(row["nombre"]));
            }

            cmbtrat.AutoCompleteCustomSource = coleccion;
            cmbtrat.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbtrat.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void materiales()
        {
            dgvmateriales.DataSource = objh.usomaterial(cmbtrat.SelectedIndex+1);
        }

    
        private void cmbtrat_SelectedIndexChanged(object sender, EventArgs e)
        {
            materiales();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            objh.ingresoh(cmbpaciente.Text, DateTime.Now, cmbtrat.SelectedIndex + 1);
            foreach (DataGridViewRow row in dgvmateriales.Rows)
            {
                if (row.Cells["cantidad"].Value != null || row.Cells["nombre"].Value != null)
                    objm.actualizar(int.Parse(row.Cells["cantidad"].Value.ToString()), row.Cells["nombre"].Value.ToString());
            }
            MessageBox.Show("Historial guardado con éxito");

            CN_Caja caja = new CN_Caja();
            DataTable tab = new DataTable();
            tab = objt.tratamientoesp(cmbtrat.Text);
            DataRow[] rows = tab.Select();
            string cant = tab.Rows[0]["precio"].ToString();
           

            tab = caja.mostrarcaja();
          
            if (tab.Rows.Count>0)
            caja.insertarcaja("ingreso", cant, tab.Rows[tab.Rows.Count - 1]["dinero_dispobible"].ToString());
            else
                caja.insertarcaja("ingreso", cant,"0");
           



        }

        private void dgvmateriales_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtmaterial.Text = dgvmateriales.CurrentRow.Cells[0].Value.ToString();
            txtcantidad.Text = dgvmateriales.CurrentRow.Cells[1].Value.ToString();
        }


        int cant;
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            cant = Convert.ToInt32(txtcantidad.Text);
            txtcantidad.Enabled = true;
            btncancel.Enabled = true;
            btnedit.Enabled = false;
            dgvmateriales.Enabled = false;
            btnguardar.Enabled = true;
            txtcantidad.Focus();   
            

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            txtcantidad.Text = cant.ToString();
            btnedit.Enabled = true;
            btncancel.Enabled = false;
            dgvmateriales.Enabled = true;
            txtcantidad.Enabled = false;
            btnguardar.Enabled = false;

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            dgvmateriales.CurrentRow.Cells[1].Value = txtcantidad.Text;
            btnedit.Enabled = true;
            btncancel.Enabled = false;
            dgvmateriales.Enabled = true;
            txtcantidad.Enabled = false;
            btnguardar.Enabled = false;

        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
                SystemSounds.Exclamation.Play();
            }
        }


    }
}
