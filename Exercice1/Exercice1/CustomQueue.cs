using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice1
{
    class CustomQueue<T>
    {
        public CustomQueue(Node<T> header)
        {
            this.head = header;
        }

        Node<T> head { get; set; }

        public void Enqueue(Node<T> node)
        {
            Node<T> new_node = new Node<T>(node.data);

            if (head == null)
                head = new_node;
            else
            {
                Node<T> temp = head;
                new_node.next = temp;
                temp.previous = new_node;
                head = new_node;
            }
        }

        public Node<T> DequeueAndRetreive()
        {
            Node<T> current = head;
            Node<T> dequeued;
            while (current.next != null)
            {
                dequeued = current.previous;
                current = current.next;
            }
            current.previous.next = null;
            current.previous = null;
            return current;
        }

        //public Node<T> getNode(int index)
        //{
        //    int pos = 0;
        //    Node<T> current = head;
        //    while (index > pos)
        //    {
        //        pos++;
        //        current = current.next;
        //    }
        //    return current;
        //}

        //public void setNode(Node<T> node, int index)
        //{
        //    int pos = 0;
        //    Node<T> current = head;
        //    Node<T> new_node = new Node<T>(node.data);
        //    while (pos < index)
        //    {
        //        pos++;
        //        current = current.next;
        //    }
        //    current.previous.next = new_node;
        //    new_node.previous = current.previous;
        //    new_node.next = current.next;
        //    if (current.next != null)
        //        current.next.previous = new_node;
        //}


        public void print()
        {
            string s = "[";
            Node<T> current = head;
            while (current != null)
            {
                s += current.data + " ; ";
                current = current.next;
            }
            s = s.Remove(s.Length - 3);
            s += "]";
            Console.WriteLine(s);
        }
    }
}
