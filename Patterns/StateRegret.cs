using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class StateRegret : State
    {
        public StateRegret()
        {
            Console.WriteLine("Отец в состоянии жалости.");
            Calm();
        }
        protected override void ChangeState(Father father, Mark mark)
        {
            switch (mark)
            {
                case Mark.Two:
                    father.State = new StateOfAnger();
                    break;
                case Mark.Five:
                    father.State = new StateOfJoy();
                    break;
            }
        }
        private void Calm()
        {
            Console.WriteLine("Успокаевать ребенка.");
        }
    }
}
