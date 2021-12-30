using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal abstract class State
    {
        internal void HandleMark(Father father, Mark mark)
        {
            ChangeState(father, mark);
        }
        protected abstract void ChangeState(Father father, Mark mark);
    }
}
