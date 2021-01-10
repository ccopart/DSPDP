using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Linq;



namespace Exercice2
{
    public class Program
    {
        
        static string [] Splitting () 
        {
            string [] lines = System.IO.File.ReadAllLines("text.txt", System.Text.Encoding.GetEncoding("UTF-8"));
            return lines;
        }

        public static Dictionary<string, int> Map(string line)
        {
            Dictionary<string, int> lineDict = new Dictionary<string, int>();
            var regex = new Regex(@"\b[\s,.-:;']*");
            var words = regex.Split(line).Where(x => !string.IsNullOrEmpty(x));
            foreach (string word in words)
            {
                if (lineDict.ContainsKey(word)) lineDict[word] += 1;
                else lineDict.Add(word, 1);
            }
            return lineDict;
        }

        public static Dictionary<string, int> Reduce(Dictionary<string, int> lineDict, Dictionary<string, int> totalDict)
        {
            foreach (var i in lineDict)
            {
                if (totalDict.ContainsKey(i.Key)) totalDict[i.Key] += i.Value;
                else totalDict.Add(i.Key, i.Value);
            }
            return totalDict;
        }

        public static Dictionary<string, int> GetWords()
        {
            var totalDict = new Dictionary<string, int>();
            string[] lines = Splitting();
            Parallel.ForEach(lines, line => {
                Dictionary<string, int> lineDict = Map(line.ToUpper());
                lock(totalDict)
                {
                    Reduce(lineDict, totalDict);
                }
            }
            );
            return totalDict;
        }

        public static void PrintDictionary(Dictionary<string, int> dictionary)
        {
            foreach(KeyValuePair<string, int> kvp in dictionary)
            {
                Console.WriteLine("{0} : {1} fois", kvp.Key, kvp.Value);
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, int> test = GetWords();
            Console.WriteLine("Bonjour, bienvenue dans notre compteur de mots.\n");
            Console.WriteLine("Dans notre fichier texte nous avons entré les paroles de la musique Harder Better Faster Stronger des Daft Punks.");
            Console.WriteLine("Notre programme va compter le nombre de mot dans cette musique.\n");
            Console.WriteLine("Voici le nombre d'apparition de chaque mot : \n");
            PrintDictionary(test);
        }
    }
}
