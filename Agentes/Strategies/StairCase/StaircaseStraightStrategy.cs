using Agentes.Interfaces;

namespace Agentes.Strategies.StairCase
{
    /// <summary>
    /// Method for obtaining the structure of a straight staircase
    /// </summary>
    /// <param name="n">Base of the staircase</param>
    /// <returns>Staircase structure</returns>
    public class StaircaseStraightStrategy : IStaircaseStrategy
    {
        public string GetStaircase(int n)
        {
            if (n < 0 && n < 100) throw new ArgumentException("The size of n must be between 0 and 100.");

            string staircase = "";
            for (int i = 0; i < n; i++)
            {
                staircase += new string(' ', n - i - 1) + new string('#', i + 1) + "\n";
            }
            return staircase;
        }
    }
}
