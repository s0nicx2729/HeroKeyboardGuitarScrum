using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HeroKeyboardGuitar
{
    public partial class Frm_win : Form
    {
        public Score GameScore { get; set; }
        string highscore;
        public Frm_win()
        {
            InitializeComponent();
            this.Shown += new EventHandler(Frm_win_Shown);

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
        private void Frm_win_Shown(object sender, EventArgs e)
        {

            highscore = File.ReadAllText(Properties.Resources.Highscore);

            if (GameScore.Amount > Convert.ToInt32(highscore))
            {
                highscore = GameScore.Amount.ToString();
                File.WriteAllText(Properties.Resources.Highscore, highscore);
            }


            label1.Text = "Score:   " + GameScore.Amount;
            label2.Text = "Accuracy:   " + GameScore.Accuracy + "%";
            label3.Text = "Highscore:";
            label4.Text = highscore;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
