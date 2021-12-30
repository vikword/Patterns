using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class StateOfIntenseJoy : State
    {
        public StateOfIntenseJoy()
        {
            Console.WriteLine("Отец в очень радостном состоянии.");
            Exalt();
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
        private void Exalt()
        {
            Console.WriteLine("Отец гордится сыном.");
        }
    }
}
