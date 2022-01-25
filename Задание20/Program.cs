using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание20
{
    internal class Program
    {
        delegate double MyDelegate(double R);
        static void Main(string[] args)
        {
            MyDelegate myDelegate1 = Method1;
            if (myDelegate1 != null)
            {
                double D = myDelegate1(10);
                Console.WriteLine(D);
            }
            MyDelegate myDelegate2 = Method2;
            if (myDelegate2 != null)
            {
                double S = myDelegate2(10);
                Console.WriteLine(S);
            }
            MyDelegate myDelegate3 = Method3;
            if (myDelegate3 != null)
            {
                double V = myDelegate3(10);
                Console.WriteLine(V);
            }
            Console.ReadKey();
        }

            static double Method1(double R)
            {
                Console.WriteLine("Method1");
                return 2 * Math.PI * R;
            }
            static double Method2(double R)
            {
                Console.WriteLine("Method2");
                return Math.PI * R*R;
            }
            static double Method3(double R)
            {
               Console.WriteLine("Method3");
               return 4 * Math.PI * Math.Pow(R, 3) / 3;
            }
    }
}
