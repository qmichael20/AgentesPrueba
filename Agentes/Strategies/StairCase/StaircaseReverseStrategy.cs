using Agentes.Interfaces;

namespace Agentes.Strategies.StairCase
{
    public class StaircaseReverseStrategy : IStaircaseStrategy
    {
        /// <summary>
        /// Method for obtaining the structure of a reverse staircase
        /// </summary>
        /// <param name="n">Base of the staircase</param>
        /// <returns>Staircase structure</returns>
        public string GetStaircase(int n)
        {
            if (n < 0 && n < 100) throw new ArgumentException("The size of n must be between 0 and 100.");

            string staircase = "";
            for (int i = 0; i < n; i++)
            {
                staircase += new string(' ', i) + new string('#', n - i) + "\n";
            }
            return staircase;
        }
    }
}
