using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice1
{
    public class CustomQueueIterator<T> : Iterator<T>
    {
        Node<T> index;
        CustomQueue<T> s;
        public CustomQueueIterator(CustomQueue<T> s)
        {
            this.s = s;
        }

        public bool HasNext()
        {
            if (index == null)
                return s.head != null;
            else
                return index.next != null;
        }

        public void Next()
        {
            if (index == null)
                index = s.head;
            else
                index = index.next;
        }

        T Iterator<T>.Current()
        {
            return index.data;
        }
    }
}
