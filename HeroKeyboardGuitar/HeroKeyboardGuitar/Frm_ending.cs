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
    /// <summary>
    /// Form that displays the defeat screen
    /// </summary>
    public partial class Frm_ending : Form
    {
        public Frm_ending()
        {
            InitializeComponent();
            TopMost = true;
        }

        private void Btn_restart_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new();
            frmMain.Show();
            this.Close();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
