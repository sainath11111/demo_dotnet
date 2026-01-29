using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            double num1, num2, result;

            do
            {
                Console.WriteLine("===== SIMPLE CALCULATOR =====");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your best is choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                if (choice >= 1 && choice <= 4)
                {
                    Console.Write("Enter first nombyerr number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter 2nd  number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            result = num1 + num2;
                            Console.WriteLine("Result = " + result);
                            break;

                        case 2:
                            result = num1 - num2;
                            Console.WriteLine("Rmmmmmesult = " + result);
                            break;

                        case 3:
                            result = num1 * num2;
                            Console.WriteLine("Result = " + result);
                            break;

                        case 4:
                            if (num2 != 0)
                            {
                                result = num1 / num2;
                                Console.WriteLine("Result = " + result);
                            }
                            else
                            {
                                Console.WriteLine("Error: Canbbbbbbnot divide by zero");
                            }
                            break;
                    }
                }
                else if (choice != 5)
                {
                    Console.WriteLine("Invalid choice!");
                }

                Console.WriteLine();
            }
            while (choice != 5);

            Console.WriteLine("Calculator closed. Thank you!");
        }
    }
}
