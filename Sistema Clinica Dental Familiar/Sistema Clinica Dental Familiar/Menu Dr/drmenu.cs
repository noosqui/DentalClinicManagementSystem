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

namespace Sistema_Clinica_Dental_Familiar
{
    
    public partial class mnudoctor : Form
    {


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
        public mnudoctor()
        {
            InitializeComponent();
           
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; //determina el maximo que se puede aumentar
           this.MaximizedBounds = new Rectangle(0,0,Screen.FromHandle(this.Handle).WorkingArea.Width-1, Screen.FromHandle(this.Handle).WorkingArea.Height-1);
            pnlsidemnu.MaximumSize = new Size(MaximizedBounds.Width/4, MaximizedBounds.Height);
        }
       /* public mnudoctor( frmaddusr addusr)
        {

        }*/

        /* public mnudoctor(frmeditusr edit)
          {
          }*/

       private BunifuFlatButton activebtn = null;
        private Panel activesubm = null;

        private void selecbtn(object sendbtn)
        {
            if (activebtn != null)
                deselectbtn();
            activebtn = (BunifuFlatButton)sendbtn;
            activebtn.colbackground = Color.FromArgb(107, 201, 195);
            activebtn.rimage.Image = activebtn.Iconimage;
            activebtn.Iconimage = null;
           

        }
        private void deactivsubm()
        {
            activesubm.Visible = false;
            activesubm = null;
        }
        private void deselectbtn()
        {
            activebtn.colbackground = Color.FromArgb(87, 165, 160);
            activebtn.Iconimage = activebtn.rimage.Image;
            activebtn.rimage.Image = null;
            activebtn.Active = false;
            
        }
        private void colorear (Color clr1, Color clr2,Color clr3)//funcion para cambiar de tema
      
        {
            
            pnlsidemnu.ForeColor = clr1;
            pnltop.ForeColor = clr2;
            this.ForeColor = clr3;

        }

      

        private void pnltop_MouseDown(object sender, MouseEventArgs e)
        {
     
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
            if (MousePosition.Y == 0)
            {
                this.WindowState = FormWindowState.Maximized;
    
            }
        }

        private void pnlwindbtn_MouseDown(object sender, MouseEventArgs e)
        {
            
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }

            if (MousePosition.Y==0)
            {
                this.WindowState = FormWindowState.Maximized;
        
            }

        }

        private void btnmaxim_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
              
                this.WindowState = FormWindowState.Normal;
  
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
      
            }
                
        }

        private void redimensionar ()
        {
           pnllogo.Height = this.Size.Height / 4; //cambia la altura del panel del logo
            pnlsidemnu.Width = this.Size.Width / 4; // cambia lo ancho del panel del submenu
          flatbtntrat.Height = this.Size.Height /9;
            fltbtnhome.Height = this.Size.Height /9;
            fltbtninv.Height=this.Size.Height /9;
            fltbtnpaciente.Height=this.Size.Height /9;
            fltbtnset.Height=this.Size.Height/9;
            fltbtncaja.Height = this.Size.Height/9;


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
            redimensionar();
            fltbtnhome_Click_1(fltbtnhome, new EventArgs());
        }

        private void mnudoctor_Resize(object sender, EventArgs e)
        {
            redimensionar();
            
        }

       


        private void pnltop_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {


                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                    redimensionar();
                }
                else
                {
                    this.WindowState = FormWindowState.Maximized;
                    redimensionar();
                }
            }
        }

        private void fltbtnhome_Click_1(object sender, EventArgs e)
        {
            selecbtn(sender);
            openchildform(new frminicio());
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
            openchildform(new frmajustes());
            selecbtn(sender);
        }
    }
}
