namespace Agentes.Interfaces
{
    public interface IStaircaseStrategy
    {
        /// <summary>
        /// Method to obtain the characters of a staircase
        /// </summary>
        /// <param name="n">Base number of the staircase</param>
        /// <returns>Staircase structure</returns>
        string GetStaircase(int n);
    }
}
