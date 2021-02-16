using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Bunifu.Framework.UI;
using Sistema_Clinica_Dental_Familiar.Properties;
using Sistema_Clinica_Dental_Familiar.Menu_Dr;
using System.Data.SqlClient;


namespace Sistema_Clinica_Dental_Familiar
{
    
    public partial class mnudoctor : Form
    {
        public string id;
        private BunifuFlatButton activebtn = null;

        // constantes para poder arrastrar la ventana
        #region cosas para el arrastre
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                        int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion
   
        public mnudoctor(string id_)
        {
            InitializeComponent();

            id = id_;
        }


        private void selecbtn(object sendbtn)
        {
            if (activebtn != null)
                deselectbtn();
            activebtn = (BunifuFlatButton)sendbtn;
            activebtn.colbackground = Color.FromArgb(107, 201, 195);
            activebtn.rimage.Image = activebtn.Iconimage;
            activebtn.Iconimage = null;
        }
      
        private void deselectbtn()
        {
            activebtn.colbackground = Color.FromArgb(87, 165, 160);
            activebtn.Iconimage = activebtn.rimage.Image;
            activebtn.rimage.Image = null;
            activebtn.Active = false;
            
        }
        #region Funciones de la barra superior del formulario 
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pnltop_MouseDown(object sender, MouseEventArgs e)
        {
     
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
       
        }

        private void pnlwindbtn_MouseDown(object sender, MouseEventArgs e)
        {
            
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }

        }

        private void btnmaxim_Click_1(object sender, EventArgs e)
        {
           
            SystemSounds.Exclamation.Play();
                
        }
       
        

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mnudoctor_Load(object sender, EventArgs e)
        {
  
            fltbtnhome_Click_1(fltbtnhome, new EventArgs());
        }

        #endregion

        #region chidlforms
        private void fltbtnhome_Click_1(object sender, EventArgs e)
        {
            selecbtn(sender);
            frminicio inicio = new frminicio(id);
                inicio.Owner = this;
            openchildform(inicio);
        }
        private Form activeform = null;

        private void openchildform(Form childform)
        {
            if(activeform!=null)
                activeform.Close();

                activeform = childform;
                childform.TopLevel = false;
                childform.FormBorderStyle = FormBorderStyle.None;
                childform.Dock = DockStyle.Fill;
                pnlchildform.Controls.Add(childform);
                pnlchildform.Tag = childform;
                childform.BringToFront();
                childform.Show();
            
        }
       
        
        
      
        private void flatbtntrat_Click(object sender, EventArgs e)
        {
            selecbtn(sender);
            openchildform(new frmtratamiento());
        }

        private void fltbtnpaciente_Click(object sender, EventArgs e)
        {
            selecbtn(sender);
            openchildform(new frmpaciente());

        }

        private void fltbtninv_Click(object sender, EventArgs e)
        {
            openchildform(new frminv());
            selecbtn(sender);
        }

        private void fltbtncaja_Click(object sender, EventArgs e)
        {
            openchildform(new frmcaja());
            selecbtn(sender);
        }

        private void fltbtnset_Click(object sender, EventArgs e)
        {
            
            openchildform(new frmajustes(id));
         
            selecbtn(sender);
        }
        #endregion

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if(pnlsidemnu.Width==55)
            {
                //expande el menu
                pnlsidemnu.Visible = false;
                logodcms.Visible = true;
                pnlsidemnu.Width = 280;
                animacionmnu.ShowSync(pnlsidemnu);
                fltbtncaja.Text = "Caja";
                fltbtnhome.Text = "Inicio";
                fltbtninv.Text = "Inventario";
                fltbtnpaciente.Text = "Paciente";
                fltbtnset.Text = "Ajustes";
                flatbtntrat.Text = "Tratamiento";
                btnlogout.Visible = true;
               
                
            }
            else
            {
                //esconde
                pnlsidemnu.Visible = false;
                logodcms.Visible = false;
                pnlsidemnu.Width = 55;
                animacionmnu.ShowSync(pnlsidemnu);
            
         
                foreach (Control ctrl in pnlsidemnu.Controls)
                {
                    if (ctrl is BunifuFlatButton)
                    {
                        ctrl.Text = "";
                    }
                }
            }

        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro que quiere cerrar la sesion actual?","Aviso",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                loginmnu mnu = new loginmnu();
                this.Close();
                mnu.Show();

            }
        }

      
    }
}
