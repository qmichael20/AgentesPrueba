using Agentes.Interfaces;
using Agentes.Strategies.Media;
using Agentes.Strategies.StairCase;

namespace Agentes.Factories
{
    public class AgentFactory
    {
        /// <summary>
        /// Creates a media agent based on the specified type
        /// </summary>
        /// <param name="agentType">Type of media agent (A, B or C)</param>
        /// <returns>Created agent</returns>
        public static IMediaStrategy CreateMediaAgent(string agentType)
        {
            switch (agentType)
            {
                case "A":
                    return new ArithmeticMediaStrategy();
                case "B":
                    return new HarmonicaMediaStrategy();
                case "C":
                    return new MedianStrategy();
                default:
                    throw new ArgumentException($"Invalid media agent type: {agentType}");
            }
        }

        /// <summary>
        /// Creates a staircase agent based on the specified type.
        /// </summary>
        /// <param name="agentType">The type of staircase agent (A, B, or C).</param>
        /// <returns>The created staircase agent.</returns>
        public static IStaircaseStrategy CreateStaircaseAgent(string agentType)
        {
            switch (agentType)
            {
                case "A":
                    return new StaircaseStraightStrategy();
                case "B":
                    return new StaircaseReverseStrategy();
                case "C":
                    return new StaircaseCenterStrategy();
                default:
                    throw new ArgumentException($"Invalid staircase agent type: {agentType}");
            }
        }
    }
}
