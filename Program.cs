using System;

namespace PythagorasCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Pythagorean Theorem Calculator ===");
            Console.WriteLine("Formula: a² + b² = c²\n");

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Calculate hypotenuse (c) from sides a and b");
                Console.WriteLine("2. Calculate side (a) from b and c");
                Console.WriteLine("3. Calculate side (b) from a and c");
                Console.WriteLine("4. Exit");
                Console.Write("\nEnter your choice (1-4): ");

                string choice = Console.ReadLine();

                if (choice == "4")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                try
                {
                    switch (choice)
                    {
                        case "1":
                            CalculateHypotenuse();
                            break;
                        case "2":
                            CalculateSideA();
                            break;
                        case "3":
                            CalculateSideB();
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.\n");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}\n");
                }
            }
        }

        static void CalculateHypotenuse()
        {
            Console.Write("Enter side a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter side b: ");
            double b = double.Parse(Console.ReadLine());

            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("Sides must be positive numbers.\n");
                return;
            }

            double c = Math.Sqrt(a * a + b * b);
            Console.WriteLine($"\nResult: c = {c:F2}");
            Console.WriteLine($"Calculation: √({a}² + {b}²) = √({a * a} + {b * b}) = {c:F2}\n");
        }

        static void CalculateSideA()
        {
            Console.Write("Enter side b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter hypotenuse c: ");
            double c = double.Parse(Console.ReadLine());

            if (b <= 0 || c <= 0)
            {
                Console.WriteLine("Values must be positive numbers.\n");
                return;
            }

            if (c <= b)
            {
                Console.WriteLine("Hypotenuse must be larger than side b.\n");
                return;
            }

            double a = Math.Sqrt(c * c - b * b);
            Console.WriteLine($"\nResult: a = {a:F2}");
            Console.WriteLine($"Calculation: √({c}² - {b}²) = √({c * c} - {b * b}) = {a:F2}\n");
        }

        static void CalculateSideB()
        {
            Console.Write("Enter side a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter hypotenuse c: ");
            double c = double.Parse(Console.ReadLine());

            if (a <= 0 || c <= 0)
            {
                Console.WriteLine("Values must be positive numbers.\n");
                return;
            }

            if (c <= a)
            {
                Console.WriteLine("Hypotenuse must be larger than side a.\n");
                return;
            }

            double b = Math.Sqrt(c * c - a * a);
            Console.WriteLine($"\nResult: b = {b:F2}");
            Console.WriteLine($"Calculation: √({c}² - {a}²) = √({c * c} - {a * a}) = {b:F2}\n");
        }
    }
}
