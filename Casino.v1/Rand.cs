using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.v1
{
    public static class Rand
    {
        public static Random random = new Random();
        public static int GetSector(int r)
        {
            if (r == 0) return 0;
            if (r > 0 && r < 9) return 1;
            if (r > 8 && r < 17) return 2;
            if (r > 16 && r < 24) return 3;
            return 4;
        }
        public static int GetAllNubmer() => random.Next(0,32);
        public static int GetNubmer() => random.Next(1,32);
        public static bool GetColor() { if (GetNubmer() % 2 == 0) return true; else return false; }
    }
}
