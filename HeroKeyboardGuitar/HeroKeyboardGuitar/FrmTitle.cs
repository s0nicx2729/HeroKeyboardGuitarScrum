using System;
using System.Windows.Forms;

namespace HeroKeyboardGuitar;

internal partial class FrmTitle : Form
{
    public FrmTitle()
    {
        InitializeComponent();
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        FrmSongSelect frmSongSelect = new();
        frmSongSelect.Show();
    }

    private void FrmTitle_Load(object sender, EventArgs e)
    {
        //btnStart.Left = Width / 2 - btnStart.Width / 2;
        //btnStart.Top = (int)(Height * 0.65);
    }

    private void HowTo_Click(object sender, EventArgs e)
    {
        Controls frmHowTo = new();
        frmHowTo.Show();
    }

    private void btnControls_Click(object sender, EventArgs e)
    {
        FrmKeyboard frmKeyboard = new();
        frmKeyboard.Show();
    }
}
