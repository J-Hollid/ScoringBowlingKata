using NUnit.Framework;

namespace ScoringBowlingKata
{
    /// <summary>
    /// Nunit test class for testing functionality of the Game class.
    /// </summary>
    [TestFixture]
    public class GameTests
    {
        private Game TestGame;


        /// <summary>
        /// Setup a new Game object for each test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            TestGame = new Game();  
        }

        /// <summary>
        /// Tests score calculations are correct against various test cases.
        /// </summary>
        /// <param name="rolls">Array of integers to populate into the Game class.</param>
        /// <returns>Score calculation to be tested against expected result.</returns>
        [TestCase(new int[20] { 3, 3, 3, 0, 0, 0, 0, 0, 2, 5, 6, 2, 2, 5, 5, 3, 3, 5, 3, 3 }, ExpectedResult = 53, Description = "Test no strikes/spares.")]
        [TestCase(new int[12] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 }, ExpectedResult = 300, Description = "Test perfect game.")]
        [TestCase(new int[20] { 0, 10, 0, 10, 0, 10, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 5 }, ExpectedResult = 125, Description = "Test spares with 10s on second rolls.")]
        [TestCase(new int[16] { 10, 5, 5, 10, 1, 0, 4, 3, 10, 10, 10, 5, 3, 2, 8, 10 }, ExpectedResult = 160, Description = "Test mixed game 1.")]
        [TestCase(new int[20] { 2, 3, 4, 6, 0, 2, 2, 2, 8, 2, 10, 7, 3, 9, 0, 3, 5, 3, 7, 4 }, ExpectedResult = 111, Description = "Test mixed game 2.")]
        public int TestScore(int[] rolls)
        {
            // Input rolls.
            foreach (int roll in rolls)
            {
                TestGame.Roll(roll);
            }

            // Return actual result for comparison against the expected.
            return TestGame.Score();
        }
    }
}