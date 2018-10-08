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
            int total = 0;
            double round = 0;

            // Iterate through all of the rolls recorded in this instance of the class.
            for (int i = 0; i < Rolls.Count; i++)
            {

                // Check for and add strike bonus to the total.
                if ((i + 2 < Rolls.Count) && (Rolls[i] == 10))
                {
                    total = total + Rolls[i + 1] + Rolls[i + 2];
                }

                // Add the roll value to total if not a bonus only roll.
                if (round < 10)
                {
                    total = total + Rolls[i];
                    round = round + (Rolls[i] == 10 && (round % 1 == 0) ? 1 : 0.5);
                }
            }

            return total;
        }
    }
}
