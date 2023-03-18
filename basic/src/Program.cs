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

            if (age < 17) {
                Console.WriteLine("You are not allowed to vote."); // print
            } else {
                Console.WriteLine("You are allowed to vote."); // print
            }

            // Learn about C# Switch Statement
            Console.WriteLine("Learn about C# Switch Statement");
            Console.WriteLine("What is your favorite color?"); // print
            string? color = Console.ReadLine(); // read input from user
            switch(color) {
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
            Console.WriteLine("Enter side A : ");
            double a = Convert.ToDouble(Console.ReadLine()); // read input from user and convert to Double

            Console.WriteLine("Enter side B : ");
            double b = Convert.ToDouble(Console.ReadLine()); // read input from user and convert to int

            if (a == 0 || b == 0) {
                Console.WriteLine("Please enter a valid number."); // print
            } else {
                double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                Console.WriteLine("The hypotenuse of the right triangle is " + c + "."); // print
            }
        }
    }
}