using System;

namespace TestCs //Replace "TestCS" with the solution name you assigned to the project.
{
    class MainClass
    {
        public static void Main(string[] args)
        {
        start:
            Random numbergen = new Random();
            Console.Write("Rock, paper or scissor? ");
            string[] rps = new string[3];
            rps[0] = "rock"; 
            rps[1] = "paper";
            rps[2] = "scissor";
//These are the options you have.

            string answer = Console.ReadLine().ToLower();

            if (answer != rps[0] && answer != rps[1] && answer != rps[2])
            {
                Console.WriteLine("Please pick either rock, paper or scissor.");
                goto start;
            }
//This makes sure the only possible answers are the one listed above, and if it is something else, it will restart.
            int num;
            int indexer = 5;

            switch (answer) 
            {
                case "rock":
                    num = 0;
                    indexer = numbergen.Next(0, 3);
                    break;
                case "paper":
                    num = 1;
                    indexer = numbergen.Next(0, 3);
                    break;
                default:
                    num = 2;
                    indexer = numbergen.Next(0, 3);
                    break;
            }
//This gives your answer a certain value, which is stored in num.
            string pick = rps[indexer];
//This is the choice of the console.
            if (num - indexer == 0) 
            {
                Console.WriteLine("We tied!");
            } else if (num - indexer == -1 || num - indexer == 2)
            {
                Console.WriteLine("I picked " + pick + ". That means I win!");
            } else 
            {
                Console.WriteLine("I picked " + pick + ". So that means you win!");
            }
/*

If the value stored in num is equal to the value in indexer, you tied with the bot. 
Else, it checks if num - indexer is -1 or 2. If that's the case, you lost. 
In any other scenario, you win!

*/
            goto start;
        }
    }
}
