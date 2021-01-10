using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercice1;

namespace UnitTestExo1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CustomQueue<int> customQueueInt = new CustomQueue<int>(new Node<int>(14));
            customQueueInt.Enqueue(new Node<int>(18));
            foreach(var node in customQueueInt)
            {
                Assert.AreEqual(node, 14);//the first iteration should be true, then false
            }

            Node<int> temp;
            temp = customQueueInt.DequeueAndRetreive();
            temp = customQueueInt.DequeueAndRetreive();

            customQueueInt.Enqueue(new Node<int>(108));
            customQueueInt.Enqueue(new Node<int>(2));
            customQueueInt.Enqueue(new Node<int>(37));
            customQueueInt.Enqueue(new Node<int>(81));
            customQueueInt.Enqueue(new Node<int>(123123));

            temp = customQueueInt.DequeueAndRetreive();
            temp = customQueueInt.DequeueAndRetreive();
            temp = customQueueInt.DequeueAndRetreive();

            int nbrNodes = 0;
            foreach (var node in customQueueInt)
            {
                nbrNodes++;
            }
            Assert.AreEqual(nbrNodes, 2);
        }
    }
}
