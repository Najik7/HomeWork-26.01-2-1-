using System;

namespace Д.з__2_1_Alif
{
    public class Rectangle
    {
        public double side1;
        public double side2;

        public double Area { get; set; }
        public double Perimeter { get; set; }

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalculator()
        {
            return Area = side1 * side2;
        }

        public double PerimeterCalculator()
        {
            return Perimeter = 2 * (side1 + side2);
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длинну прямоугольника: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите ширину прямоугольника: ");
            double b = double.Parse(Console.ReadLine());

            Rectangle rect = new Rectangle(a, b);
            

            Console.WriteLine($"Площадь прямоугольника = {rect.AreaCalculator()}\n" +
                $"Периметр прямоугольника = {rect.PerimeterCalculator()}");
        }
    }
}
