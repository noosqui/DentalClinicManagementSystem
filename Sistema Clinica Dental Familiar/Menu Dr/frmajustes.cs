using CapaNegocio;
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

namespace Sistema_Clinica_Dental_Familiar.Menu_Dr
{
    public partial class frmajustes : Form
    {
        public DataTable tab = new DataTable();
        CN_Empleados empleados = new CN_Empleados();
        string id;
        public frmajustes(string id_)
        {
            InitializeComponent();
            id = id_;
            empleados = new CN_Empleados(id);
            tab = empleados.empesp();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            bool verif = true;
            foreach (Control txt in tabPage2.Controls)
            {
               if (txt is TextBox)
                { 
                    
                    if (string.Equals(txt.Text, ""))
                    {
                        verif = false;

                        break;

                    }
                }
               
            }

            if (string.Equals(txtcontraseñaag.Text, txtconfcontraag.Text) && string.Equals(txtcorreoag.Text, txtconfcorreoag.Text)&&verif&&cmbsexag.SelectedIndex>-1)
            {

                CN_Empleados empleado = new CN_Empleados(txtidag.Text, txtnombreag.Text, txtapellidoag.Text, txttelag.Text, txtcorreoag.Text, "Dr", txtcontraseñaag.Text,cmbsexag.Text );
                if (string.Equals(empleados.puesto, "Admin") && MessageBox.Show("Desea darle privilegios de administrador a este usuario?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    empleado.puesto = "Admin";
                
                empleado.insertar();
                MessageBox.Show("Usuario agregado con exito");

            }
            else
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("Ingrese los datos indicados");
            }

            foreach (Control txt in tabPage2.Controls)
            {
                if (txt is TextBox)
                {
                    txt.Text = "";
                }
             }

            if (txtconfcontraag.Text != txtcontraseñaag.Text)
            {
                MessageBox.Show("Contraseñas no coinciden");
            }

            if (txtcorreoag.Text != txtconfcorreoag.Text)
            {
                MessageBox.Show("Los correos no coinciden");
            }


            
        }

        private void btnpass_Click(object sender, EventArgs e)
        {

            txtnuevapass.Enabled = true;
            
        }

        private void btncanceledit_Click(object sender, EventArgs e)
        {
            txtnuevapass.Enabled = false;
            txtnuevapass.Clear();
        }

        private void btnact_Click(object sender, EventArgs e)
        {
            if (string.Equals(txtcontraedt.Text,tab.Rows[0][7].ToString())&&cmbsexed.SelectedIndex>-1)
            {
                empleados.id_ = txtided.Text;
                empleados.nombre_ = txtnombreed.Text;
                empleados.apellido_ = txtapellidoed.Text;
                empleados.telefono_ = txtteled.Text;
                empleados.correo = txtcorreoed.Text;
                empleados.genero_ = cmbsexed.Text;

                if (txtnuevapass.Enabled)
                    empleados.contraseña = txtnuevapass.Text;
                else
                    empleados.contraseña = txtcontraedt.Text;
                empleados.puesto = tab.Rows[0][5].ToString();

                MessageBox.Show("Se ha editado con exito");

                empleados.editar();
                tabControl1.SelectedIndex = 0;
            }

        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*0 id
        * 1 nombre
        * 2 apellido
        * 3 telefono
        * 4 correo
        * 5 puesto
        * 6 contraseña
        * 
        * */
            tab = empleados.empesp();



            if (tabControl1.SelectedIndex==2)
            {
                txtided.Text = tab.Rows[0][0].ToString();
                txtnombreed.Text = tab.Rows[0][1].ToString();
                txtapellidoed.Text = tab.Rows[0][2].ToString();
                txtteled.Text = tab.Rows[0][3].ToString();
                txtcorreoed.Text = tab.Rows[0][4].ToString();

                switch(tab.Rows[0][6].ToString())
                {
                    case "Masculino":
                        cmbsexed.SelectedIndex = 0;
                        break;
                    case "Femenino":
                        cmbsexed.SelectedIndex = 1;
                        break;
                    case "Otro":
                        cmbsexed.SelectedIndex = 2;
                        break;

                }

            }

        }

        private void frmajustes_Load(object sender, EventArgs e)
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }

        private void btnaddusr_Click(object sender, EventArgs e)
        {
            if (string.Equals(tab.Rows[0][5].ToString(), "Admin"))
                tabControl1.SelectedIndex = 1;
            else
                MessageBox.Show("No tiene los suficientes permisos para realizar esta accion, consulte con una cuenta de administrador para poder ingresar", "Aviso");
        }

        private void btneditusr_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro desea brindarle privilegios a este usuario?","Warning",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                id = cmbempleado.Text;
                CN_Empleados objCN_ = new CN_Empleados(id);
                objCN_.derechos();
                
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro desea eliminar a este usuario?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                id = cmbempleado.Text;
                CN_Empleados objCN_ = new CN_Empleados(id);
                objCN_.eliminar();
                listaemp();
                


            }

            
        }

        private void btnverusr_Click(object sender, EventArgs e)
        {
            if (string.Equals(tab.Rows[0][5].ToString(), "Admin")) { 
                tabControl1.SelectedIndex = 3;
                listaemp();
                
            }
            else
                MessageBox.Show("No tiene los suficientes permisos para realizar esta accion, consulte con una cuenta de administrador para poder ingresar", "Aviso");
        }


        private void listaemp()
        {
            CN_Empleados objCN = new CN_Empleados();
            DataTable tabla = new DataTable();
            tabla = objCN.muestraemp();
            cmbempleado.DataSource = tabla;
            cmbempleado.DisplayMember = "id_e";
            cmbempleado.ValueMember = "id_e";

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in tabla.Rows)
            {
                coleccion.Add(Convert.ToString(row["id_e"]));
            }

            cmbempleado.AutoCompleteCustomSource = coleccion;
            cmbempleado.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbempleado.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

      
        private void cmbempleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            id = cmbempleado.Text;
            if (id == "System.Data.DataRowView")
            {
            }
            else
            {
                CN_Empleados objCN_ = new CN_Empleados(id);
                DataTable tabla = new DataTable();
                tabla = objCN_.empesp();
                txtnombreu.Text = tabla.Rows[0]["nombre"].ToString();
                txtapellidou.Text = tabla.Rows[0]["apellido"].ToString();
                txtcorreou.Text = tabla.Rows[0]["correo"].ToString();
                if (tabla.Rows[0]["puesto"].ToString() == "Admin") { 
                    btnadmin.Enabled = false;
                }
                else
                    btnadmin.Enabled = true;
            }
        }


        #region Validaciones

         
        private void txtteled_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txttelag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtidag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        #endregion

    }
}
