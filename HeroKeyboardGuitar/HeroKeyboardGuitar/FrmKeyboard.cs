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
    /// Form that allows the user to set the keys for the left and right punch
    /// </summary>
    public partial class FrmKeyboard : Form
    {
        public static char setLKey = 'a';
        public static char setRKey = 'd';
        public FrmKeyboard()
        {
            InitializeComponent();
        }

        private void SubmitLeft_Click(object sender, EventArgs e)
        {
            setLKey = Convert.ToChar(LeftPunch.Text);
        }

        private void SubmitRight_Click(object sender, EventArgs e)
        {
            setRKey = Convert.ToChar(RightPunch.Text);
        }
    }
}
