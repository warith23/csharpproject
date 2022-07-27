using System;

namespace chapTer4
{
    class Program
    {
        static void Main(string[] args)
        {

          Console.WriteLine("-------Question 1-------");
          Console.WriteLine("Enter first nummber");
          int number1 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter second nummber");
          int number2 = Convert.ToInt32(Console.ReadLine());    
          Console.WriteLine("Enter third nummber");
          int number3 = Convert.ToInt32(Console.ReadLine()); 

          int totalNumber = number1 + number2 + number3;
          Console.WriteLine($"The total number is : {totalNumber}");



          Console.WriteLine("-------Question 2-------");
         Console.WriteLine("Enter Radius");
         int radius = int.Parse(Console.ReadLine());

         double area = (Math.PI * (radius*radius));
         Console.WriteLine($"Perimeter of the circle is {area}");

         double perimeter = (2 * Math.PI * radius);
         Console.WriteLine($"Area of cirle is {perimeter}");


         
          Console.WriteLine("-------Question 3-------");
          Console.WriteLine("Enter company name");
          string companyName  = Console.ReadLine();
          Console.WriteLine("Enter company address");
          string companyaddress = Console.ReadLine();
          Console.WriteLine("Enter company phone NO.");
          int companyphone = int.Parse(Console.ReadLine());
          Console.WriteLine("Enter company fax:  ");
          string companyfax  = Console.ReadLine();
          Console.WriteLine("Enter companywebsite: ");
          string companyweb = Console.ReadLine();
          Console.WriteLine("Enter company manager name: ");
          string managerName = Console.ReadLine();
          Console.WriteLine("Enter manager phone number: ");
          string managerNo  = Console.ReadLine();

          Console.WriteLine("-------Question 5-------");
         Console.Write("Enter first no.: ");
         int first = int.Parse(Console.ReadLine());
         Console.Write("Enter second no.: ");
         int second = int.Parse(Console.ReadLine());
         Console.WriteLine("The numbers devisible by 5 without remainder from {0} to {1} are: ",first,second);
         for (int i = first; i <= second; i++)
         
          if (i % 5 == 0)
         {
          Console.WriteLine(i);
         } 
         Console.WriteLine(); 


         Console.WriteLine("-------Question 6-------");
         Console.Write("Enter first no.: ");
         int firstNo = int.Parse(Console.ReadLine());
         Console.Write("Enter second no.: ");
         int secondNo = int.Parse(Console.ReadLine());

         Console.Write("The greater number is: ")
         Console.WriteLine(Math.Max(firstNo, secondNo));




         Console.WriteLine("-------Question 8-------");
        
         Console.Write("Type number 1:");   
          int a = int.Parse(Console.ReadLine());
         Co nsole.Write("Type number 2:");   
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
         
          else if (c > a && c > b && c >  d && c > e)
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



         Console.WriteLine("-------Question 9-------");

          int sum = 0;
    
         Console.Write("Enter numbers count: ");
          int length = int.Parse(Console.ReadLine());
    
         for (int i = 0; i < length; i++)
         {
          Console.Write("Enter {0} number: ", i + 1);
            sum += int.Parse(Console.ReadLine());
         }
    
         Console.WriteLine($"Sum of all numbers is {sum}.");

 

         Console.WriteLine("-------Question 10-------");

          Console.Write("Enter number: ");
         int range = int.Parse(Console.ReadLine());
    
         for (int i = 1; i <= range; i++)
         {
          Console.WriteLine(i);
         }


         Console.WriteLine("-------Question 11-------");
         int firstNum = 0; 
         int secondNum = 1;
         int thirdNum = 0;

         int lengthSeq = 100;
         Console.WriteLine("The first 100 numbers of the fibonnaci sequence are");

         Console.Write("0, 1,");

         for(int i = 2; i < lengthSeq; i++)
         {
           thirdNum = firstNum + secondNum;
          Console.Write(" {0},", thirdN);
          firstNum = secondNum;
          secondNum = thirdNum;
          }
         Console.WriteLine();


          Console.WriteLine("--------12------")
           Console.Write("Enter last number: ");
          int length = Int32.Parse(Console.ReadLine());
          double sum = 1.0;
    
         for (int i = 2; i <= length; i++)
         {
          sum += (1.0 / i);
         }
    
         Console.WriteLine("{0:F3}", sum);



        }
    }
}
 