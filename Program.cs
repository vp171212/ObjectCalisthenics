using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameOfPigDice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int score;
            int turnScore;
            int turns;


            void Main()
            {
                StartGame();

                while (score < 20)
                {
                    TakeTurn();
                }
                Console.WriteLine("Congratulations, you win");
                Console.WriteLine($"You finished in {turns} turns!");
            }


            void StartGame()
            {
                score = 0;
                turns = 0;

                Console.WriteLine("~~~~~~Let's Play PIG~~~~~~");
                Console.WriteLine("See how many turns it takes to get to 20");
                Console.WriteLine("If you Roll 1, you lose all the points for the turn");
                Console.WriteLine("If you hold, you save all the points for the turn");
                Console.WriteLine("Type 'r' to roll, 'h' to hold");
            }


            void TakeTurn()
            {
                turns++;

                Console.WriteLine("\n------------------------------------------------------");
                Console.WriteLine("Turn " + turns);
                Console.WriteLine("Welcome to the game of Pig!");

                turnScore = 0;

                Console.WriteLine("Please roll (r)");
                string input = Console.ReadLine();

                while (input == "r")
                {
                    RollDice();

                    Console.WriteLine("Roll again or hold? (r/h)");
                    input = Console.ReadLine();
                }
                score += turnScore;
                Console.WriteLine("Your Turn Score: " + turnScore);
                Console.WriteLine("Your Total Score: " + score);

               
            }


            void RollDice()
            {
                int output = new Random().Next(1, 7);

                Console.WriteLine("You rolled a " + output);

                if (output == 1)
                    turnScore = 0;
                else
                turnScore += output;
           
                Console.WriteLine("Your turn score is " + turnScore);
                Console.WriteLine("Your total score is " + score);
                Console.WriteLine($"If you hold,your total score is {turnScore + score}");
            }


            Main();
        }
    }
}