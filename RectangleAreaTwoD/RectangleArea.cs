using System;



    class RectangleArea
    {
        public static void Main()
        {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double sideA = Math.Abs(x1 - x2);
        double sideB = Math.Abs(y1 - y2);
        double area = sideA * sideB;
        double perimeter = (sideA * 2) + (sideB * 2);
        Console.WriteLine(area);
        Console.WriteLine(perimeter);

    }
}

