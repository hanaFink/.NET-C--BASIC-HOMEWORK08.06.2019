using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main()
        {
            //ex. 1 - math operations
             Console.WriteLine("Please enter first number");
             double first = double.Parse(Console.ReadLine());
             Console.WriteLine("Please enter second number");
             double second = double.Parse(Console.ReadLine());
             Console.WriteLine("Please enter math operation");
             string moperetion = Console.ReadLine();

             if (moperetion ==  "+")
             {
                 Console.WriteLine("The sum of "+ first + " and "+ second+ " is " +(first+second));
                 Console.WriteLine();
             }
             if (moperetion == "-")
             {
                 Console.WriteLine("The subtraction " + second + " from " + first + " is " + (first- second));
                 Console.WriteLine();
             }
             if (moperetion == "*")
             {
                 Console.WriteLine("The multiplication " + first + " by " + second + " is " + (first * second));
                 Console.WriteLine();
             }

             if (moperetion == "/")
             {
                 Console.WriteLine("The division " + first + " by " + second + " is " + (first / second));
                 Console.WriteLine();
             }
             
            // ex. 2 - number of days, hours , minuts and seconds
             Console.WriteLine("Enter a number of seconds");
             int seconds = int.Parse(Console.ReadLine()); // input number is integer
             if ((seconds / (24 * 60 * 60)) > 0)
             {
                 Console.Write("The number of days is " + (seconds / (24 * 60 * 60))+ " ");
                 seconds = seconds % (24 * 60 * 60);
             }
             if ((seconds / (60*60)) > 0)
             {

                 Console.Write("The number of hours is " + (seconds / (  60 * 60))+ " ");
                 seconds = seconds % (60 * 60);
             }
             if ((seconds / 60) > 0)
             {

                 Console.Write("The number of minuts is " + (seconds / 60)+" ");
                 seconds = seconds % 60;
             }

             if (seconds >  0)
             { 
                 Console.Write("The number of seconds is " + seconds+ " ");
             }
             Console.WriteLine();

            // ex. 3 is number positive, even , greater than 100


            Console.WriteLine("Enter a number :");

            int number = int.Parse(Console.ReadLine());// input number is integer
            if (number > 0)
            {
                Console.WriteLine("The number is positive");
            }
            if((number % 2) == 0)
            {
                Console.WriteLine("The number is even number");
            }
            if ((number % 2) != 0)
            {
                Console.WriteLine("The number is odd number");
            
            }
            if (number > 100)
            {
                Console.WriteLine("The number is greater than 100");
            }




        }

    }

         
    }


