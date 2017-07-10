using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumberAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            string playagain;


            Console.WriteLine("\t Welcome to Guess the Lucky Numbers!! The JACKPOT is now $250,000!!! \n ");
            Console.WriteLine("\t To win the Jackpot you must guess the numbers correctly! ");
            // Ask the user for a starting number for the lowest number in the number range.
            // Ask the user for an ending number for the highest number in the number range.
            // let user aware of jackpot #
            
            Console.WriteLine("\t \t To play you must input two numbers.\n ");
            Console.WriteLine("Please enter your first number, Make sure its very low between 1 and 30. ");
            int firstNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Now please enter a second number, But make sure its a really high up to 30. ");
            int secNum = int.Parse(Console.ReadLine());

            //ask the user to guess the 6 numbers the user thinks will
            //be the lucky numbers generated within the number range.
            Console.WriteLine("Now please enter 6 numbers you think are lucky between the 2 numbers already");
            int number = int.Parse(Console.ReadLine());
            int[] selNum = new int[6];

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Enter a number");
                selNum[i] = int.Parse(Console.ReadLine());

                {
                    while (selNum[i] < firstNum && selNum[i] > secNum)
                    {
                        Console.WriteLine("Invalid number, Please enter a number between 1 and 30.");
                       
                    }
                }
                //  Array must be populated using a loop
                //  set my array, store in array
                //  gen random number and compare them to users picked 6 numbers
                //
                //needed to add a counter but was unsuccessful
                Random ranNumber = new Random();
                 
                int[] luckyNumbers = { ranNumber.Next(1, 31) };
                foreach (int num in luckyNumbers)
                    Console.WriteLine("Your Lucky Number Is: " + num);
                for (int l = 0; l < luckyNumbers.Length; l++)
                    if (selNum[i] == luckyNumbers[l])
               
                {
                    if (selNum[i] != ranNumber.Next())
                    {

                        Console.WriteLine("You didnt guess correctly.");
                    }
                }
            }
           // ask user if they want to try again.
           // if yes start over/ no = end game
           

                Console.WriteLine("Do you want to try again? YES or NO");
                playagain = Console.ReadLine().ToUpper();

                if (playagain == "NO")

                    Console.WriteLine("Thanks for Playing!!");
            }
        }
    }

                        
           
        
    







