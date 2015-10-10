using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LaMetric_Tests
{
    [TestClass]
    public class DisplayTest
    {
        [TestMethod]
        public void TestDisplay()
        {
            var lm = new Core.LaMetric.Application();
            lm.SendMessage("Unit Test");
        }
    }
}