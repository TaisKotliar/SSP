using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoneScissorsPaper
{

    internal class Game
    {
        int yourChoice;
        int computerChoice;
        public Random rnd = new Random  ();

        enum options
        {
            Stone = 1,
            Scissors = 2,
            Paper = 3
        }

        //public void WriteEnum() // Check enam
        //{
        //    Console.WriteLine((options)3);
        //}
        public void Greeting() // Greeting text
        {
            Console.WriteLine("Let`s play" + "\n" + "==============" +
                                             "\n" + "Enter the number" +
                                             "\n" + "Stone : 1" +
                                             "\n" + "Scissors : 2" +
                                             "\n" + "Paper : 3" +
                                             "\n" + "==============");
        }
        public int YourChoice()
        {
            bool rightDigit = true;
            while (rightDigit)
            {
                try
                {
                    yourChoice = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"{e.Message} Wrong format");

                }
                if ((yourChoice > 3) && (yourChoice < 1))
                {
                    Console.WriteLine("Enter number from 1 to 3, please.");

                }

                else
                {
                    rightDigit = false;

                }
            }



            Console.WriteLine("Your choice is " + ((options)yourChoice));
            return yourChoice;
        }


        public int ComputerChoice()
        {
            computerChoice = rnd.Next(1,4);
            Console.WriteLine("Computer choice is " + (options)computerChoice);
            return computerChoice;
        }
        public void Compare()
        {
            switch (yourChoice)
            {
                case 1:
                    switch (computerChoice)
                    {
                        case 1:
                            Console.WriteLine("It is draw!");
                            break;
                        case 2:
                            Console.WriteLine("You win!");
                            break;
                        case 3:
                            Console.WriteLine("Computer win!");
                            break;
                    }
                    break;
                case 2:
                    switch (computerChoice)
                    {
                        case 1:
                            Console.WriteLine("Computer win!");
                            break;
                        case 2:
                            Console.WriteLine("It is draw!");
                            break;
                        case 3:
                            Console.WriteLine("You win!");
                            break;
                    }
                    break;
                case 3:
                    switch (computerChoice)
                    {
                        case 1:
                            Console.WriteLine("You win!");
                            break;
                        case 2:
                            Console.WriteLine("Computer win!");
                            break;
                        case 3:
                            Console.WriteLine("It is draw!");
                            break;
                    }
                    break;
            }
        }
       public bool NewGame()
        {
            string answer;
         
            answer = Console.ReadLine();
            if (answer.ToUpper() == "Y")
            {
                return true;
            }
            else if (answer.ToUpper() == "N")
            {
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
    