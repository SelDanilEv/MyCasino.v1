using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.v1
{
    class Human
    {
        public Human()
        {
            cash = 1000;
        }


        public TypeRate type;

        public enum TypeRate:int
        {
            zero = 0,
            color,
            sector
        }
        

        public int cash;
        public int numberRate;
        public bool colorRate;
        public int rate = 100;
        public int coefficient;

        public bool alive() { if (cash > 0) return true; else return false; }

        public virtual void DoRate() { }
    }
}
