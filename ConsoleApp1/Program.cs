using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            //ex. 1 array from 1 to 10
            /*int[] x = new int[10];
            for (int i = 1;i < 11; i++ )
            {
                x[i - 1] = i;
            }
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine( x[i] +" ");
            }
            Console.ReadLine();*/

            //ex.2 array num of even, add and zero
            /* int[] arr = new int[10];
             int counteven = 0;
             int countodd = 0;
             int countzero = 0;

             for (int i = 0; i < arr.Length; i++)
             {
                 Console.WriteLine("Please enter a {0} number :", i + 1);
                 arr[i] = int.Parse(Console.ReadLine());
                 if (arr[i] == 0)
                 {
                     countzero++;
                 }
                 else if (arr[i] % 2 == 0)
                 {
                     counteven++;
                 }
                 else
                 {
                     countodd++;
                 }
             }
                 Console.WriteLine("number of zero in array : " + countzero);
                 Console.WriteLine("number of even numbers in array : " + counteven);
                 Console.WriteLine("number of odd numbers in array : " + countodd);
             */
            // ex.5 multipletable
            /*int[,] multipletable = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    multipletable[i, j] = (i+1) * (j+1);
                }

            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (multipletable[i, j] < 10)
                        {
                        Console.Write(multipletable[i, j] + "  ");
                    }
                    else
                    {
                        Console.Write(multipletable[i, j] + " ");
                    }
                }
                Console.WriteLine();
                

            }
            */
            //ex.4 
            /*Console.WriteLine("Please enter a number : ");
            int plus = int.Parse(Console.ReadLine());// even
            int counter = 0;
            int counter2 = plus / 2;
            if (plus % 2 == 0)
            {
                for (int i = 0; i < (plus / 2 + 1); i++)
                {
                    for (int j = 0; j < plus; j++)
                    {
                        if ((j < (plus / 2) + counter) && j > (plus / 2) - counter)
                            Console.Write("+");
                        else
                            Console.Write(" ");
                    }
                    counter++;
                    Console.WriteLine();
                }
                for (int i = plus; i > (plus / 2); i--)
                {
                    for (int j = (plus); j > 0; j--)
                    {
                        if ((j < (plus / 2) + counter2) && j > (plus / 2) - counter2)
                            Console.Write("+");
                        else
                            Console.Write(" ");
                    }
                    counter2--;
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < (plus / 2+2); i++)
                {
                    for (int j = 0; j < plus; j++)
                    {
                        if ((j < (plus / 2) + counter) && j > (plus / 2) - counter)
                            Console.Write("+");
                        else
                            Console.Write(" ");
                    }
                    counter++;
                    Console.WriteLine();
                }
                for (int i = plus; i > (plus / 2-1); i--)
                {
                    for (int j = (plus-1); j > 0; j--)
                    {
                        if ((j < (plus / 2) + counter2) && j > (plus / 2) - counter2)
                            Console.Write("+");
                        else
                            Console.Write(" ");
                    }
                    counter2--;
                    Console.WriteLine();
                }
            }*/

            // ex 6 1 to 20
            /*int[] arr20 = new int[20];
            int input;
            Console.WriteLine("Please enter a number between 1 to 20");
            input = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr20.Length; i++)
            {
                arr20[i] = 0;
            }
            while (input != 0)
            {
                if (input >=1 && input <= 20)
                {
                    arr20[input-1]++;
                }
                else
                {
                    Console.WriteLine(" The number of out of range");
                }
                Console.WriteLine("Please enter a number between 1 to 20");
                input = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr20.Length; i++)
            {
                if (arr20[i] != 0)
                    Console.WriteLine("number {0} is present {1} numbers", i+1, arr20[i]);
            }
            */
            //ex 3 number of students
            Console.WriteLine("Enter a number of students");
            int num = int.Parse(Console.ReadLine());
            int[] studentarray = new int[num];
            int sum = 0;
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter a graid of student number " + (i+1));
                studentarray[i] = int.Parse(Console.ReadLine());
                if (studentarray[i] >= 0 && studentarray[i] <= 100)
                {
                    if (studentarray[i] < 60 && studentarray[i] >= 0)
                    {
                        sum++;
                    }
                    else if (studentarray[i] >= 60 && studentarray[i] < 95)
                    {
                        sum1++;
                    }
                    else 
                    {
                        sum2++;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong graid");
                }
            }
            Console.WriteLine("Students with graid under 60 : "+sum);
            Console.WriteLine("Students with graid from 60 to 94 : "+ sum1);
            Console.WriteLine("Students with graid over 94 : "+ sum2);


        }
    }
}
