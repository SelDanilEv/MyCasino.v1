using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.v1
{
    class Program
    {
        static void step(Human[] humen, Casino casino)
        {
            foreach (Human human in humen)
            {
                human.DoRate();
            }
            casino.StartCasino();
            casino.CheckWinners(humen);
        }

        static void output(Human[] humen, Casino casino)
        {
            Console.WriteLine("\nHumans:");
            foreach (Human human in humen)
                Console.WriteLine('|' + human.type.ToString() + '|' + human.cash);
            Console.WriteLine("Casino " + casino.cash + '\n');
        }

        static void Main(string[] args)
        {

            Bank mainBank = new Bank();
            Casino mainCasino = new Casino(mainBank);
            while (mainCasino.alive)
            {
                List<HumanColor> humanColor1 = new List<HumanColor>();
                List<HumanSector> humanSector1 = new List<HumanSector>();
                List<HumanZero> humanZero1 = new List<HumanZero>();
                for (int i = 0; i < 5; i++)
                {
                    humanColor1.Add(new HumanColor());
                    humanSector1.Add(new HumanSector());
                    humanZero1.Add(new HumanZero());
                }
                int diff = mainCasino.cash;
                List<Human> humen = new List<Human>();
                humen.AddRange(humanColor1);
                humen.AddRange(humanSector1);
                humen.AddRange(humanZero1);
                while ((mainCasino.cash - diff != humen.Count * 1000) && mainCasino.alive)
                {
                    step(humen.ToArray(), mainCasino);
                    output(humen.ToArray(), mainCasino);
                }
            }

            Console.ReadKey();
        }
    }
}
