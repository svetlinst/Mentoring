using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleAst
{
    class Program
    {
        static void Main(string[] args)
        {
            char astrisk = '*';
            char space = ' ';
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}", new string(astrisk,size));
            
            for (int i = 0; i < size -2; i++)
            {
                Console.WriteLine("{0}{1}{0}",
                                new string(astrisk, 1),
                                new string(space, size - 2));                                ;                
            }
            
            Console.WriteLine("{0}", new string(astrisk,size));
        }
    }
}
