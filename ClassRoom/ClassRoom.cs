using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main()
        {
        double length = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        length = length * 100;
        width = width * 100;
        width = width - 100;        
        double rowLength = 120;        
        double deskWidth = 70;        
        int rowsNumber = (int)(length / rowLength);
        int desksNumber = (int)(width / deskWidth);            
        int seats = rowsNumber * desksNumber - 3;
        Console.WriteLine(seats);
    }
}

