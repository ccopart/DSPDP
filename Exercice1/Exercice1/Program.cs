using System;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, and welcome in our Custom Queue.\n");

            Console.WriteLine("PRESS ENTER TO CONTINUE...");
            Console.ReadKey();

            Console.WriteLine("\nIn a first part, we simply enqueue 5 numbers : ");
            Console.WriteLine("     - 14");
            Console.WriteLine("     - 18");
            Console.WriteLine("     - 39");
            Console.WriteLine("     - 45");
            Console.WriteLine("     - 303\n");

            CustomQueue<int> l = new CustomQueue<int>(new Node<int>(14));
            l.Enqueue(new Node<int>(18));
            l.Enqueue(new Node<int>(39));
            l.Enqueue(new Node<int>(45));
            l.Enqueue(new Node<int>(303));

            Console.WriteLine("Then we dequeue 2 times.\n");
            Node<int> temp = l.DequeueAndRetreive(); //We created a temporary variable because it is asked to retreive the value when we deuqueue it
            temp = l.DequeueAndRetreive();

            Console.WriteLine("Here is how our final queue looks like : ");
            l.print();

            Console.WriteLine("\nPRESS ENTER TO CONTINUE...");
            Console.ReadKey();

            Console.WriteLine("\nIn a second part, we enqueue 10 strings : "); //We make a second example with another variable type to proove the generics works
            Console.WriteLine("     - It");
            Console.WriteLine("     - Is");
            Console.WriteLine("     - Raining");
            Console.WriteLine("     - Cats");
            Console.WriteLine("     - And");
            Console.WriteLine("     - Dogs\n");

            CustomQueue<string> l2 = new CustomQueue<string>(new Node<string>("It"));
            l2.Enqueue(new Node<string>("Is"));
            l2.Enqueue(new Node<string>("Raining"));
            l2.Enqueue(new Node<string>("Cats"));
            l2.Enqueue(new Node<string>("And"));
            l2.Enqueue(new Node<string>("Dogs"));

            Console.WriteLine("Then we dequeue 3 times.\n");
            Node<string> temp2 = l2.DequeueAndRetreive();
            temp2 = l2.DequeueAndRetreive();
            temp2 = l2.DequeueAndRetreive();

            Console.WriteLine("Here is how our final queue looks like : ");
            l2.print();

            Console.WriteLine("\nPRESS ENTER TO QUIT...");
            Console.ReadKey();
        }
    }
}
