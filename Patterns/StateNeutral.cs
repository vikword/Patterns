using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class StateNeutral : State
    {
        public StateNeutral()
        {
            Console.WriteLine("Отец в нейтральном состоянии:");
            Hope();
        }
        protected override void ChangeState(Father father, Mark mark)
        {
            switch (mark)
            {
                case Mark.Two:
                    father.State = new StateRegret();
                    break;
                case Mark.Five:
                    father.State = new StateOfJoy(); 
                    break;
            }
        }

        private void Hope()
        {
            Console.WriteLine("Надеется на хорошие оценки.");
        }
    }
}
