using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Please input 2 numbers to multiply");
           string input1 = Console.ReadLine();
           string input2 = Console.ReadLine();
            if(Int32.TryParse(input1, out int num1) && Int32.TryParse(input2, out int num2)) { 
            Console.WriteLine(Add(num1, num2));
            } 
            else
            {
                Console.WriteLine("One of your inputs is not a number!");
            }

            Console.Read();
            
           
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }
      

    }
}

