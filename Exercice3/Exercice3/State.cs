using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice3
{
    public interface State
    {
        State DoState(Player player);
    }
}
