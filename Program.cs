using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int size = 25;
                int[] elements = new int[size];
                for(int i=0; i <=25; i++)
                {
                    elements[i] = i+1;
                    Console.WriteLine("Element Value = " + elements[i]);

                }
                
            }
            catch
            {
                Console.ReadKey();
            }
        }
    }
}
