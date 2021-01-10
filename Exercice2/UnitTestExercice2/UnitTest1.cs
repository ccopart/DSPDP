using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Linq;
using Exercice2;

namespace UnitTestExercice2
{
    [TestClass]
    public class UnitTest1
    {
        string line = "un deux trois trois quatre deux trois quatre quatre quatre";
        [TestMethod]
        public void TestMethod1()
        {
            
            Dictionary<string, int> result = Program.Map(line);
            Assert.AreEqual(result["un"], 1);
            Assert.AreEqual(result["deux"], 2);
            Assert.AreEqual(result["trois"], 3);
            Assert.AreEqual(result["quatre"], 4);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Dictionary<string, int> finalResult = new Dictionary<string, int>();
            finalResult.Add("un", 4);
            finalResult.Add("deux", 2);
            finalResult.Add("trois", 1);
            finalResult.Add("quatre", 5);
            finalResult.Add("cinq", 5);
            Dictionary<string, int> result = Program.Map(line);
            finalResult = Program.Reduce(result, finalResult);
            Assert.AreEqual(finalResult["un"], 5);
            Assert.AreEqual(finalResult["deux"], 4);
            Assert.AreEqual(finalResult["trois"], 4);
            Assert.AreEqual(finalResult["quatre"], 9);
            Assert.AreEqual(finalResult["cinq"], 5);
        }
    }
}
