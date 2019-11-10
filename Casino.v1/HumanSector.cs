using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.v1
{
    class HumanSector:Human
    {
        public HumanSector() : base()
        {
            type = TypeRate.sector;
            coefficient = 360;
        }

        public override void DoRate()
        {
            numberRate = Rand.GetNubmer();
        }

    }
}
