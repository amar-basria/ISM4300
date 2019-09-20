using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                GetName();


            }

                void GetName()
                {

                    Console.WriteLine("Please enter your name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Hello " + name + "!");
                }

            

        }
    }
}
