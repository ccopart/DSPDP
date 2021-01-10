using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice1
{
    public class CustomQueue<T>
    {
        public CustomQueue(Node<T> header)
        {
            this.head = header;
        }

        public Node<T> head { get; set; }

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

        public IEnumerator<T> GetEnumerator()
        {
            Iterator<T> i = new CustomQueueIterator<T>(this);
            while (i.HasNext())
            {
                i.Next();
                yield return i.Current();
            }
        }
    }
}
