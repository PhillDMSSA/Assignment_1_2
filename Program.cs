namespace Assignment_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assignment 1.2.1
             
            Console.WriteLine("Enter a number: ");
            int input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number: ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Assignment 1.2.1");
            
            if (input1 != input2) 
            {
                Console.WriteLine($"{input1} and {input2} are not equal.");
            }
            else
            {
                Console.WriteLine($"{input1} and {input2} are equal.");
            }
            Console.WriteLine("");

            
            // Assignment 1.2.2

            Console.WriteLine("The sum of the first 10 natural numbers using for loop");

            int j, sum = 0;

            for (j = 1; j <= 10; j++)
            {
                sum += j; // sum = sum + j
                Console.Write("{0}", j);
            
            }
            Console.WriteLine("The sum is : {0}\n", sum);

            // Assignment 1.2.3

            do
            {
                Console.WriteLine("Please select one calculation function you wish to use: \n" +
                    "\t+ = Addition\n" +
                    "\t- = Subtraction\n" +
                    "\t/ = Division\n" +
                    "\t* = Multiplication");
                string functionInput = Console.ReadLine();

                Console.WriteLine("Enter a number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter a number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double addAnswer = num1 + num2;
                double subAnswer = num1 - num2;
                double divAnswer = num1 / num2;
                double mulAnswer = num1 * num2;


                switch (functionInput)
                {

                    case "+":
                        Console.WriteLine($"{num1} + {num2} = {addAnswer}");
                        break;
                    case "-":
                        Console.WriteLine($"{num1} - {num2} = {subAnswer}");
                        break;
                    case "/":
                        Console.WriteLine($"{num1} / {num2} = {divAnswer}");
                        break;
                    case "*":
                        Console.WriteLine($"{num1} * {num2} = {mulAnswer}");
                        break;


                }
                Console.WriteLine("Do you wish to continue or exit? (Y/N):");

            }

            while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine();

            Console.WriteLine("\t\t\t\t\tEnd of code. Thank you!");




        }
    }
}
