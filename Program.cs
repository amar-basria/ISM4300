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

                    Console.WriteLine("Please enter an integar value between 1 and 100: ");

                    int integar = int.Parse(Console.ReadLine());


                    if (integar < 0 || integar > 100)
                    {
                        Console.WriteLine("Integer is not within the range of 1-100");

                    }
                    else
                    {
                        for (int x = 1; x < 11; x++)

                        {
                            Console.WriteLine("You have entered " + integar + " This is the current integer value in the loop: " + x.ToString());
                        }



                    }

                }
            }
            catch
            {



                Console.WriteLine("Please enter a integar");

            }
		}
	}
}
