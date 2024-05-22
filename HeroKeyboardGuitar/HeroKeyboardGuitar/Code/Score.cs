namespace HeroKeyboardGuitar;

/// <summary>
/// Holds the current score and streak of the player
/// </summary>
public class Score {
    /// <summary>
    /// Amount of notes successfully hit
    /// </summary>
    public int Amount { get; private set; }

    /// <summary>
    /// Current streak, i.e. consecutive hit notes without a miss
    /// </summary>
    public int Streak { get; private set; }

    /// <summary>
    /// Current mulitplier. Is affected by the streak.
    /// </summary>
    public int Multiplier { get; private set; }

    /// <summary>
    /// Current amount of lives. Can gain and lose. Missing and hitting notes will decrease
    /// </summary>
    public int Lives { get; private set; }

    /// <summary>
    /// initializes both amount and streak to 0
    /// </summary>
    public Score() {
        Amount = 0;
        Streak = 0;
        Multiplier = 1;
        Lives = 10;
    }

    /// <summary>
    /// Used to check if the player has reached the point of receiving a reward.
    /// Currently not implemented
    /// </summary>
    public void CheckReward() {
        // TODO: possibly make this a dictionary mapping genres to reward maps
        //Game.GetRewardMap()
    }

    /// <summary>
    /// Add to the current score or streak
    /// </summary>
    /// <param name="amount">Amount to add</param>
    public void Add(int amount) {
        Amount += amount;
        Streak++;
        if (Lives < 10)
        {
            Lives++;
        }
        if (Streak >= 10 && Streak < 20)
        {
            Multiplier = 2;
        }
        if (Streak >= 20 && Streak < 30)
        {
            Multiplier = 3;
        }
        if (Streak >= 30)
        {
            Multiplier = 4;
        }
    }

    /// <summary>
    /// Resets streak back to 0
    /// </summary>
    public void Miss() {
        Streak = 0;
        Lives--;
        Multiplier = 1;
    }
}
