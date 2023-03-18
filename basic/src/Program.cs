namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Learn about C# Basic
            Console.WriteLine("Hello World!"); // print

            // Learn about C# Variables
            Console.WriteLine("Learn about C# Variables");
            Console.WriteLine("What is your name?"); // print
            string? name = Console.ReadLine(); // read input from user

            // Learn about C# If Else Statement
            Console.WriteLine("Learn about C# If Else Statement");
            Console.WriteLine("What is your age?"); // print
            int? age = Convert.ToInt32(Console.ReadLine()); // read input from user and convert to int

            if (age < 17)
            {
                Console.WriteLine("You are not allowed to vote."); // print
            }
            else
            {
                Console.WriteLine("You are allowed to vote."); // print
            }

            // Learn about C# Switch Statement
            Console.WriteLine("Learn about C# Switch Statement");
            Console.WriteLine("What is your favorite color?"); // print
            string? color = Console.ReadLine(); // read input from user
            switch (color)
            {
                case "red":
                    Console.WriteLine("Red is a nice color."); // print
                    break;
                case "blue":
                    Console.WriteLine("Blue is a wonderful color."); // print
                    break;
                default:
                    Console.WriteLine("Why don't you like red or blue?"); // print
                    break;
            }

            Console.WriteLine("Your favorite color is " + color + "."); // print

            // Get Type
            Console.WriteLine("Get Type");
            Console.WriteLine(age.GetType()); // print

            // Math 
            double x = 3;
            double pow = Math.Pow(x, 2);

            Console.WriteLine("3 to the power of 2 is " + pow + "."); // print

            // Random Number
            Random ran = new Random();
            Console.WriteLine("Random Number");
            Console.WriteLine(ran.Next(1, 10)); // print

            // Hypotenuse of a right triangle
            double a = 0;
            double b = 0;
            double c = 0;

            try
            {
                Console.WriteLine("Enter side A : ");
                a = Convert.ToDouble(Console.ReadLine()); // read input from user and convert to Double
                Console.WriteLine("Enter side B : ");
                b = Convert.ToDouble(Console.ReadLine()); // read input from user and convert to Double

                if (b == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero"); // throw an exception if b is zero
                }

                // divide
                c = a / b;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message); // print
                b = 1; // initialize b to a default value
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message); // print
                c = Double.NaN; // set c to NaN (Not a Number) to indicate that the result is undefined
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); // print
            }
            finally
            {
                Console.WriteLine("Value of a: " + a);
                Console.WriteLine("Value of b: " + b);
                Console.WriteLine("Value of c: " + c);
            }

            // String method
            Console.WriteLine("String method");
            String phoneNumber = "1-234-567-890";

            Console.WriteLine(phoneNumber.Replace("-", "/")); // print
            Console.WriteLine(phoneNumber.Length); // print

            // Array
            Console.WriteLine("Array");

            String[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            Console.WriteLine("For Loop");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]); // print
            }

            // for each
            Console.WriteLine("For Each");
            foreach (var item in cars)
            {
                Console.WriteLine(item); // print
            }

            // Method
            Console.WriteLine("Method");
            MyMethod(); // call method
            Console.WriteLine(Multiply(2, 3)); // print
            Console.WriteLine(Multiply(2.5, 3.5)); // print

            // Params
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine(add(numbers)); // print
        }

        static void MyMethod()
        {
            Console.WriteLine("I just got executed!"); // print
        }

        // Method with parameters
        static int Multiply(int x, int y)
        {
            return x * y;
        }

        // Overloading
        static double Multiply(double x, double y)
        {
            return x * y;
        }

        // Params
        static int add(params int[] numbers)
        {
            int sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }
            return sum;
        }
    }
}