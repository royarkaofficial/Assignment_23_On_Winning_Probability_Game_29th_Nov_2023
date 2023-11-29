using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_23_On_Winning_Probability
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Winner Determination Game!");

            Console.Write("Enter Your Name: ");
            string playerName = Console.ReadLine();

            Console.Write("Enter Your Lucky Number from 1 to 10: ");
            int luckyNumber;
            while (!int.TryParse(Console.ReadLine(), out luckyNumber) || luckyNumber < 1 || luckyNumber > 10)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 10.");
            }

            Game game = new Game(playerName, luckyNumber);
            game.Play();

            Console.ReadKey();
        }
    }
}
