using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    class Human : Player
    {
        public override string MakeChoice()
        {
            Console.WriteLine("rock,paper,scissors,lizard,spock");
            string input=Console.ReadLine();
            switch (input)
            {
                case "rock":
                    choice = input;
                    break;
                case "paper":
                    choice = input;
                    break;
                case "scissor":
                    choice = input;
                    break;
                case "lizard":
                    choice = input;
                    break;
                case "spock":
                    choice = input;
                    break;
                default:
                    Console.WriteLine("please input correct response");
                    return MakeChoice();

            }
            return input;
        }
    }
}
