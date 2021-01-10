using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercice3;

namespace UnitTestExercice3
{
    [TestClass]
    public class UnitTest1
    {
        Player player = new Player("pseudoTest");
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(player.GetPseudo(), "pseudoTest");
            Assert.AreEqual(player.GetPosition(), 0);
            Assert.AreEqual(player.GetCurrentState().GetType(), typeof(DefaultState));
        }
        [TestMethod]
        public void TestMethod2()
        {
            (int, int, bool) play = player.RollTheDices();
            Assert.AreEqual(play.GetType(), typeof((int, int, bool)));
            Assert.IsTrue(play.Item1 >= 1 && play.Item1 <= 6);
            Assert.IsTrue(play.Item2 >= 1 && play.Item2 <= 6);
        }
    }
}
