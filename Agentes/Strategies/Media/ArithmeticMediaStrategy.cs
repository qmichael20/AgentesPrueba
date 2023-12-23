using Agentes.Interfaces;

namespace Agentes.Strategies.Media
{
    public class ArithmeticMediaStrategy : IMediaStrategy
    {
        /// <summary>
        /// Method to obtain the average of a list of numbers
        /// </summary>
        /// <param name="numbers">List of numbers</param>
        /// <returns>Average result</returns>
        public double GetMedia(List<double> numbers)
        {
            if (numbers.Count == 0) return 0;
            return numbers.Average();
        }
    }
}
