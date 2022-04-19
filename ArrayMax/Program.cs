    using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number of elements to be stored in the array :");
            int i, max, n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            max = arr[0];
           
  
           S
            Console.WriteLine("Input {0} elements in the array :\n", n);

            for (i = 0; i < n; i++)
            {
                Console.WriteLine(i + 0 + " st index : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());

                if (arr[i] > max)
                {
                    max = arr[i];
                    
                }

            }
            Console.WriteLine(max + " is max in array");










        }
    }
}
