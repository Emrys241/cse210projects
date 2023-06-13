using System;

namespace Develop05
{
    public static class ScoreManager
    {
        private static int score;

        public static void IncreaseScore(int value)
        {
            score += value;
        }

        public static void DecreaseScore(int value)
        {
            score -= value;
        }

        public static void DisplayScore()
        {
            Console.WriteLine($"Score: {score}");
        }
    }
}
