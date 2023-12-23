namespace Agentes.Interfaces
{
    public interface IMediaStrategy
    {
        /// <summary>
        /// Method for obtaining the result of a statistical measure
        /// </summary>
        /// <param name="numbers">List of numbers</param>
        /// <returns>Result statistical measure</returns>
        double GetMedia(List<double> numbers); 
    }
}
