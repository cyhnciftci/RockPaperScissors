using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int aWin = 0;
            int bWin = 0;
            int tie = 0;
            Random r = new Random();

            for (int i = 1; i <= 100; i++)
            {
                //Rock=1,Paper=2,Scissors=3

                int playerB = r.Next(1, 4);
                int playerA = 2;

                if (playerB == 1)
                {
                    aWin += 1;



                }
                else if (playerB == 2)
                {
                    tie += 1;
                }
                else if (playerB == 3)
                {
                    bWin += 1;
                }

            }
            Console.WriteLine("Player A wins {0} of 100 games", aWin);
            Console.WriteLine("Player B wins {0} of 100 games", bWin);
            Console.WriteLine("Tie: {0} of 100 games", tie);




            Console.ReadLine();
        }
    }
}
