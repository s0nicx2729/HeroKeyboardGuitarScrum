using HeroKeyboardGuitar.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HeroKeyboardGuitar;

public partial class FrmMain : Form {
    private List<PictureBox> notes;
    private const float noteSpeed = 0.5f;
    private Song curSong;

    // for double buffering
    protected override CreateParams CreateParams {
        get {
            var cp = base.CreateParams;
            cp.ExStyle |= 0x02000000;    // Turn on WS_EX_COMPOSITED
            return cp;
        }
    }

    public FrmMain() {
        InitializeComponent();
    }

    public void FrmMain_Load(object sender, EventArgs e) {
        lblScore.Text = "0";
        panBg.BackgroundImage = Game.GetInstance().GetBg();
        panBg.Height = (int)(Height * 0.8);
        curSong = Game.GetInstance().CurSong;
        notes = new();
        foreach (var actionTime in curSong.Audio.ActionTimes) {
            double x = actionTime * noteSpeed + picTarget.Left + picTarget.Width;
            const int noteSize = 50;
            if (notes.Any(note => (x - note.Left) < noteSize / 2)) {
                continue;
            }
            PictureBox picNote = new() {
                BackColor = Color.Black,
                ForeColor = Color.Black,
                Width = noteSize,
                Height = noteSize,
                Top = picTarget.Top + picTarget.Height / 2 - noteSize / 2,
                Left = (int)x,
                Text = x.ToString(),
                BackgroundImage = Resources.marker,
                BackgroundImageLayout = ImageLayout.Stretch,
                Anchor = AnchorStyles.Bottom,
            };
            picNote.BringToFront();
            Controls.Add(picNote);
            notes.Add(picNote);
        }
        Timer tmrWaitThenPlay = new() {
            Interval = 1000,
            Enabled = true,
        };
        components.Add(tmrWaitThenPlay);
        tmrWaitThenPlay.Tick += (e, sender) => {
            Game.GetInstance().CurSong.Play();
            tmrWaitThenPlay.Enabled = false;
            tmrPlay.Enabled = true;
        };
    }

    private void tmrPlay_Tick(object sender, EventArgs e) {
        int index = curSong.Audio.GetPosition();
        foreach (var note in notes) {
            double x = double.Parse(note.Text);
            x -= tmrPlay.Interval * (noteSpeed * 1.3);
            note.Left = (int)x;
            note.Text = x.ToString();
            if (note.Left < picTarget.Left && note.BackColor == Color.Black) {
                note.BackgroundImage = Resources.marker_miss;
                note.BackColor = Color.Red;
            }
        }
        if (index >= curSong.Audio.GetNumberOfSamples() - 1) {
            tmrPlay.Enabled = false;
            foreach (var note in notes) {
                Controls.Remove(note);
                note.Dispose();
            }
        }
    }

    private void FrmMain_KeyPress(object sender, KeyPressEventArgs e) {
        foreach (var note in notes) {
            if (note.Left < picTarget.Left + picTarget.Width && note.Left + note.Width > picTarget.Left) {
                note.BackgroundImage = Resources.marker_hit;
                note.BackColor = Color.Green;
                lblScore.Text = (int.Parse(lblScore.Text) + 1).ToString();
                lblScore.Font = new("Arial", 42);
                break;
            }
        }
    }

    private void FrmMain_KeyDown(object sender, KeyEventArgs e) {
        picTarget.BackgroundImage = Resources.pressed;
    }

    private void FrmMain_KeyUp(object sender, KeyEventArgs e) {
        picTarget.BackgroundImage = Resources._default;
    }

    private void FrmMain_FormClosing(object sender, FormClosingEventArgs e) {
        Game.GetInstance().CurSong.Audio.Stop();
    }

    private void tmrScoreShrink_Tick(object sender, EventArgs e) {
        if (lblScore.Font.Size > 20) {
            lblScore.Font = new("Arial", lblScore.Font.Size - 1);
        }
    }

    private void lblScore_Click(object sender, EventArgs e) {

    }
}
