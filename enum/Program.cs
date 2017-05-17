using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    enum color {
        yellow,brown=10,blue,black,purple
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("yellow={0}",color.yellow);
            Console.WriteLine("yellow={0}", (int)color.yellow);
            Console.WriteLine("brown={0}",(int)color.brown);
            Console.WriteLine("blue={0}", (int)color.blue);
            Console.WriteLine("black={0}", (int)color.black);
            Console.WriteLine("purple={0}", (int)color.purple);

            Console.ReadKey();
        }
    }
}
