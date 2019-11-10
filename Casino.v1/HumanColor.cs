using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.v1
{
    class HumanColor : Human
    {
        public HumanColor() : base()
        {
            type = TypeRate.color;
            coefficient = 180;
        }

        public override void DoRate()
        {
            colorRate = Rand.GetColor();
        }
    }
}
