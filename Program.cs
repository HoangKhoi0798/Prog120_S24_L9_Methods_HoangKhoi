using System;
namespace Prog120_S24_L9_Methods
{
    class Program
    {
        // Hoang Khoi Gia Nguyen
        // CSI 120 - Computer Programming 1
        // Lecture 9
        static void Main(string[] args)
        {
            // Move stuffs in Main to separated Methods

            // !! Code for the Lecture.
            // You will need to deconstruct this.
           
            

            // To CALL a method, call (type the name) inside of another method (remember the parentheses)
            Menu();

        } // Main


        // 1. What is a method
        // A method is a block of code, given an identifying name that is used to call it

        // 2. What is a method signature
        // A method signature defines the name and parameter to the running application
        // Method Signature: Name and Parameters
        // Access Modifier - Static Keyword - Return Type - Name - Parameters
        // Method name should be Uppercase in C#

        // 3. What is a call stack

        // 4. What is the scope of variables inside of the method
        // Inside of enclosing method code block

        // 5. Where can you declare a method
        // Inside of Class, outside of Method

        // 6. Why do we use methods?
        // To organize codes into functionality
        // Reusability

        // 7. What is a return type?
        // Tells the computer what type is to be returned out of the Method

        // 8. What does void mean?
        // Void means nothing is being returned from the Method

        // 9. How do you CALL a method?
        // You need to use the NAME of your method followed by PARANTHESES


        // You cannot declare one method inside another method

        // Method 1
        #region Menu
        static public void Menu()
        {


            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Print from one number to another using loops");
                Console.WriteLine("2. Perform an algebra level equation");
                Console.WriteLine("3. Work with an array of names");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option (1-4): ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    // Possible Method - Loop through numbers
                    PrintNumbers();
                    // End loop through numbers
                }
                else if (choice == "2")
                {
                    // Algebra Menu
                    PerformAlgebra();
                }
                else if (choice == "3")
                {
                    // Loop through names
                    NameListing();
                    // End of names loop
                }
                else if (choice == "4")
                {
                    exit = true;
                    Console.WriteLine("Exiting the program.");
                }
                else
                {
                    Console.WriteLine("Invalid option. Please choose again.");
                }

                Console.WriteLine(); // Blank line for readability

            }

        }// Menu
        #endregion

        #region Content

        // Create new method called PrintNumbers()
        // How to declare
        #region Numbers
        public static void PrintNumbers()
        {

            Console.Write("Enter the starting number: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter the ending number: ");
            int end = int.Parse(Console.ReadLine());

            // When you pass in Values to a method, they are called arguments
            // They have to be the right type in the right order
            // (int, int)
            LoopNumbers(start, end);
            

        }// Print Numbers End

        // New Method - Loop through Numbers

        // Parameters
        // allow to have arguments in Method
        public static void LoopNumbers(int start, int end)
        {
            if (start <= end)
            {
                for (int i = start; i <= end; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = start; i >= end; i--)
                {
                    Console.WriteLine(i);
                }
            }
        }
        #endregion
        #region Equations
        // Write equation methods

        // For return Type, we replace Void with type we expect to come out
        // We are adding 2 double, so we replace void with double
        public static double Add(double number1, double number2)
        {
            double sum = number1 + number2;

            // To return something, use keyword "return"
            return sum;
        }

        // Subtract
        public static double Subtract(double number1, double number2)
        {
            return number1 - number2;
        }

        // Multiply
        public static double Multiply(double number1, double number2)
        {
            return number1 * number2;

        }
        // Divide
        public static double Divide(double number1, double number2)
        {
            return number1 / number2;

        }

        public static void SolveEquation1()
        {
            Console.Write("Enter the value for x: ");
            double x = double.Parse(Console.ReadLine());

            // PEMDAS
            // Parantheses - Exponent
            // Multiply - Division
            // Add - Subtraction

            double step1 = Multiply(2, x);
            
            // y = 2 * x + 3

            double y = step1 + 3;
            Console.WriteLine($"The result of 2 * {x} + 3 is {y}");
        }// Equation 1 end

        public static void SolveEquation2()
        {
            Console.Write("Enter the value for a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the value for b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter the value for x: ");
            double x = double.Parse(Console.ReadLine());

            // a * x * x + b * x
            double step1 = Multiply(a, x);
            double step2 = Multiply(step1, x);
            double step3 = Multiply(b, x);

            // y = step2 + step3
            double y = Add(step2, step3);
            Console.WriteLine($"The result of {a} * {x}^2 + {b} * {x} is {y}");
        }// Equation 2 end



        public static void SolveEquation3()
        {
            Console.Write("Enter the value for a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the value for b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter the value for c: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Enter the value for x: ");
            double x = double.Parse(Console.ReadLine());

            // a * (x - b) * (x + c)

            double step1 = Subtract(x, b);
            double step2 = Add(x, c);
            double step3 = Multiply(a, step1);
            

            double y = Multiply(step3, step2);
            Console.WriteLine($"The result of {a} * ({x} - {b}) * ({x} + {c}) is {y}");
        }// Equation 3 end
        #endregion
        // Perform algebra
        public static void PerformAlgebra()
        {
            // Algebra Menu
            Console.WriteLine("Choose an equation to solve:");
            Console.WriteLine("1. y = 2x + 3");
            Console.WriteLine("2. y = ax^2 + bx + c");
            Console.WriteLine("3. y = a(x - b)(x + c)");
            Console.Write("Choose an equation (1-3): ");
            string equationChoice = Console.ReadLine();

            if (equationChoice == "1")
            {
                // Equation 1
                SolveEquation1();
                // End of Equation 1
            }
            else if (equationChoice == "2")
            {
                // Equation 2
                SolveEquation2();

                // End of Equation 2
            }
            else if (equationChoice == "3")
            {
                // Equation 3
                SolveEquation3();

                // End of Equation 3
            }
            else
            {
                Console.WriteLine("Invalid option. Returning to main menu.");
            }
            // Algebra End
        }

        // Work with names
        public static void NameListing()
        {
            string[] names = new string[5];
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Enter name {i + 1}: ");
                names[i] = Console.ReadLine();
            }

            Console.WriteLine("You entered the following names:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
        #endregion

    } // class

} // namespace
