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
            Dictionary<string, int> nombreOccurenceMots = new Dictionary<string, int>();
            var regex = new Regex(@"\b[\s,.-:;']*");
            var words = regex.Split(line).Where(x => !string.IsNullOrEmpty(x));
            foreach (string word in words)
            {
                if (nombreOccurenceMots.ContainsKey(word)) nombreOccurenceMots[word] = +1;
                else nombreOccurenceMots.Add(word, 1);
            }
            return nombreOccurenceMots;
        }

        public Dictionary<string, int> Reduce(Dictionary<string, int> dicoParLigne, Dictionary<string, int> nombreTotalMots)
        {
            foreach (var i in dicoParLigne)
            {
                if (nombreTotalMots.ContainsKey(i.Key)) nombreTotalMots[i.Key] = +1;
                else nombreTotalMots.Add(i.Key, 1);
            }
            return nombreTotalMots;
        }

        public Dictionary<string, int> GetWords()
        {
            var result = new Dictionary<string, int>();
            string[] lines = Splitting();
            Parallel.ForEach(lines, line => {
                Dictionary<string, int> lineDict = Map(line);
                lock(result)
                {
                    Reduce(lineDict, result);
                }
            }
            );
            result.OrderByDescending(kv => kv.Value).Take((int)TopCount).ToDictionary(kv => kv.Key, kv => kv.Value);
            return result;
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
