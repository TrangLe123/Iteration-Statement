using System;

namespace Iteration_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any integer value from 1 to 100: ");

            try
            {
                string input = Console.ReadLine();
                int input_value = int.Parse(input);

                if ((input_value > 0) && (input_value <= 100))
                {
                    Console.WriteLine("Executing a For Loop!");
                    Console.WriteLine("The loop will iterate: " + input_value.ToString() + " times.");
                    for (int i = 1; i <= input_value; i++)
                    {
                        Console.WriteLine("The value of the variable i in this iteration is: " + i.ToString());
                    }
                    Console.WriteLine("Press any key to exit the program . . .");
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("Please enter any integer value between 1 and 100 and try again . . .");
                    Console.WriteLine("Press any key to exit the program and try again ...");
                    Console.ReadKey(true);
                }
            }
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again ...");
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true); 
            }
        }
    }
}
