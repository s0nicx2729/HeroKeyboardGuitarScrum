using AudioAnalyzing;
using HeroKeyboardGuitar.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HeroKeyboardGuitar;

internal partial class FrmMain : Form
{
    private List<Note> notes;
    private const float noteSpeed = 0.5f;
    private Audio curSong;
    private Score score;
    FrmScore scoreBoard = new FrmScore();


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
        panBg.BackgroundImage = Game.GetInstance().GetBg();
        panBg.Height = (int)(Height * 0.8);
        curSong = Game.GetInstance().CurSong;
        notes = new();
        foreach (var actionTime in curSong.ActionTimes)
        {
            double x = actionTime * noteSpeed + picTarget.Left + picTarget.Width;
            const int noteSize = 50;
            if (notes.Any(note => (x - note.Pic.Left) < noteSize / 2))
            {
                continue;
            }
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
            notes.Add(new(picNote, x));
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

                if (score.Lives <= 0)
                {
                    //TODO: Create a GameOver screen that stops the song and gameplay. Has a button to restart the current song. Below is temporary and for testing.
                    Ending.Text = "GAME OVER";
                    Ending.Visible = true;
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

    private void FrmMain_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Space)
        {
            foreach (var note in notes)
            {
                if (note.CheckHit(picTarget))
                {
                    if (score.Streak < 10)
                    {
                        score.Add(10);
                        note.StartDestructionTimer();
                        scoreBoard.ScoreB = score.Amount.ToString();
                        scoreBoard.StreakB = score.Streak.ToString();
                        scoreBoard.MultiplierB = score.Multiplier.ToString();
                        break;
                    }
                    if (score.Streak >= 10 && score.Streak < 20)
                    {
                        score.Add(20);
                        note.StartDestructionTimer();
                        scoreBoard.ScoreB = score.Amount.ToString();
                        scoreBoard.StreakB = score.Streak.ToString();
                        scoreBoard.MultiplierB = score.Multiplier.ToString();
                        break;
                    }
                    if (score.Streak >= 20 && score.Streak < 30)
                    {
                        score.Add(30);
                        note.StartDestructionTimer();
                        scoreBoard.ScoreB = score.Amount.ToString();
                        scoreBoard.StreakB = score.Streak.ToString();
                        scoreBoard.MultiplierB = score.Multiplier.ToString();
                        break;
                    }
                    if (score.Streak >= 30)
                    {
                        score.Add(40);
                        note.StartDestructionTimer();
                        scoreBoard.ScoreB = score.Amount.ToString();
                        scoreBoard.StreakB = score.Streak.ToString();
                        scoreBoard.MultiplierB = score.Multiplier.ToString();
                        break;
                    }
                }
            }
        }
        picTarget.BackgroundImage = Resources.pressed;
    }

    private void FrmMain_KeyUp(object sender, KeyEventArgs e)
    {
        picTarget.BackgroundImage = Resources._default;

    }

    private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
        Game.GetInstance().CurSong.Stop();
        scoreBoard.Close();
    }
}
