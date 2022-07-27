using System;

namespace chapTer4
{
    class Program
    {
        static void Main(string[] args)
        {
           // Write an if- statement that takes two integer variables and exchanges their values if the first one is greater than the second one.
            Console.WriteLine("--------Number 1-------");          
           Console.Write("Enter first number: ");
           int first = int.Parse(Console.ReadLine());
           Console.Write("Enter second number: ");
           int second = int.Parse(Console.ReadLine());    

           if (first > second)
            {
             first = first + second;
             second = first - second;
             first = first - second;
            }
      
           Console.WriteLine($"First number: {first}, Second number :{second}.");
          


           Console.WriteLine("--------Number 2-------");
           Console.Write("Enter first number: ");
           int num1 = Int32.Parse(Console.ReadLine());
           Console.Write("Enter second number: ");
           int num2 = Int32.Parse(Console.ReadLine());
           Console.Write("Enter third number: ");
           int num3 = Int32.Parse(Console.ReadLine());

           if (num1 < 0 && num2 < 0 && num3 < 0) Console.WriteLine("-");
           else if (num1 >= 0 && num2 >= 0 && num3 >= 0) Console.WriteLine("+");
           else if (num1 < 0 && num2 < 0 && num3 >= 0) Console.WriteLine("+");
           else if (num1 < 0 && num2 >= 0 && num3 < 0) Console.WriteLine("+");
           else if (num1 >= 0 && num2 < 0 && num3 < 0) Console.WriteLine("+");
           else if (num1 < 0 && num2 >= 0 && num3 >= 0) Console.WriteLine("-");
           else if (num1 >= 0 && num2 < 0 && num3 >= 0) Console.WriteLine("-");
           else if (num1 >= 0 && num2 >= 0 && num3 < 0) Console.WriteLine("-");


           Console.WriteLine("--------Number 3-------");
            Console.Write("Enter first number: ");
            int number1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int number2 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int number3 = Int32.Parse(Console.ReadLine());

            if (number1 > number2 && number1 > number3 )
           Console.WriteLine("A is the biggest");
           else if (number1 < number3) 
           Console.WriteLine("C is the biggest");
            else if (number1 < number2)
             if (number1> number3)
              Console.WriteLine("B is the biggest");
                else if (number2 < number3)
                 Console.WriteLine("C is the biggest");
               Console.WriteLine("B and C are the biggest");
              else if (number1 == number2)
                if (number1 == number3) 
                Console.WriteLine("All are equal");
                else if (number1 < number3) Console.WriteLine("C is the biggest");
                else Console.WriteLine("A and B are the biggest");
         

           Console.WriteLine("--------Number 4-------");
           Console.Write("Enter first number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = Int32.Parse(Console.ReadLine());

            if (a < b)
            {
                if (a < c)
                {
                    a = a + c;
                    c = a - c;
                    a = a - c;

                    if (b > c)
                    {                        
                        a = a + b;
                        b = a - b;
                        a = a - b;
                    }
                }
                else if (a >= c)
                {
                    a = a + b;
                    b = a - b;
                    a = a - b;
                }
            }
            else if (a == b)
            {
                if (a < c)
                {
                    a = a + c;
                    c = a - c;
                    a = a - c;
                }
            }
            else
            {
                if (b < c)
                {
                    b = b + c;
                    c = b - c;
                    b = b - c;
                }
                if (a < b)
                {
                    a = a + b;
                    b = a - b;
                    a = a - b;
                }
            }
            Console.WriteLine("{0}, {1}, {2}", a, b, c);
            Console.ReadLine();


          
          
          
          
          
           Console.WriteLine("--------Number 5-------");

           Console.Write("Enter first number: ");
           int number = Int32.Parse(Console.ReadLine());

           switch (number)
           {
           case 0: Console.WriteLine("Nula"); break;
           case 1: Console.WriteLine("Edno"); break;
           case 2: Console.WriteLine("Dve"); break;
           case 3: Console.WriteLine("Tri"); break;
           case 4: Console.WriteLine("Chetiri"); break;
           case 5: Console.WriteLine("Pet"); break;
           case 6: Console.WriteLine("Shest"); break;
           case 7: Console.WriteLine("Sedem"); break;
           case 8: Console.WriteLine("Osem"); break;
           case 9: Console.WriteLine("Devet"); break;
           default: Console.WriteLine("Wrong input"); break;
           }
         
         
         
         
           Console.WriteLine("--------Number 6-------");
           Console.Write("Input A (not 0): ");
           sbyte a1 = Convert.ToSByte(Console.ReadLine());
           Console.Write("Input B: ");
           sbyte b2 = Convert.ToSByte(Console.ReadLine());
           Console.Write("Input C: ");
           sbyte c3 = Convert.ToSByte(Console.ReadLine());

           sbyte d4 = (sbyte)(b2 * b2 - 4 * a1 * c3);
           if (d < 0)
           Console.WriteLine("\nD={0}\nThere are no real roots.", d);
           else if (d4 == 0)
           {
           sbyte x1 = (sbyte)(-b3 / 2 * a1);
           Console.WriteLine("\nX={0}", x1);
           }
           else
           {
           sbyte x1 = (sbyte)((-b2 + Math.Sqrt(d4)) / (2 * a1));
           sbyte x2 = (sbyte)((-b2 - Math.Sqrt(d4)) / (2 * a1));
           }
           Console.WriteLine("\nX1={0}\nX2={1}", x1, x2);
        
        
        
        
        
           Console.WriteLine("--------Number 7-------");

           Console.Write("Type number 1:");   
           int a = int.Parse(Console.ReadLine());
           Console.Write("Type number 2:");   
           int b = int.Parse(Console.ReadLine());
           Console.Write("Type number 3:");    
            int c = int.Parse(Console.ReadLine());
           Console.Write("Type number 4:");    
           int d = int.Parse(Console.ReadLine());
           Console.Write("Type number 5:");    
           int e = int.Parse(Console.ReadLine());
   
         
           int max;
            if (a > b && a > c && a > d && a > e)
           {
           max = a;
           Console.WriteLine("The biggest number from {0} , {1} , {2} , {3} and {4} is {5}.", a, b, c, d, e, max);
           }
           else if (b > a && b > c && b > d && b > e)
           {
           max = b;
           Console.WriteLine("The biggest number from {0} , {1} , {2} , {3} and {4} is {5}.", a, b, c, d, e, max);
           }
         
           else if (c > a && c > b && c > d && c > e)
           {
           max = c;
           Console.WriteLine("The biggest number from {0} , {1} , {2} , {3} and {4} is {5}.", a, b, c, d, e, max);
           }
         
           else if (d > a && d > b && d > c && d > e)
           {
            max = d;
            Console.WriteLine("The biggest number from {0} , {1} , {2} , {3} and {4} is {5}.", a, b, c, d, e, max);
           }
         
           else if (e > a && e > b && e > c && e > d)
           {
           max = e;
            Console.WriteLine("The biggest number from {0} , {1} , {2} , {3} and {4} is {5}.", a, b, c, d, e, max);
           }

           Console.WriteLine();

         
         
         
           Console.WriteLine("--------Number 8-------");

           Console.Write("Enter variable type (0 - int, 1 - double, 2 string): ");
           int intVar = Int32.Parse(Console.ReadLine());

           switch (intVar)
           {
             case 0:
             {
               Console.Write("Enter int variable: ");
               intVar = Int32.Parse(Console.ReadLine());
               intVar++;
               Console.WriteLine("Int variable +1 = {0}", intVar);
                break;
             }
           case 1:
             {
               Console.Write("Enter double variable: ");
               double doubleVar = double.Parse(Console.ReadLine());
               doubleVar++;
               Console.WriteLine("Double variable +1 = {0}", doubleVar);
               break;
             }
           case 2:
             {
             Console.Write("Enter string variable: ");
             string stringVar = Console.ReadLine();
             stringVar = stringVar + '*';
             Console.WriteLine("String variable +* = {0}", stringVar);
             break;
             }
           }
           default: Console.WriteLine("Wrong input"); break;
         
         
          
          
          
          
           Console.WriteLine("--------Number 11-------");
           Console.Write("Enter a number between 0 and 999: ");
            short number = Convert.ToInt16(Console.ReadLine());

            byte hundreds = (byte)(number / 100 | 0);
            byte tensAndOnes;

            if (number > 99) tensAndOnes = (byte)(number % 100);
            else tensAndOnes = (byte)(number * 1);

            byte ones = (byte)(number % 10);

            switch (hundreds)
            {
                case 1: Console.Write("One hundred "); break;
                case 2: Console.Write("Two hundred "); break;
                case 3: Console.Write("Three hundred "); break;
                case 4: Console.Write("Four hundred "); break;
                case 5: Console.Write("Five hundred "); break;
                case 6: Console.Write("Six hundred "); break;
                case 7: Console.Write("Seven hundred "); break;
                case 8: Console.Write("Eight hundred "); break;
                case 9: Console.Write("Nine hundred "); break;
            }

            if (hundreds >= 1 && tensAndOnes >= 1) Console.Write("and ");

            if (tensAndOnes >= 20 && tensAndOnes < 30) Console.Write("Twenty");
            else if (tensAndOnes >= 30 && tensAndOnes < 40) Console.Write("Thirty");
            else if (tensAndOnes >= 40 && tensAndOnes < 50) Console.Write("Fourty");
            else if (tensAndOnes >= 50 && tensAndOnes < 60) Console.Write("Fifty");
            else if (tensAndOnes >= 60 && tensAndOnes < 70) Console.Write("Sixty");
            else if (tensAndOnes >= 70 && tensAndOnes < 80) Console.Write("Seventy");
            else if (tensAndOnes >= 80 && tensAndOnes < 90) Console.Write("Eighty");
            else if (tensAndOnes >= 90 && tensAndOnes < 100) Console.Write("Ninety");

            switch(tensAndOnes)
            {
                case 1: Console.Write("One"); break;
                case 2: Console.Write("Two"); break;
                case 3: Console.Write("Three"); break;
                case 4: Console.Write("Four"); break;
                case 5: Console.Write("Five"); break;
                case 6: Console.Write("Six"); break;
                case 7: Console.Write("Seven"); break;
                case 8: Console.Write("Eight"); break;
                case 9: Console.Write("Nine"); break;
                case 10: Console.Write("Ten"); break;
                case 11: Console.Write("Eleven"); break;
                case 12: Console.Write("Twelve"); break;
                case 13: Console.Write("Thirteen"); break;
                case 14: Console.Write("Fourteen"); break;
                case 15: Console.Write("Fifteen"); break;
                case 16: Console.Write("Sixteen"); break;
                case 17: Console.Write("Seventeen"); break;
                case 18: Console.Write("Eighteen"); break;
                case 19: Console.Write("Nineteen"); break;                
            }
            if (tensAndOnes > 20)
            {
              switch (ones)
             {
               case 1: Console.Write("-one"); break;
               case 2: Console.Write("-two"); break;
               case 3: Console.Write("-three"); break;
               case 4: Console.Write("-four"); break;
               case 5: Console.Write("-five"); break;
               case 6: Console.Write("-six"); break;
               case 7: Console.Write("-seven"); break;
               case 8: Console.Write("-eight"); break;
               case 9: Console.Write("-nine"); break;
             }
            }
	         if (number == 0) Console.Write("Zero");
           Console.ReadLine();
        
        }
    }
}
