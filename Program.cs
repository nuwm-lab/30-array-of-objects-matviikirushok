using LabWork;
using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter the number of points (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0) throw new Exception("Number of points must be positive.");

            // 1. Створення масиву з n об’єктів класу
            Point3D[] points = new Point3D[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEnter coordinates for Point #{i + 1}:");
                Console.Write("X >>> "); double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Y >>> "); double y = Convert.ToDouble(Console.ReadLine());
                Console.Write("Z >>> "); double z = Convert.ToDouble(Console.ReadLine());

                points[i] = new Point3D(x, y, z);
            }

            Console.WriteLine("\n--- Analysis Results ---");
            bool found = false;

            for (int i = 0; i < points.Length; i++)
            {
                // 2. Використання методу класу для перевірки умов
                if (points[i].IsFirstOctantAndInteger())
                {
                    Console.WriteLine($"Point #{i + 1} {points[i]} is in the 1st Octant (all coordinates are positive).");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No points were found in the 1st Octant.");
            }
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Error: {exc.Message}");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}