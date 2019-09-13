using System;

namespace Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                for (int x = 0; x < 10; x++)
                {
                    Console.WriteLine("Enter your marks for ISM 4300 ");
                    int marks = int.Parse(Console.ReadLine());
                    if (marks < 0 || marks > 100)
                    {
                        Console.WriteLine("Invalid Number");
                    }
                    else if (marks < 60)
                    {
                        Console.WriteLine("Your grade for this class is F");

                    }
                    else if (marks >= 60 && marks <= 61)
                    {
                        Console.WriteLine("Your grade for this class is D-");

                    }
                    else if (marks >= 62 && marks <= 67)
                    {
                        Console.WriteLine("Your grade for this class is D");

                    }
                    else if (marks >= 68 && marks <= 69)
                    {
                        Console.WriteLine("Your grade for this class is D+");

                    }
                    else if (marks >= 70 && marks <= 71)
                    {
                        Console.WriteLine("Your grade for this class is C-");

                    }
                    else if (marks >= 72 && marks <= 77)
                    {
                        Console.WriteLine("Your grade for this class is C");

                    }
                    else if (marks >= 78 && marks <= 79)
                    {
                        Console.WriteLine("Your grade for this class is C+");

                    }
                    else if (marks >= 80 && marks <= 81)
                    {
                        Console.WriteLine("Your grade for this class is B-");

                    }
                    else if (marks >= 82 && marks <= 87)
                    {
                        Console.WriteLine("Your grade for this class is B");

                    }
                    else if (marks >= 88 && marks <= 89)
                    {
                        Console.WriteLine("Your grade for this class is B+");

                    }
                    else if (marks >= 90 && marks <= 91)
                    {
                        Console.WriteLine("Your grade for this class is A-");

                    }
                    else if (marks >= 92 && marks <= 97)
                    {
                        Console.WriteLine("Your grade for this class is A");

                    }
                    else if (marks >= 98 && marks <= 100)
                    {
                        Console.WriteLine("Your grade for this class is A+");

                    }


                }
                
            }
            catch
            {
                Console.WriteLine("Please enter an integer");
            }

        }
    }
}
