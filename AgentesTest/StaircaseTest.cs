using Agentes.Strategies.StairCase;

namespace Agentes.UnitTest
{
    [TestClass]
    public class StaircaseTest
    {
        [TestMethod]
        public void StaircaseStraightTest()
        {
            StaircaseStraightStrategy staircaseAgent = new StaircaseStraightStrategy();
            int staircaseSize = 4;
            string result = staircaseAgent.GetStaircase(staircaseSize);
            string expected = "   #\n  ##\n ###\n####\n";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void StaircaseReverseTest()
        {
            StaircaseReverseStrategy staircaseAgent = new StaircaseReverseStrategy();
            int staircaseSize = 4;
            string result = staircaseAgent.GetStaircase(staircaseSize);
            string expected = "####\n ###\n  ##\n   #\n";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void StaircaseCenterTest()
        {
            StaircaseCenterStrategy staircaseAgent = new StaircaseCenterStrategy();
            int staircaseSize = 4;
            string result = staircaseAgent.GetStaircase(staircaseSize);
            string expected = "   ####\n  ######\n ########\n##########\n ########\n  ######\n   ####\n";
            Assert.AreEqual(expected, result);
        }
    }
}
