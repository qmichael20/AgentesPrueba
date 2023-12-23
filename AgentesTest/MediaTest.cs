using Agentes.Strategies.Media;

namespace Agentes.UnitTest
{
    [TestClass]
    public class MediaTest
    {
        [TestMethod]
        public void ArithmeticMediaTest()
        {
            ArithmeticMediaStrategy agenteMedia = new ArithmeticMediaStrategy();
            List<double> data = new List<double> { 1, 2, 3, 4, 5 };
            double result = agenteMedia.GetMedia(data);
            Assert.AreEqual(3.0, result, 0.0001);
        }

        [TestMethod]
        public void HarmonicaMediaTest()
        {
            HarmonicaMediaStrategy agenteMedia = new HarmonicaMediaStrategy();
            List<double> data = new List<double> { 1, 2, 3, 4, 5 };
            double result = agenteMedia.GetMedia(data);
            Assert.AreEqual(2.1898, result, 0.0001); 
        }

        [TestMethod]
        public void MedianUnevenTest()
        {
            MedianStrategy agenteMedia = new MedianStrategy();
            List<double> data = new List<double> { 1, 2, 3, 4, 5 };
            double result = agenteMedia.GetMedia(data);
            Assert.AreEqual(3.0, result, 0.0001);
        }

        [TestMethod]
        public void MedianEvenTest()
        {
            MedianStrategy agenteMedia = new MedianStrategy();
            List<double> data = new List<double> { 1, 2, 3, 4, 5, 6 };
            double result = agenteMedia.GetMedia(data);
            Assert.AreEqual(3.5, result, 0.0001);
        }
    }
}