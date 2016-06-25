using System;
using System.Globalization;

class Program
    {
        static void Main()
        {
        string consoleInput = Console.ReadLine();
        string format = "dd-MM-yyyy";
        DateTime today = DateTime.ParseExact(consoleInput, format, CultureInfo.InvariantCulture);
        today = today.AddDays(999);
        string consoleOutput = today.ToString(format);
        Console.WriteLine(consoleOutput);
        }
    }

