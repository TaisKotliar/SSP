using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool isGame = true;

            while (isGame)
            {
                Game game = new Game();
                game.Greeting();
                game.YourChoice();
                game.ComputerChoice();
                game.Compare();
                Console.WriteLine("\n" + "==============" +
                        "\n" + "Would you like to play again?" +
                        "\n" + "Y / N");
                isGame = game.NewGame();
            }
            Console.ReadKey();





        }
    }
}
