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
        spring,summer,autumn=10,winter
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

            Console.WriteLine("输入一个数字：");
            int yue = Convert.ToInt32(Console.ReadLine());

            Season se = (Season)yue;
            switch (se)
            {
                case Season.spring:
                    Console.WriteLine("春天");
                    break;
                case Season.summer:
                    Console.WriteLine("夏天");
                    break;
                case Season.autumn:
                    Console.WriteLine("秋天");
                    break;
                case Season.winter:
                    Console.WriteLine("冬天");
                    break;
                   
                default:
                    Console.WriteLine("萨比");
                    break;
            }

            Console.ReadLine();
        }
    }
}
