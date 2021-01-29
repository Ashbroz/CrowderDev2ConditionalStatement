/* 
 Author : Ashton Crowder
Date: 1/29/2021

*/

using System;

namespace CrowderDev2ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
            
        {
            // Ask the user for input
            Console.WriteLine("Please type in what number grade you expect to get in ISM 4300...");
            /*
             Use try catch to validate user input
            */
            try
            {
                // This variable will gather the user input
                string input = Console.ReadLine();
                /*
                 This variable will be used to store grades after the input variable is parsed to decimal
                */
                decimal grade = decimal.Parse(input);

                // Using if function to determine letter grade based on user input
                if (grade >= 98)
                {
                    Console.WriteLine("A+");
                }
                else if (grade >= 92)
                {
                    Console.WriteLine("A");
                }
                else if (grade >= 90)
                {
                    Console.WriteLine("A-");
                }
                else if (grade >= 88)
                {
                    Console.WriteLine("B+");
                }
                else if (grade >= 82)
                {
                    Console.WriteLine("B");
                }
                else if (grade >= 80)
                {
                    Console.WriteLine("B-");
                }
                else if (grade >= 78)
                {
                    Console.WriteLine("C+");
                }
                else if (grade >= 72)
                {
                    Console.WriteLine("C");
                }
                else if (grade >= 70)
                {
                    Console.WriteLine("C-");
                }
                else if (grade >= 68)
                {
                    Console.WriteLine("D+");
                }
                else if (grade >= 62)
                {
                    Console.WriteLine("D");
                }
                else if (grade >= 60)
                {
                    Console.WriteLine("D-");
                }
                else
                {
                    Console.WriteLine("F");
                }
            }
            // Using catch to catch any errors in the user input
            catch 
            { 
                Console.WriteLine("Please give a whole number between 0 and 100");
            }
           }
        }
    } // End of program


