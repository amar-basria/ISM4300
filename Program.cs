using System;

namespace Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                for (int i = 0; i < 10; i++)
                {

                    Console.WriteLine("Please enter an integer value between 1 and 100: ");

                    int integer = int.Parse(Console.ReadLine());


                    if (integer < 0 || integer > 100)
                    {
                        Console.WriteLine("Integer is not within the range of 1-100");

                    }
                    else
                    {
                        for (int x = 1; x < 11; x++)

                        {
                            Console.WriteLine("You have entered " + integer + " This is the current integer value in the loop: " + x.ToString());
                        }



                    }

                }
            }
            catch
            {



                Console.WriteLine("Please enter a integer");

            }
		}
	}
}
