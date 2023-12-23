using Agentes.Interfaces;

namespace Agentes.Strategies.StairCase
{
    public class StaircaseCenterStrategy : IStaircaseStrategy
    {
        /// <summary>
        /// Method for obtaining the structure of a centered staircase
        /// </summary>
        /// <param name="n">Base of the staircase</param>
        /// <returns>Staircase structure</returns>
        public string GetStaircase(int n)
        {
            if (n < 0 && n > 100) throw new ArgumentException("The size of n must be between 0 and 100.");
            
            string staircase = "";

            // staircase up
            for (int i = 0; i < n - 1; i++)
            {
                int spaces = n - i - 1;
                int chars = n + 2 * i;
                staircase += new string(' ', spaces) + new string('#', chars) + "\n";
            }

            int centralChars = n + ((n - 1) * 2);
            staircase += new string('#', centralChars) + "\n";

            // staircase down
            for (int i = n - 2; i >= 0; i--)
            {
                int spaces = n - i - 1;
                int chars = n + 2 * i;
                staircase += new string(' ', spaces) + new string('#', chars) + "\n";
            }
            return staircase;
        }
    }
}
