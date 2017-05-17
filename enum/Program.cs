using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDeam

{
    enum color {
        yellow,brown=10,blue,black,purple
    }

    enum Season {
        spring,summer,autumn,winter
    }
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("yellow={0}",color.yellow);
            //Console.WriteLine("yellow={0}", (int)color.yellow);
            //Console.WriteLine("brown={0}",(int)color.brown);
            //Console.WriteLine("blue={0}", (int)color.blue);
            //Console.WriteLine("black={0}", (int)color.black);
            //Console.WriteLine("purple={0}", (int)color.purple);

            //Console.ReadKey();

            Console.WriteLine("输入一个月份：");
            int yue = Convert.ToInt32(Console.ReadLine());
            switch (yue)
            {
                case 3:
                case 4:
                case 5:
                    Console.WriteLine(Season.spring);
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine(Season.summer);
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine(Season.autumn);
                    break;
                case 12:
                case 1:
                case 2:
                    Console.WriteLine(Season.winter);
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
