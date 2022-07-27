using System;

namespace chapTer5
{
    class Program
    {
        static void Main(string[] args)
        {
         
         Console.WriteLine("no. 1");
         Console.Write("Enter first number: ");
         int length = Int32.Parse(Console.ReadLine());
    
          for (int i = 1; i < length; i++)
         Console.WriteLine(i);
         Console.WriteLine();



         Console.WriteLine("no. 2");
         Console.Write("Enter N: ");
         int length2 = Int32.Parse(Console.ReadLine());

         for (int i = 1; i < length2; i++)
            
         if (i % 3 * 7 == 0 )
         {
          Console.WriteLine(i); 
         }
         Console.WriteLine();


          Console.WriteLine("no. 3");
          int lowest = 0, highest = 0, input;

            Console.Write("Enter numbers length: ");
            int lenght = Int32.Parse(Console.ReadLine());            

            for (int i = 0; i < lenght; i++)
            {
                Console.Write("Enter number: ");
                input = Int32.Parse(Console.ReadLine());
                if (i == 0) lowest = highest = input;
                else
                {
                    if (lowest > input) lowest = input;
                    if (highest < input) highest = input;
                }                
            }
            Console.WriteLine("Lowest - {0}, Highest - {1}", lowest, highest);
         
         
         
         
        }
    }
}
