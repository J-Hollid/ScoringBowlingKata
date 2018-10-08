using System.Collections.Generic;

namespace ScoringBowlingKata
{
    /// <summary>
    /// Class for managing a scoring card for a game of bowling, contains methods for recording pins knocked down and 
    /// calculating a final score.
    /// </summary>
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

        /// <summary>
        /// Calculation method for returning the final score of the game.
        /// </summary>
        /// <returns>Integer for the total end game score value.</returns>
        public int Score()
        {
            int total = 0;
            double round = 0;

            // Iterate through all of the rolls recorded in this instance of the class.
            for (int i = 0; i < Rolls.Count; i++)
            {

                // Check for and add strike bonus to the total.
                if ((round % 1 == 0) && (i + 2 < Rolls.Count) && (Rolls[i] == 10))
                {
                    total = total + Rolls[i + 1] + Rolls[i + 2];
                }
                
                // Check for and add spare bonus to the total.
                else if ((round % 1 != 0) && (i + 1 < Rolls.Count) && (Rolls[i] + Rolls[i - 1] == 10))
                {
                    total = total + Rolls[i + 1];
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