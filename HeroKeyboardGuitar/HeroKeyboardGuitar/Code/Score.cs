namespace HeroKeyboardGuitar;

public class Score {
    public int Amount { get; private set; }
    private int streak;

    public Score() {

    }

    public void CheckReward() {
        // TODO: possibly make this a dictionary mapping genres to reward maps
        //Game.GetRewardMap()
    }

    public void Add(int amount) {
        Amount += amount;
        streak++;
    }

    public void Miss() {
        streak = 0;
    }

}
