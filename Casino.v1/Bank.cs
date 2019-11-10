using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.v1
{
    class Bank
    {
        public void Transfer(Casino casino, Human human, bool humanWin)
        {
            int transferMoney;

            if (human.cash < human.rate)
                human.rate = human.cash;
            transferMoney = human.rate;
            human.cash -= human.rate;
            casino.cash += transferMoney;

            if (humanWin)
            {
                if (casino.cash < human.rate * human.coefficient/100)
                {
                    transferMoney = casino.cash;
                    casino.alive = false;
                }
                else
                    transferMoney = human.rate * human.coefficient/100;
                human.cash += transferMoney;
                casino.cash -= transferMoney;
            }
            human.rate = 100;
        }
    }
}
