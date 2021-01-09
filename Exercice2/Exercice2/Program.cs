using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Linq;



namespace Exercice2
{
    class Program
    {
        
        static string [] Splitting () 
        {
            string [] lines = System.IO.File.ReadAllLines("text.txt", System.Text.Encoding.GetEncoding("iso-8859-1"));
            return lines;
        }

        public Dictionary<string, int> Map(string line)
        {
            Dictionary<string, int> lineDict = new Dictionary<string, int>();
            var regex = new Regex(@"\b[\s,.-:;']*");
            var words = regex.Split(line).Where(x => !string.IsNullOrEmpty(x));
            foreach (string word in words)
            {
                if (lineDict.ContainsKey(word)) lineDict[word] = +1;
                else lineDict.Add(word, 1);
            }
            return lineDict;
        }

        public Dictionary<string, int> Reduce(Dictionary<string, int> lineDict, Dictionary<string, int> totalDict)
        {
            foreach (var i in lineDict)
            {
                if (totalDict.ContainsKey(i.Key)) totalDict[i.Key] = +1;
                else totalDict.Add(i.Key, 1);
            }
            return totalDict;
        }

        public Dictionary<string, int> GetWords()
        {
            var totalDict = new Dictionary<string, int>();
            string[] lines = Splitting();
            Parallel.ForEach(lines, line => {
                Dictionary<string, int> lineDict = Map(line);
                lock(totalDict)
                {
                    Reduce(lineDict, totalDict);
                }
            }
            );
            //result.OrderByDescending(kv => kv.Value).Take((int)TopCount).ToDictionary(kv => kv.Key, kv => kv.Value);
            return totalDict;
        }

        public void PrintDictionary(Dictionary<string, int> dictionary)
        {
            foreach(KeyValuePair<string, int> kvp in dictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
        }

        static void Main(string[] args)
        {
            string[] test = Splitting();
            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }
            Console.ReadKey();
        }
    }
}
