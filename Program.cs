using System;
namespace Program
{
    class Calculator
    {
        static void Main(String[] args)
        {
            int a, b, menu, result;
            Console.WriteLine("Enter the action to be performed");
            pilihan();
            menu = Convert.ToInt32(Console.ReadLine());


            switch (menu)
            {
                case 1:
                    Console.WriteLine("Enter 1st input");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter 2st input");
                    b = Convert.ToInt32(Console.ReadLine());
                    result = a + b;
                    Console.WriteLine($"The result is {result}");
                    break;

                case 2:
                    Console.WriteLine("Enter 1st input");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter 2st input");
                    b = Convert.ToInt32(Console.ReadLine());
                    result = a - b;
                    Console.WriteLine($"The result is {result}");
                    break;

                case 3:
                    Console.WriteLine("Enter 1st input");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter 2st input");
                    b = Convert.ToInt32(Console.ReadLine());
                    result = a * b;
                    Console.WriteLine($"The result is {result}");
                    break;

                case 4:
                    Console.WriteLine("Enter 1st input");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter 2st input");
                    b = Convert.ToInt32(Console.ReadLine());
                    result = a / b;
                    Console.WriteLine($"The result is {result}");
                    break;
                default:
                    Console.WriteLine("Input is not valid");
                    break;
            }
            void pilihan()
            {
                Console.WriteLine("Press 1 for Addiction");
                Console.WriteLine("Press 2 for Substraction");
                Console.WriteLine("Press 3 for Multiplication");
                Console.WriteLine("Press 4 for Division\n");
            }
        }
    }
}
