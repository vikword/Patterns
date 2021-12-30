using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class StateOfIntenseAnger : State
    {
        public StateOfIntenseAnger()
        {
            Console.WriteLine("Отец в очень злом состоянии.");
            BeatBelt();
        }
        protected override void ChangeState(Father father, Mark mark)
        {
            switch (mark)
            {
                case Mark.Two:
                    father.State = new StateOfIntenseAnger();
                    break;
                case Mark.Five:
                    father.State = new StateOfAnger();
                    break;
            }
        }
        private void BeatBelt()
        {
            Console.WriteLine("Будет бить ремнем.");
        }
    }
}
