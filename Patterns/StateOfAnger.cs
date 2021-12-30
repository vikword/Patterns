using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class StateOfAnger : State
    {
        public StateOfAnger()
        {
            Console.WriteLine("Отец в злом состоянии.");
            Scold();
        }
        protected override void ChangeState(Father father, Mark mark)
        {
            switch (mark)
            {
                case Mark.Two:
                    father.State = new StateOfIntenseAnger();
                    break;
                case Mark.Five:
                    father.State = new StateOfJoy();
                    break;
            }
        }
        private void Scold()
        {
            Console.WriteLine("Ругается на ребенка.");
        }
    }
}
