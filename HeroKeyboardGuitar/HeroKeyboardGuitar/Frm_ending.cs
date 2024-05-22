using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroKeyboardGuitar
{
    public partial class Frm_ending : Form
    {
        public Frm_ending()
        {
            InitializeComponent();
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new();
            frmMain.Show();
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
