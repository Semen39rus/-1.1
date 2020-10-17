using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;



namespace isp2._1._2
{
    class Program
    {
        //Высокий
        static void Main(string[] args)

        {
            try
            {
                double r;
                Console.WriteLine("Введите  значение r");
                r = double.Parse(Console.ReadLine());

                Double S1 = (4 * (r * r));
                Console.WriteLine("S1=" + S1);
                Double R = (r * 2);
                Console.WriteLine("R=" + R);
                Double S2 = (4 * (R * R));
                Console.WriteLine("S2=" + S2);
                Double s = (S2 / S1);
                Console.WriteLine("S2>S1 =" + s);
            }
            catch (Exception e)
            {
            Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
      
    }
}
