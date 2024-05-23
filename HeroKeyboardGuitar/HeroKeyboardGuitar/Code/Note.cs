using HeroKeyboardGuitar.Properties;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace HeroKeyboardGuitar;

/// <summary>
/// The status of the moving note
/// </summary>
public enum NoteState {
    /// <summary>
    /// Still moving towards the target. Hasn't been hit nor missed yet
    /// </summary>
    TRAVELING,

    /// <summary>
    /// Successfully hit
    /// </summary>
    HIT,

    /// <summary>
    /// Missed
    /// </summary>
    MISS,

}

/// <summary>
/// Holds a single note in a song, as well as the picture for that note.
/// Handles movement, hitting and missing
/// </summary>
public class Note {
    /// <summary>
    /// Current state of the note
    /// </summary>
    public NoteState State { get; private set; }

    /// <summary>
    /// Image shown to player
    /// </summary>
    public PictureBox Pic { get; private set; }

    /// <summary>
    /// The Spawn Location of the note. A 0 represents it spawns on the right and 1 represents it spawns on the left.
    /// </summary>
    public int SpawnLoc { get; set; }

    private double xPos;

    private readonly Timer destructionTimer;

    /// <summary>
    /// Ctor. Sets state to traveling
    /// </summary>
    /// <param name="pic">PictureBox for visual representation</param>
    /// <param name="xPos">Starting x position</param>
    public Note(PictureBox pic, double xPos, int SpawnLoc) {
        Pic = pic;
        State = NoteState.TRAVELING;
        this.xPos = xPos;
        this.destructionTimer = new Timer();
        this.SpawnLoc = SpawnLoc;
    }

    /// <summary>
    /// A timer for when to destroy a note.
    /// </summary>
    public void StartDestructionTimer()
    {
        this.destructionTimer.Interval = 1; // Set the interval (in milliseconds) for self-destruction
        this.destructionTimer.Tick += DestructionTimer_Tick;
        this.destructionTimer.Start();
     }

    /// <summary>
    /// Destroys picture box
    /// </summary>
    public void Dispose() {
        Pic.Dispose();
        if (destructionTimer != null)
        {
            this.destructionTimer.Stop(); // Stop the destruction timer
            this.destructionTimer.Dispose(); // Dispose the timer object
        }
    }

    /// <summary>
    /// Moves note to the left or right by amount. Send a positive amount and 
    /// x position is subtracted/added by this amount. Also moves picture box.
    /// </summary>
    /// <param name="amount">Amount to move to the left</param>
    public void Move(double amount) {
        if (SpawnLoc == 1)
        {
            xPos += amount;
            Pic.Left = (int)xPos;
        }
        else
        {
            xPos -= amount;
            Pic.Left = (int)xPos;
        }
    }

    /// <summary>
    /// Checks if the player has successfully hit this note. If so, the note will be marked as hit and
    /// picture box and state will reflect this.
    /// </summary>
    /// <param name="picTarget">PictureBox object for player's target zone</param>
    /// <param name="m_left">Check to make sure that the note doesnt get hit from the wrong mouse click</param>
    /// <param name="m_right">Check to make sure that the note doesnt get hit from the wrong mouse click</param>
    /// <returns>True if note was just hit, false if it wasn't hit or was already previously hit</returns>
    public bool CheckHit(PictureBox picTarget, bool m_left, bool m_right) {
        if (SpawnLoc == 0 && m_right == true)   // Comes from the right.
        {
            if (Pic.Left < picTarget.Right && Pic.Left > picTarget.Left && State == NoteState.TRAVELING)
            {
                State = NoteState.HIT;
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (SpawnLoc == 1 && m_left == true)   // Comes from the left.
        {
            if (Pic.Right > picTarget.Left && Pic.Right < picTarget.Right && State == NoteState.TRAVELING)
            {
                State = NoteState.HIT;
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Checks if the player has missed this note. If so, the note will be marked as missed and
    /// picture box and state will reflect this.
    /// </summary>
    /// <param name="picTarget">PictureBox object for player's character.</param>
    /// <returns>True if note was just missed, false if it wasn't missed or was already previously missed</returns>
    public bool CheckMiss(PictureBox picTarget) {
        if (SpawnLoc == 1)  // Comes from the left.
        {
            if (Pic.Right > picTarget.Left && State == NoteState.TRAVELING)
            {
                State = NoteState.MISS;
                return true;
            }
            else
            {
                return false;
            }
        }
        else    // Comes from the right.
        {
            if (Pic.Left < picTarget.Right && State == NoteState.TRAVELING)
            {
                State = NoteState.MISS;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    /// <summary>
    /// Disposes the note after the timer hits 0.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DestructionTimer_Tick(object sender, EventArgs e)
    {
        Dispose();
    }
}
