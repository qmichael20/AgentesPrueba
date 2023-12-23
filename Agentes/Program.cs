
using Agentes.Factories;
using Agentes.Interfaces;

class Program
{
    static void Main()
    {
        // Example 1
        IMediaStrategy mediaAgent = AgentFactory.CreateMediaAgent("A");
        List<double> data = new List<double> { 1.0, 2.0, 3.0, 4.0, 5.0, 6.0 };
        double media = mediaAgent.GetMedia(data);
        Console.WriteLine($"Result: {media}\n");

        // Example 2
        IStaircaseStrategy agenteEscalera = AgentFactory.CreateStaircaseAgent("C");
        int staircaseSize = 4;
        string staircase = agenteEscalera.GetStaircase(staircaseSize);
        Console.WriteLine("Staircase:\n" + staircase);
    }
}
