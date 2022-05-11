using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedOps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point P1=new Point(10,10);
            Point P2=new Point(20,20);
            Console.WriteLine($"P1+P2: {P1+P2}");

            Console.WriteLine($"P2-P1:{P2-P1}");
            Console.WriteLine($"P1+12: {P1+12}");
            Console.WriteLine($"23+P2: {23 + P2}");
            Console.WriteLine($"p1+=p2:{P1 += P2}");
            Console.WriteLine($"P2-=P1:{P2-=P1}");
            Point P3=new Point(30,30);
            Point p4=new Point(40,40);
            Console.WriteLine($"++P3: {++P3}");
            Console.WriteLine($"--P4:{++p4}");
            Console.WriteLine($"P1==P2: {P1==P2}");
            Console.WriteLine($"P3==P4:{P3!=p4}");
        }
    }
}
