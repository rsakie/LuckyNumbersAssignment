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



            //Console.WriteLine("Welcome to Lucky Numbers!!");

            //// Ask the user for a starting number for the lowest number in the number range.
            //// Ask the user for an ending number for the highest number in the number range.

            //Console.WriteLine("To play you must input two numbers.\n");
            //Console.WriteLine("Please enter your first number, Make sure its between 1 and 30 and very low.\n");
            //int firstNum = int.Parse(Console.ReadLine());

            //Console.WriteLine("Now please enter a second number, But make it a really high one upto 30.\n");
            //int secNum = int.Parse(Console.ReadLine());

            //Console.WriteLine("Now please enter 6 numbers");
            ////set my array
            //int[] luckyNumbers = new int[6];
            //for (int i = 0; i < luckyNumbers.Length; i++)
            //{
            //    Console.WriteLine("Please enter a number between 1 and 30");
            //    luckyNumbers[i] = int.Parse(Console.ReadLine());
            //    if (luckyNumbers[i] < firstNum || luckyNumbers[i] > secNum)
            //    {
            //        Console.WriteLine("Please enter a number between 1 and 30");
            //        break;
            //    }
            //    else if (firstNum < 1 || firstNum > 30)
            //    {
            //        Console.WriteLine("Please enter a number between 1 and 30");
            //        break;
            //    }
            //    if (secNum > 30 || secNum < 1)
            //    {
            //        Console.WriteLine("Please enter a number between 1 and 30");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine();
            //    }
            //}


            //ask the user to guess the 6 numbers the user thinks will be the lucky numbers generated within the number range.
            // Numbers must be stored in an array
            // Array must be populated using a loop
            //If the user enters a number that is outside of the range set,
            //  prompt the user to give you a valid number. Do this until the user enters a valid number
            //generate a  6 random numbers
             Random randomNumber = new Random();
            int luckyNumbers = randomNumber.Next(1,30);
            
            Console.WriteLine("Your Lucky Numbers are: "+ " " + luckyNumbers); 
           
           
            //int numOne = randomNumber.Next(1, 30);
            //Console.WriteLine("Lucky Number" + " " + numOne);
            //int numTwo = randomNumber.Next(1, 30);
            //Console.WriteLine("Lucky Number" + " " + numTwo);
            //int numThree = randomNumber.Next(1, 30);
            //Console.WriteLine("Lucky Number" + " " + numThree);
            //int numFour = randomNumber.Next(1, 30);
            //Console.WriteLine("Lucky Number" + " " + numFour);
            //int numFive = randomNumber.Next(1, 30);
            //Console.WriteLine("Lucky Number" + " " + numFive);
            //int numSix = randomNumber.Next(1, 30);
            //Console.WriteLine("Lucky Number" + " " + numSix);
            //int[] randomSix = { numOne, numTwo, numThree, numFour, numFive, numSix };



        }
        }
    }


