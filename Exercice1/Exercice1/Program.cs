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

            CustomQueue<int> customQueueInt = new CustomQueue<int>(new Node<int>(14));//Creation  of the customQueue with integers inside. The first one will be 14
            customQueueInt.Enqueue(new Node<int>(18));//We can add nodes with Enqueue
            customQueueInt.Enqueue(new Node<int>(39));
            customQueueInt.Enqueue(new Node<int>(45));
            customQueueInt.Enqueue(new Node<int>(303));

            Console.WriteLine("Then we dequeue 2 times.\n");
            Node<int> temp = customQueueInt.DequeueAndRetreive(); //We created a temporary variable because it is asked to retreive the value when we deuqueue it
            temp = customQueueInt.DequeueAndRetreive();

            Console.WriteLine("Here is how our final queue looks like : ");
            string result = "[";
            foreach (var node in customQueueInt)//Because we created a function "GetEnumerator", we can use a foreach loop to access to all the nodes of the queue.
            {
                result += node + " ; ";
            }
            result = result.Remove(result.Length - 3);
            result += "]";
            Console.WriteLine(result);//We stored the result in a string to clear a bit the output

            Console.WriteLine("\nPRESS ENTER TO CONTINUE...");
            Console.ReadKey();

            Console.WriteLine("\nIn a second part, we enqueue 6 strings : "); //We make a second example with another variable type to proove the generics works
            Console.WriteLine("     - It");
            Console.WriteLine("     - Is");
            Console.WriteLine("     - Raining");
            Console.WriteLine("     - Cats");
            Console.WriteLine("     - And");
            Console.WriteLine("     - Dogs\n");

            CustomQueue<string> customQueueString = new CustomQueue<string>(new Node<string>("It"));//We do the same things as above with strings
            customQueueString.Enqueue(new Node<string>("Is"));
            customQueueString.Enqueue(new Node<string>("Raining"));
            customQueueString.Enqueue(new Node<string>("Cats"));
            customQueueString.Enqueue(new Node<string>("And"));
            customQueueString.Enqueue(new Node<string>("Dogs"));

            Console.WriteLine("Then we dequeue 3 times.\n");
            Node<string> temp2 = customQueueString.DequeueAndRetreive();
            temp2 = customQueueString.DequeueAndRetreive();
            temp2 = customQueueString.DequeueAndRetreive();

            Console.WriteLine("Here is how our final queue looks like : ");
            string result2 = "[";
            foreach (var node in customQueueString)
            {
                result2 += node + " ; ";
            }
            result2 = result2.Remove(result2.Length - 3);
            result2 += "]";
            Console.WriteLine(result2);

            Console.WriteLine("\nPRESS ENTER TO QUIT...");
            Console.ReadKey();
        }
    }
}
