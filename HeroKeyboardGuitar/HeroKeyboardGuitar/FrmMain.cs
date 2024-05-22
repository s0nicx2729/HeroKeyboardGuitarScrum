using AudioAnalyzing;
using HeroKeyboardGuitar.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HeroKeyboardGuitar;

internal partial class FrmMain : Form
{
    private List<Note> notes;
    private const float noteSpeed = 0.35f;
    private Audio curSong;
    private Score score;
    FrmScore scoreBoard = new FrmScore();
    public bool m_right = false;
    public bool m_left = false;


    // for double buffering
    protected override CreateParams CreateParams
    {
        get
        {
            var cp = base.CreateParams;
            cp.ExStyle |= 0x02000000;    // Turn on WS_EX_COMPOSITED
            return cp;
        }
    }

    public FrmMain()
    {
        InitializeComponent();
        scoreBoard.Show();
        scoreBoard.TopMost = true;
    }

    public void FrmMain_Load(object sender, EventArgs e)
    {
        score = new();
        Random random = new();
        curSong = Game.GetInstance().CurSong;
        const int noteSize = 50;
        notes = new();
        foreach (var actionTime in curSong.ActionTimes)
        {   
            int spawnloc = random.Next(0, 2);

            double x;
            if (spawnloc == 0)
            {
                x = actionTime * noteSpeed + picTarget.Left + picTarget.Width;
                if (notes.Any(note => (x - note.Pic.Left) < noteSize / 2))
                {
                    continue;
                }
            }
            else
            {
                x = -1 * (actionTime * noteSpeed + picTarget.Right - picTarget.Width);
                if (notes.Any(note => (x + note.Pic.Right - note.Pic.Width) > noteSize / 2))
                {
                    continue;
                }
            }
            if (spawnloc == 1) {
                PictureBox picNote = new()
                {
                    BackColor = Color.White,
                    ForeColor = Color.White,
                    Width = noteSize,
                    Height = noteSize,
                    Top = picTarget.Top + picTarget.Height / 2 - noteSize / 2,
                    Left = (int)x,
                    BackgroundImage = Resources.marker,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Anchor = AnchorStyles.Bottom,
                };
                Controls.Add(picNote);
                notes.Add(new(picNote, x,1));
            }
            // Starts on Right side of screen.
            else
            {
                PictureBox picNote = new()
                {
                    BackColor = Color.Black,
                    ForeColor = Color.Black,
                    Width = noteSize,
                    Height = noteSize,
                    Top = picTarget.Top + picTarget.Height / 2 - noteSize / 2,
                    Left = (int)x,
                    BackgroundImage = Resources.marker,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Anchor = AnchorStyles.Bottom,
                };
                Controls.Add(picNote);
                notes.Add(new(picNote, x,0));
            }
            
        }
            Timer tmrWaitThenPlay = new()
        {
            Interval = 1000,
            Enabled = true,
        };
        components.Add(tmrWaitThenPlay);
        tmrWaitThenPlay.Tick += (e, sender) =>
        {
            Game.GetInstance().CurSong.Play();
            tmrWaitThenPlay.Enabled = false;
            tmrPlay.Enabled = true;
        };
    }

    private void tmrPlay_Tick(object sender, EventArgs e)
    {
        int index = curSong.GetPosition();
        foreach (var note in notes)
        {
            note.Move(tmrPlay.Interval * (noteSpeed * 1.3));

            if (note.CheckMiss(picTarget))
            {
                score.Miss();
                note.StartDestructionTimer();
                scoreBoard.StreakB = score.Streak.ToString();
                scoreBoard.Health = score.Lives.ToString();

                if (score.Lives <= 0)
                {
                    scoreBoard.Health = "0";
                    //TODO: Create a GameOver screen that stops the song and gameplay. Has a button to restart the current song. Below is temporary and for testing.
                }
            }
        }
        if (index >= curSong.GetNumberOfSamples() - 1)
        {
            tmrPlay.Enabled = false;
            foreach (var note in notes)
            {
                Controls.Remove(note.Pic);
                note.Dispose();
            }
        }
    }

    private void FrmMain_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
        {
            if (e.Button == MouseButtons.Left) 
            {
                m_left = true;
                picTarget.BackgroundImage = Resources.lps;
            }
            if (e.Button == MouseButtons.Right)
            {
                m_right = true;
                picTarget.BackgroundImage = Resources.rps;
            }
            foreach (var note in notes)
            {
                if (note.CheckHit(L_range,m_left,m_right) || note.CheckHit(R_range,m_left,m_right))
                {
                    if (score.Streak >= 30)
                    {
                        score.Add(40);
                    }
                    else if (score.Streak >= 20)
                    {
                        score.Add(30);
                    }
                    else if (score.Streak >= 10)
                    {
                        score.Add(20);
                    }
                    else
                    {
                        score.Add(10);
                    }
                    note.StartDestructionTimer();
                    scoreBoard.ScoreB = score.Amount.ToString();
                    scoreBoard.StreakB = score.Streak.ToString();
                    scoreBoard.Health = score.Lives.ToString();
                    scoreBoard.MultiplierB = score.Multiplier.ToString();
                    break;
                }

            }
            m_left = false;
            m_right = false;
        }
    }

    private void FrmMain_MouseUp(object sender, MouseEventArgs e)
    {
        picTarget.BackgroundImage = Resources.idle;
        if (e.Button == MouseButtons.Left)
        {
            m_left = true;
        }
        if (e.Button == MouseButtons.Right)
        {
            m_right = true;
        }
    }

    private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
        Game.GetInstance().CurSong.Stop();
        scoreBoard.Close();
    }
}
