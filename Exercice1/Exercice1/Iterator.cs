using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice1
{
    public interface Iterator<T>
    {
        public bool HasNext();
        public void Next();
        public T Current();
    }
}
