using System;

namespace DND_DiceRoller_Library
{
    /// <summary>
    /// Represents rolling dice from a D4 up to D20
    /// </summary>
    public static class DiceRoller
    {
        /// <summary>
        /// Returns the random roll of a D4 dice.
        /// </summary>
        /// <returns>D4 dice roll.</returns>
        public static int RollD4()
        {
            Random roller = new Random();
            return roller.Next(1, 5);
        }

        /// <summary>
        /// Returns the random roll of a D6 dice.
        /// </summary>
        /// <returns>D6 dice roll.</returns>
        public static int RollD6()
        {
            Random roller = new Random();
            return roller.Next(1, 7);
        }

        /// <summary>
        /// Returns the random roll of a D8 dice.
        /// </summary>
        /// <returns>D8 dice roll.</returns>
        public static int RollD8()
        {
            Random roller = new Random();
            return roller.Next(1, 9);
        }

        /// <summary>
        /// Returns the random roll of a D10 dice.
        /// </summary>
        /// <returns>D10 dice roll.</returns>
        public static int RollD10()
        {
            Random roller = new Random();
            return roller.Next(1, 11);
        }

        /// <summary>
        /// Returns the random roll of a D12 dice.
        /// </summary>
        /// <returns>D12 dice roll.</returns>
        public static int RollD12()
        {
            Random roller = new Random();
            return roller.Next(1, 13);
        }

        /// <summary>
        /// Returns the random roll of a D20 dice.
        /// </summary>
        /// <returns>D20 dice roll.</returns>
        public static int RollD20()
        {
            Random roller = new Random();
            return roller.Next(1, 21);
        }
    }
}
