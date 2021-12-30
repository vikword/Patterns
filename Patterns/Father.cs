using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Father
    {
        public State State { get; set; }
        public Father()
        {
            State = new StateNeutral();
        }
        public void FindOut(Mark mark)
        {
            State.HandleMark(this, mark);
        }
    }
}
