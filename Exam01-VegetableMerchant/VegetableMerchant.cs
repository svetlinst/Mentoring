using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class VegetableMerchant
    {
        static void Main()
        {
        double fruitPrice = double.Parse(Console.ReadLine());
        double vegetablePrice = double.Parse(Console.ReadLine());
        int fruitKiloSold = int.Parse(Console.ReadLine());
        int vegetableKiloSold = int.Parse(Console.ReadLine());
        double revenue = ((fruitPrice * fruitKiloSold) + (vegetablePrice * vegetableKiloSold)) / 1.94;
        Console.WriteLine(revenue);
        }
    }

