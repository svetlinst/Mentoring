using System;
class AstriskRectangle
{
    public static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int hollowAreaSize = size - 2;
        char astrisk = '*';
        char blank = ' ';
        Console.WriteLine(new string(astrisk,size));
        for(int i=0; i<hollowAreaSize; i++)
        {
            Console.WriteLine("{0}{1}{0}",
                                new string(astrisk, 1),
                                new string(blank, hollowAreaSize));
        }
        Console.WriteLine(new string(astrisk, size));

    }
}
