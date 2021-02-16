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
using Microsoft.Reporting.WinForms;
using System.Runtime.InteropServices;

namespace Sistema_Clinica_Dental_Familiar.Reportes
{
    public partial class frmReporteinv : Form
    {
        #region cosas para el arrastre
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                        int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion
        public frmReporteinv()
        {
            
            InitializeComponent();
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            Reporte report = new Reporte();

            ReporteInventarioBindingSource.DataSource = report.reporteInventarios();
         
            this.reportViewer1.RefreshReport();
        }

        private void pnltop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
           
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
