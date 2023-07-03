public class ScoreManager
{
    private int _totalPoints;

    public int TotalPoints => _totalPoints;

    public void AddPoints(int points)
    {
        _totalPoints += points;
    }
}
