using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercice3;

namespace UnitTestExercice3
{
    [TestClass]
    public class UnitTest1
    {
        Player player = new Player("pseudoTest");
        [TestMethod]
        public void TestCreatePlayer()
        {
            Assert.AreEqual(player.GetPseudo(), "pseudoTest");
            Assert.AreEqual(player.GetPosition(), 0);
            Assert.AreEqual(player.GetCurrentState().GetType(), typeof(DefaultState));
        }
        [TestMethod]
        public void TestRollDices()
        {
            (int, int, bool) dices = player.RollTheDices();
            Assert.AreEqual(dices.GetType(), typeof((int, int, bool)));
            Assert.IsTrue(dices.Item1 >= 1 && dices.Item1 <= 6);
            Assert.IsTrue(dices.Item2 >= 1 && dices.Item2 <= 6);
        }
        [TestMethod]
        public void TestIncrementPosition()
        {
            player.IncrementPosition((3, 6, false));
            Assert.AreEqual(player.GetPosition(), 9);
        }
    }
}
