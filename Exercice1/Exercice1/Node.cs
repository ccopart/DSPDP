using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Exercice1
{
    public class Node<T> : IEquatable<Node<T>>
    {
        public Node(T data)
        {
            this.data = data;
            this.previous = null;
            this.next = null;
        }

        public T data { get; set; }
        public Node<T> previous { get; set; }
        public Node<T> next { get; set; }

        public bool Equals(Node<T> other)
        {
            throw new NotImplementedException();
        }
    }
}
