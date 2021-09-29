using System;

namespace DND_DiceRoller_Library
{
    /// <summary>
    /// Global variables for the dice roller application.
    /// </summary>
    public static class Global
    {
        /// <summary>
        /// Global variable that collects user input for the dice they want.
        /// </summary>
        public static string RollSelection
        {
            get
            {
                return Console.ReadLine().ToUpper();
            }
        }
    }
}