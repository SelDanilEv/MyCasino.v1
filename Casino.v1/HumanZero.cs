using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.v1
{
    class HumanZero:Human
    {
        public HumanZero() : base()
        {
            type = TypeRate.zero;
            coefficient = 5000;
        }

        public override void DoRate()
        {
            numberRate = 0;
        }
    }
}
