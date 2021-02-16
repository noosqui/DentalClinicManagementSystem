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
    public partial class frmpaciente : Form
    {
        
        CN_Historial objh = new CN_Historial();

        public frmpaciente()
        {
            InitializeComponent();
            tabctrl.Appearance = TabAppearance.FlatButtons;
            tabctrl.ItemSize = new Size(0, 1);
            tabctrl.SizeMode = TabSizeMode.Fixed;

        }


        private void btnback_Click(object sender, EventArgs e)
        {
            tabctrl.SelectedTab = pgselec;
        }

        private void btnback2_Click_1(object sender, EventArgs e)
        {
            tabctrl.SelectedTab = pgselec;
        }

        private void btnver_Click_1(object sender, EventArgs e)
        {
            tabctrl.SelectedTab = pgver;
            listapac();
        }

        private void listapac()
        {
            CN_pacientes objCN = new CN_pacientes();
            DataTable tabla = new DataTable();
            tabla = objCN.listarpacc();
            cmbpaciente.DataSource = tabla;
            cmbpaciente.DisplayMember = "id_p";
            cmbpaciente.ValueMember = "id_p";

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in tabla.Rows)
            {
                coleccion.Add(Convert.ToString(row["id_p"]));
            }

            cmbpaciente.AutoCompleteCustomSource = coleccion;
            cmbpaciente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbpaciente.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            tabctrl.SelectedTab = pgagregar;
        }

        private void btnguardarpac_Click(object sender, EventArgs e)
        {
            if (cmbgenero.SelectedItem != null)
            {
                CN_pacientes objCN_ = new CN_pacientes(txtidentidad0.Text, txtnombre0.Text, txtapellido0.Text, txttel0.Text, txtedad0.Text, cmbgenero.Text);

                try
                {
                    objCN_.insertar();
                    MessageBox.Show("Se inserto correctamente");
                    txtnombre0.Clear();
                    txtapellido0.Clear();
                    txtidentidad0.Clear();
                    txtedad0.Clear();
                    cmbgenero.SelectedIndex = 0;
                    txttel0.Clear();
                    txtnombre.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se produjo el error " + ex);
                }
            }
           
        }

      
        public string id = "";
        private void cmbpaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int indice = cmbpaciente.SelectedIndex;
            id = cmbpaciente.Text;
            if (id == "System.Data.DataRowView")
            {
            }
            else
            {
                // MessageBox.Show(id);
                CN_pacientes objCN_= new CN_pacientes(id);
                DataTable tabla = new DataTable();
                tabla = objCN_.MostrarPac();
                txtnombre.Text = tabla.Rows[0]["nombre"].ToString();
                txtapellido.Text = tabla.Rows[0]["apellido"].ToString();
                txttel.Text = tabla.Rows[0]["telefono"].ToString();
                txtedad.Text = tabla.Rows[0]["edad"].ToString();
                txtgen.Text = tabla.Rows[0]["genero"].ToString();
                txtidentidad.Text = tabla.Rows[0]["id_p"].ToString();
                dgvhistoria.DataSource = objh.muestrahisto(cmbpaciente.Text);
                dgvhistoria.Columns[0].HeaderText = "ID Paciente";
                dgvhistoria.Columns[1].HeaderText = "Tratamiento";
                dgvhistoria.Columns[2].HeaderText = "Fecha";
            }
           
            
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if(cmbpaciente.SelectedIndex!=-1)
            {
                txtapellido.Enabled = true;
                txtnombre.Enabled = true;
                txtedad.Enabled = true;
                txttel.Enabled = true;
                cmbpaciente.Enabled = false;
                btnguardaredit.Enabled = true;
                btncancel.Enabled = true;
                btnedit.Enabled = false;
            }
            
        }

        private void btnguardaredit_Click(object sender, EventArgs e)
        {

            try
            {

                CN_pacientes objCN_ = new CN_pacientes(txtidentidad.Text, txtnombre.Text, txtapellido.Text, txttel.Text, txtedad.Text, txtgen.Text);
                objCN_.editar();
                MessageBox.Show("Se edito correctamente");
                btnguardaredit.Enabled = false;
                btncancel.Enabled = false;
                txtapellido.Enabled = false;
                txtnombre.Enabled = false;
                txtedad.Enabled = false;
                txtgen.Enabled = false;
                txttel.Enabled = false;
                cmbpaciente.Enabled = true;
                btnedit.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el error " + ex);
            }
        }

      

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtapellido.Enabled = false;
            txtnombre.Enabled = false;
            txtedad.Enabled = false;
            txttel.Enabled = false;
            cmbpaciente.Enabled =true;
            btnguardaredit.Enabled = false;
            btncancel.Enabled =false;
            btnedit.Enabled = true;
        }

        private void txttel0_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
                SystemSounds.Exclamation.Play();
            }
        }

        private void txtidentidad0_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
                SystemSounds.Exclamation.Play();
            }
        }

        private void txtedad0_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
                SystemSounds.Exclamation.Play();
            }
        }

  
        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
                SystemSounds.Exclamation.Play();
            }
        }

        private void txtedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
                SystemSounds.Exclamation.Play();
            }
        }

        private void txtidentidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                SystemSounds.Exclamation.Play();
            }
        }

     
    }
      
    }

