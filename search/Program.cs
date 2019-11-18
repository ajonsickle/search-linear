using System;

namespace search
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] x = new int[] {1, 22, 65, 87, 91 };

            bool found = false;

            int i = 0;

            Console.WriteLine("Linear Search! Please enter the value you would like to search for.");

            int val = Convert.ToInt32(Console.ReadLine());

            while (found == false && i < x.Length)
            {
                if (val == x[i])
                {
                    found = true;
                }
                else
                {
                    i = i + 1;
                }
            }

            if (found == true)
            {
                Console.WriteLine(x[i] + " - Found your number!");
            }
            else
            {
                Console.WriteLine("Your value is not in the array!");
            }



        }
    }
}
