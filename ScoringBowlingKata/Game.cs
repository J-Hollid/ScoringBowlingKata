using System.Collections.Generic;

namespace ScoringBowlingKata
{
    public class Game
    {
        private List<int> Rolls = new List<int>();

        /// <summary>
        /// Input method for recording number of pins knocked down.
        /// </summary>
        /// <param name="pins">Integer value indicating the number of pins knocked down.</param>
        public void Roll(int pins)
        {
            Rolls.Add(pins);
        }

        public int Score()
        {
            return 0;
        }
    }
}
