using AudioAnalyzing;
using HeroKeyboardGuitar.Properties;
using OpenTK.Graphics.OpenGL;
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
    private Audio curSong;
    private Score score;
    FrmScore scoreBoard = new FrmScore();
    Frm_ending ending = new Frm_ending();
    Frm_win win = new Frm_win();
    private float noteSpeed = FrmSongSelect.speed;
    public bool m_right = false;
    public bool m_left = false;
    public int notesHit = 0;



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
        win.TopMost = true;
        ending.TopMost = true;
    }

    public void FrmMain_Load(object sender, EventArgs e)
    {
        score = new();
        Random random = new();
        curSong = Game.GetInstance().CurSong;
        const int noteSize = 200;
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
            if (spawnloc == 1) {    // Starts on the left side of the screen.
                PictureBox picNote = new()
                {
                    BackColor = Color.White,
                    ForeColor = Color.White,
                    Width = noteSize/2,
                    Height = noteSize,
                    Top = picTarget.Top + picTarget.Height / 2 - noteSize / 2,
                    Left = (int)x,
                    BackgroundImage = Resources.enemy_L,
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
                    Width = noteSize/2,
                    Height = noteSize,
                    Top = picTarget.Top + picTarget.Height / 2 - noteSize / 2,
                    Left = (int)x,
                    BackgroundImage = Resources.enemy_R,
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
            if (score.Lives > 6)
            {
                this.BackColor = System.Drawing.Color.Green;
            }
            if (score.Lives <= 6 && score.Lives > 3)
            {
                this.BackColor = System.Drawing.Color.Yellow;
            }
            if (score.Lives <= 3)
            {
                this.BackColor = System.Drawing.Color.Red;
            }
            if (note.CheckMiss(picTarget))
            {
                score.Miss();
                note.StartDestructionTimer();
                scoreBoard.StreakB = score.Streak.ToString();
                scoreBoard.Health = score.Lives.ToString();
                if (score.Lives <= 0)
                {
                    ending.Show();
                    Game.GetInstance().CurSong.Stop();
                    scoreBoard.Close();
                    this.Close();
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
            
            score.Accuracy = score.NotesHit / score.TotalNotes * 100;
            win.GameScore = score;
            win.Show();
            Game.GetInstance().CurSong.Stop();
            scoreBoard.Close();
            this.Close();
        }
    }

    private void FrmMain_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
        {
            if (e.Button == MouseButtons.Left) 
            {
                m_left = true;
                picTarget.Image = Resources.fightL;
            }
            if (e.Button == MouseButtons.Right)
            {
                m_right = true;
                picTarget.Image = Resources.fightR;
            }
            foreach (var note in notes)
            {
                if (note.CheckHit(L_range,m_left,m_right) || note.CheckHit(R_range,m_left,m_right))
                {
                    m_left = false;
                    m_right = false;
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
                    notesHit++;
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

    private void FrmMain_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == FrmKeyboard.setLKey || e.KeyChar == FrmKeyboard.setRKey)
        {
            if (e.KeyChar == FrmKeyboard.setLKey)
            {
                m_left = true;
                picTarget.Image = Resources.fightL;
            }
            if (e.KeyChar == FrmKeyboard.setRKey)
            {
                m_right = true;
                picTarget.Image = Resources.fightR;
            }
            foreach (var note in notes)
            {
                if (note.CheckHit(L_range, m_left, m_right) || note.CheckHit(R_range, m_left, m_right))
                {
                    m_left = false;
                    m_right = false;
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
                    notesHit++;
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

    private void FrmMain_KeyUp(object sender, KeyEventArgs e)
    {
        picTarget.Image = Resources.idle2;
        if (e.KeyValue == FrmKeyboard.setLKey)
        {
            m_left = true;
        }
        if (e.KeyValue == FrmKeyboard.setRKey)
        {
            m_right = true;
        }
    }

    private void FrmMain_MouseUp(object sender, MouseEventArgs e)
    {
        picTarget.Image = Resources.idle2;
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
