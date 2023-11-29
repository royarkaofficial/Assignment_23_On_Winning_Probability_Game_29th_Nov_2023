using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_23_On_Winning_Probability
{
    internal class Game
    {
        private string playerName;
        private int luckyNumber;
        private int energyLevel;
        private int winningProbability;
        private int numberOfSpins = 5;

        public Game(string playerName, int luckyNumber)
        {
            this.playerName = playerName;
            this.luckyNumber = luckyNumber;
            this.energyLevel = 1;
            this.winningProbability = 100;
        }

        public void Play()
        {
            SpinDelegate spinDelegate = Spin;

            for (int i = 1; i <= numberOfSpins; i++)
            {
                Console.WriteLine($"\nSpin {i}:");
                spinDelegate(ref energyLevel, ref winningProbability);
                Console.WriteLine($"Energy Level: {energyLevel}, Winning Probability: {winningProbability}");
            }

            Console.WriteLine("\nGame Result:");

            if (energyLevel >= 4 && winningProbability > 60)
            {
                Console.WriteLine($"{playerName} is the Winner!");
            }
            else if (energyLevel >= 1 && winningProbability > 50)
            {
                Console.WriteLine($"{playerName} is the Runner Up!");
            }
            else
            {
                Console.WriteLine($"{playerName} is the Loser!");
            }
        }

        private delegate void SpinDelegate(ref int energyLevel, ref int winningProbability);

        private void Spin(ref int energyLevel, ref int winningProbability)
        {
            switch (energyLevel)
            {
                case 1:
                    energyLevel++;
                    winningProbability += 10;
                    break;
                case 2:
                    energyLevel += 2;
                    winningProbability += 20;
                    break;
                case 3:
                    energyLevel -= 3;
                    winningProbability -= 30;
                    break;
                case 4:
                    energyLevel += 4;
                    winningProbability += 40;
                    break;
                case 5:
                    energyLevel += 5;
                    winningProbability += 50;
                    break;
                case 6:
                    energyLevel -= 1;
                    winningProbability -= 60;
                    break;
                case 7:
                    energyLevel += 1;
                    winningProbability += 70;
                    break;
                case 8:
                    energyLevel -= 2;
                    winningProbability -= 20;
                    break;
                case 9:
                    energyLevel -= 3;
                    winningProbability -= 30;
                    break;
                case 10:
                    energyLevel += 10;
                    winningProbability += 100;
                    break;
                default:
                    break;
            }
        }
    }
}
