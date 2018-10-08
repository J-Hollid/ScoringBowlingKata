using NUnit.Framework;

namespace ScoringBowlingKata
{
    [TestFixture]
    public class GameTests
    {
        private Game TestGame;

        [SetUp]
        public void SetUp()
        {
            TestGame = new Game();  
        }

        [TestCase(new int[20] { 3, 3, 3, 0, 0, 0, 0, 0, 2, 5, 6, 2, 2, 5, 5, 3, 3, 5, 3, 3 }, ExpectedResult = 53, Description = "Test no strikes/spares.")]
        public int TestScore(int[] rolls)
        {
            // Input roles.
            foreach (int roll in rolls)
            {
                TestGame.Roll(roll);
            }

            // Return actual result for comparison against the expected.
            return TestGame.Score();
        }
    }
}