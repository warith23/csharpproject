 using System;

namespace chapTer1
{
    class Program
    {
        static void Main(string[] args)
        {
         //Declare several variables by selecting for each one of them the most 
         // appropriate of the types sbyte, byte, short, ushort, int, uint, long
         // and ulong in order to assign them the following values: 52,130; -115; 
         // 4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000; 
         //  1990; 123456789123456789.
           
           
          Console.WriteLine("____Number 1______");
          ushort number1 = 52130;
          sbyte number2 = -115;
          int number3 = 4825932;
          byte number4 = 97;
          short number5 = -10000;
          uint number6 = 20000;
          byte number7 = 224;
          uint number8 = 970700000;
          byte number9 = 112;
          sbyte number10 = -44;
          long number11 = -1000000;
          short number12 = 1990;
          ulong number13 = 123456789123456789;
           

            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            Console.WriteLine(number4);
            Console.WriteLine(number5);
            Console.WriteLine(number6);
            Console.WriteLine(number7);
            Console.WriteLine(number8);
            Console.WriteLine(number9);
            Console.WriteLine(number10);
            Console.WriteLine(number11);
            Console.WriteLine(number12);
            Console.WriteLine(number13); 
            Console.WriteLine();



           //  2. Which of the following values can be assigned to variables of type float, 
           //  double and decimal: 5, -5.01, 34.567839023; 12.345; 8923.1234857;
           //  3456.091124875956542151256683467?
           
            Console.WriteLine("____Number 2______");
           float numb1 = 8923.1234857f;
           double numb2 = 34.56789023;
           decimal numb3 = 3456.091124875956542151256683467m;
           float numb4 = 12.345f;
            Console.WriteLine(numb1);
            Console.WriteLine(numb2);
            Console.WriteLine(numb3);
            Console.WriteLine(numb4); 
            Console.WriteLine();  

             
           //  3. Write a program, which compares correctly two real numbers with 
           //   accuracy at least 0.000001.
             Console.WriteLine("____Number 3______");
           Console.WriteLine();


            //4. Initialize a variable of type int with a value of 256 in
            // hexadecimal format (256 is 100 in a numeral system with base 16).
           Console.WriteLine("____Number 4______");
           int numbers = 0x100;
           Console.WriteLine(numbers);


           
           // 5. Declare a variable of type char and assign it as a value the character, 
           //  which has Unicode code, 72 (use the Windows calculator in order to find 
           //  hexadecimal representation of 72).       
           Console.WriteLine("____Number 5______");
            char character = '72'; 
           Console.WriteLine(character);
          
           // 6. Declare a variable isMale of type bool and assign a value to it depending 
           // on your gender.

           // Console.WriteLine("____Number 6______")
           // bool isMale = true;

                                     


           //  7. Declare two variables of type string with values "Hello" and "World". 
           //  Declare a variable of type object. Assign the value obtained of 
           //  concatenation of the two string variables (add space if necessary) to this 
           //  variable. Print the variable of type object.

            Console.WriteLine("____Number 7______");
            string word1 = "Hello";
            string word2 = "World";
            object bothWord = word1 + " " + word2;
            Console.WriteLine(bothWord); 
            Console.WriteLine();


            //  8. Declare two variables of type string and give them values "Hello" and 
            //  "World". Assign the value obtained by the concatenation of the two 
            //  variables of type string (do not miss the space in the middle) to a 
            //  variable of type object. Declare a third variable of type string and 
            //  initialize it with the value of the variable of type object (you should use type casting).

            
           
           Console.WriteLine("____Number 8______");
           string word3 = (string)bothWord;
            Console.WriteLine(word3); 
            Console.WriteLine();

           
           // Declare two variables of type string and assign them a value “The 
            // "use" of quotations causes difficulties.” (without the outer quotes). 
            // In one of the variables use quoted string and in the other do not use it.
           
           Console.WriteLine("____Number 9______");
           string word4 = "The \"use\" of quatations causes difficulties";
           string word5 = "\"The \"use\" of quotations causes difficulties\"";
           Console.WriteLine(word4);
            Console.WriteLine(word5); 
            Console.WriteLine();

           
           
            // Write a program to print a figure in the shape of a heart by the sign "o".
            Console.WriteLine("____Number 10______"); 
            Console.WriteLine("    o             o ");
            Console.WriteLine("  o    o        o    o ");
            Console.WriteLine("   o     o    o     o ");
            Console.WriteLine("     o     o      o ");   
            Console.WriteLine("       o        o  ");
            Console.WriteLine("           o       "); 
            Console.WriteLine();

            // Write a program that prints on the console isosceles triangle which 
            // sides consist of the copyright character "©".


            Console.WriteLine("____Number 11______");
            Console.WriteLine("      @");
            Console.WriteLine("    @   @");
            Console.WriteLine("  @       @");  
            Console.WriteLine("  @@@@@@@@@@");
            Console.WriteLine(); 
           
           
           //  12. A company dealing with marketing wants to keep a data record of its 
           //  employees. Each record should have the following characteristic – first 
           //  name, last name, age, gender (‘m’ or ‘f’) and unique employee number 
           //  (27560000 to 27569999). Declare appropriate variables needed to 
           //   maintain the information for an employee by using the appropriate data 
           //  types and attribute names.
           
           Console.WriteLine("____Number 12______");
           string firstName = "A.Warith";
           string lastName = "Ismail";
           int age = 17;
           char gender = 'm';
           int employeeNumber = 001;

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(gender);
            Console.WriteLine(employeeNumber); 
            Console.WriteLine();  
        
          
            
           // 13. Declare two variables of type int. Assign to them values 5 and 10 
           // respectively. Exchange (swap) their values and print them.
           // Solutions and Guidelines
          
           Console.WriteLine("____Number 13______");  
           int a = 5;
           int b = 10; 
           a = b - a;
           b = b - a;
           a = a + b;

          Console.WriteLine(a);
           Console.WriteLine(b);
          Console.WriteLine();






         
        }
    }
}
