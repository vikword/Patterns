using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class StateOfJoy : State
    {
        public StateOfJoy()
        {
            Console.WriteLine("Отец в состоянии радости.");
            Joy();
        }
        protected override void ChangeState(Father father, Mark mark)
        {
            switch (mark)
            {
                case Mark.Two:
                    father.State = new StateRegret();
                    break;
                case Mark.Five:
                    father.State = new StateOfIntenseJoy();
                    break;
            }
        }
        private void Joy()
        {
            Console.WriteLine("Радуется.");
        }
    }
}
