using System;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomQueue<string> l = new CustomQueue<string>(new Node<string>("Coucou"));
            l.addNode(new Node<string>("Bonjour"));
            l.addNode(new Node<string>("Salut"));
            Console.WriteLine(l.getNode(1).data);
            Console.WriteLine(l.getNode(2).data);
            l.setNode(new Node<string>("Heyy"), 2);
            Console.WriteLine(l.getNode(2).data);
            l.print();
            Console.ReadKey();

        }
    }
}
