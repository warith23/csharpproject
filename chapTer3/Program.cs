using System;

namespace chapTer2
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Write an expression that checks whether an integer is odd or even
          Console.WriteLine("-------Question 1-------");
          Console.WriteLine("Check whether a number is even or odd : ");
          Console.WriteLine("Input an integer : ");
          int num1= Convert.ToInt32(Console.ReadLine()); 
          int rem1 = num1 % 2;
         if (rem1 == 0)
          Console.WriteLine($"{num1} is an even integer.");
          else
          Console.WriteLine($"{num1} is an odd integer");
          
          
          
         // Write a Boolean expression that checks whether a given integer is 
         // divisible by both 5 and 7, without a remainder.


            Console.WriteLine("-------Question 2-------");
            Console.WriteLine("Write a Boolean expression that checks whether a given integer is divisible by both 5 and 7, without a remainder");
            Console.Write("Enter the number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The number: {number2} is divisible by 5 and 7? {(number2 % 5 == 0) && (number2 % 7 == 0)}");
            Console.WriteLine();


            
          // 3. Write an expression that looks for a given integer if its third digit (right 
          // to left) is 7.
          
         Console.WriteLine("-------Question 3-------");
         int number3 = 54746;
         bool seven = (number3/100) % 10 == 7 ? true : false;
         Console.WriteLine("The third digit is seven");

             
        

          // 4. Write an expression that checks whether the third bit in a given integer 
          // is 1 or 0.
           Console.WriteLine("-------Question 4-------");

            
            
            
         // 5. Write an expression that calculates the area of a trapezoid by given 
           // sides a, b and height h.
            
            Console.WriteLine("-------Question 5-------");
            Console.WriteLine("Write an expression that calculates the area of a trapezoid by given sides a, b and height h.Given that  S = (a + b) * h / 2");
            Console.Write("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter h: ");
            int h = Convert.ToInt32(Console.ReadLine());
            double S = (a + b) * h / 2;

            Console.WriteLine($"The area of the trapezoid of a = {a} b = {b} and h = {h} is: {S}");
            Console.WriteLine();



            // 6. Write a program that prints on the console the perimeter and the area 
            // of a rectangle by given side and height entered by the user.
            Console.WriteLine("-------Question 6-------");
            Console.WriteLine("Enter length");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth");
            int breadth = Convert.ToInt32(Console.ReadLine());
             
            int perimeter = 2 * (length * breadth);
            int area = length * breadth;
            
            Console.WriteLine($"The area is {area} and perimeter is {perimeter}");



            // 7. The gravitational field of the Moon is approximately 17% of that on the 
           // Earth. Write a program that calculates the weight of a man on the 
           // moon by a given weight on the Earth.
           
            Console.WriteLine("-------Question 7-------");
            Console.WriteLine("Enter the weight: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            double percentGiven = 17d / 100;
            Console.WriteLine($"The weight of the man on the moon with {weight} on earth is: {weight * (percentGiven)}");
            Console.WriteLine(); 





          // Write an expression that checks for a given point {x, y} if it is within the circle K({0, 0}, R=5). 
         
          Console.WriteLine("-------Question 8-------");
          
          Console.Write("Enter x: ");
          int x = Convert.ToInt32(Console.ReadLine());
          Console.Write("Enter y: ");
          int y = Convert.ToInt32(Console.ReadLine());
          bool isInside = ((x * x) + (y * y) <= 5 * 5) ? true : false;
          Console.WriteLine($"The point O({x},{y}) is inside K((0,0),5)?: {isInside}");


    
         // 9. Write an expression that checks for given point {x, y} if it is within the 
         // circle K({0, 0}, R=5) and out of the rectangle [{-1, 1}, {5, 5}]. 
         // Clarification: for the rectangle the lower left and the upper right corners 
         // are given.


            Console.WriteLine("-------Question 9-------");
             Console.Write("Enter x: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            bool isInsideCircle = (x1 * x1 + y2 * y2 <= 5 * 5) ? true : false;
            bool isOutsideRectangle = (x1 < -1 && x1 > 5 && y2 < 1 && y2 > 5) ? true : false;
            Console.WriteLine($"The point O({x1},{y2}) is inside K((0,0),5)?: {isInsideCircle}");
            Console.WriteLine($"The point O({x1},{y2}) is outside rectangle ((-1, 1), (5, 5)?: {isOutsideRectangle}");



            
            // 10. Write a program that takes as input a four-digit number in format abcd
           // (e.g. 2011) and performs the following actions:
           // - Calculates the sum of the digits (in our example 2+0+1+1 = 4).
           // - Prints on the console the number in reversed order: dcba (in our 
           // example 1102).
           // - Puts the last digit in the first position: dabc (in our example 1201).
           // - Exchanges the second and the third digits: acbd (in our example 
           // 2101).
            Console.WriteLine("-------Question 10-------");

            Console.Write("Enter a four digit number: ");
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            int third = Convert.ToInt32(Console.ReadLine());;
            int fourth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Calculates the sum of the digits: {first + second + third + fourth}");
            Console.WriteLine($"Prints on the console the number in reversed order: {fourth}{third}{second}{first}");
            Console.WriteLine($"Puts the last digit in the first position: {fourth}{first}{second}{third}");
            Console.WriteLine($"Exchanges the second and the third digit: {first}{third}{second}{fourth}");*/



            
            Console.WriteLine("-------Question 10-------");
  

             


        }
    }
}
 