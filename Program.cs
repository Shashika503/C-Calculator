using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            char op;
            double num1, num2;

            Console.WriteLine("Enter the operator : ( +, -, *, /)");
            op = Console.ReadLine()[0];

            Console.WriteLine("Enter the first number :");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Second number :");
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("{0} - {1} = {2}", num1, num2, (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine("{0} * {1} = {2}", num1, num2, (num1 * num2));
                    break;
                case '/':
                    if (num2 == 0.0)
                    {
                        Console.WriteLine("Can not divide a number by 0");
                    }
                    else
                        Console.WriteLine("{0} / {1} = {2}", num1, num2, (num1 / num2));
                    break;

                default:
                    Console.WriteLine("{0} is a invalid oprator", op);
                    break;
            }

            Console.ReadLine();
        }
    }
}
