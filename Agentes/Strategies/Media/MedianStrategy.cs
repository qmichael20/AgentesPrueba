using Agentes.Interfaces;

namespace Agentes.Strategies.Media
{
    public class MedianStrategy : IMediaStrategy
    {
        /// <summary>
        /// Method for obtaining the median of a list of numbers
        /// </summary>
        /// <param name="numbers">List of number</param>
        /// <returns>Median result</returns>
        public double GetMedia(List<double> numbers)
        {
            if (numbers.Count == 0) return 0;

            numbers.Sort();
            int n = numbers.Count;

            return (n % 2 == 0)
                ? (numbers[n / 2 - 1] + numbers[n / 2]) / 2.0
                : numbers[n / 2];
        }
    }
}
