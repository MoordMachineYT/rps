using System;

namespace TestCs
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


            string answer = Console.ReadLine().ToLower();

            if (answer != rps[0] && answer != rps[1] && answer != rps[2]) 
            {
                Console.WriteLine("Please pick either rock, paper or scissor.");
                goto start;
            }

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

            string pick = rps[indexer];

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
            goto start;
        }
    }
}
