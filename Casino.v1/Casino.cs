using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.v1
{
    class Casino
    {
        public Casino(Bank mybank)
        {
            cash = 100000;
            alive = true;
            localBank = mybank;
        }

        Bank localBank;
        public int cash;
        private int _currentNumber;
        private bool _currentColor;

        public bool alive;
        private bool color { get { if (_currentNumber % 2 == 0) return true; else return false; } }  //нечет false     чет true

        public void StartCasino()
        {
            _currentNumber = Rand.GetAllNubmer();
                _currentColor = color;
        }

        public void CheckWinners(Human[] humans)
        {
            foreach (Human human in humans)
            {
                switch (human.type)
                {
                    case Human.TypeRate.zero:
                        if (_currentNumber == 0)
                            localBank.Transfer(this, human, true);
                        else
                            localBank.Transfer(this, human, false);
                        break;
                    case Human.TypeRate.color:
                        if (_currentNumber != 0)
                            if (_currentColor = human.colorRate)
                                localBank.Transfer(this, human, true);
                            else
                                localBank.Transfer(this, human, false);
                        break;
                    case Human.TypeRate.sector:
                        if (Rand.GetSector(_currentNumber) == Rand.GetSector(human.numberRate))
                            localBank.Transfer(this, human, true);
                        else
                            localBank.Transfer(this, human, false);
                        break;
                }
            }
        }
    }
}
