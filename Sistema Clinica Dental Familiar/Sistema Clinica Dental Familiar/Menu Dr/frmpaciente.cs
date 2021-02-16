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
    public partial class frmpaciente : Form
    {
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
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            tabctrl.SelectedTab = pgagregar;
        }

        

       
    }
}
