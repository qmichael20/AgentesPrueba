using Agentes.Interfaces;

namespace Agentes.Strategies.Media
{
    public class HarmonicaMediaStrategy : IMediaStrategy
    {
        /// <summary>
        /// Method to obtain the harmonic mean of a list of numbers
        /// </summary>
        /// <param name="numbers">List of numbers</param>
        /// <returns>Harmonica Media Result</returns>
        public double GetMedia(List<double> numbers)
        {
            if (numbers.Count == 0) return 0;
            return numbers.Count / numbers.Sum(x => 1 / x);
        }
    }
}
