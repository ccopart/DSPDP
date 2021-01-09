using System;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var dices = RollTheDices();
            Console.WriteLine(dices.Item1);
            Console.WriteLine(dices.Item2);
        }

        public static (int, int) RollTheDices()
        {
            Random rnd = new Random();
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);

            return (dice1, dice2);
        }
    }
}
