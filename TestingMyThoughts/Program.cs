using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace TestingMyThoughts
{

    
    

    class Program
    {
        static void Main(string[] args)
        {
            var f1 = new Q24_8(8);
            var f2 = new Q24_8(10);
            var f3 = Q24_8.Add(f1, f2);
            Console.WriteLine(f3);
            f3 = Q24_8.Subtract(f3, f1);
            Console.WriteLine(f3);
            f3 = Q24_8.Multiply(f3, f1);
            Console.WriteLine(f3);
            f1 = new Q24_8(9);
            f3 = Q24_8.Divide(f3, f1);
            Console.WriteLine(f3);
            f3 = Q24_8.Subtract(f1, f2);
            Console.WriteLine(f3);
            f1 = new Q24_8(248);
            f2 = new Q24_8(10);
            f3 = Q24_8.Divide(f1, f2);
            Console.WriteLine(f3);
            f3 = Q24_8.Multiply(f2,f3);
            Console.WriteLine(f3);
            Console.WriteLine("Q16_16:");
            Q16_16 q1616a = new Q16_16(8);
            Q16_16 q1616b = new Q16_16(10);
            Q16_16 q1616c = new Q16_16(0);
            q1616c = Q16_16.Add(q1616a, q1616b);
            Console.WriteLine(q1616c);
            q1616c = Q16_16.Subtract(q1616a, q1616b);
            Console.WriteLine(q1616c);
            q1616c = Q16_16.Multiply(q1616a, q1616b);
            Console.WriteLine(q1616c);
            q1616a = new Q16_16(9);
            q1616c = Q16_16.Divide(q1616a, q1616b);
            Console.WriteLine(q1616c);
            q1616c = Q16_16.Subtract(q1616a, q1616b);
            Console.WriteLine(q1616c);
            q1616c = new Q16_16(3);
            Console.WriteLine(q1616c);
            q1616a = new Q16_16(3);
            q1616b = new Q16_16(2);
            q1616c = Q16_16.Add(q1616a, q1616b);
            Console.WriteLine(q1616c);
            q1616c = Q16_16.Multiply(q1616a, q1616b);
            Console.WriteLine(q1616c);

            q1616a = new Q16_16(248);
            q1616b = new Q16_16(10);
            q1616c = Q16_16.Divide(q1616a, q1616b);
            Console.WriteLine(q1616c);
            q1616a = new Q16_16(19);
            q1616b = new Q16_16(13);
            q1616c = Q16_16.Multiply(q1616a, q1616b);
            Console.WriteLine(q1616c);
            q1616a = new Q16_16(625);
            q1616b = new Q16_16(1000);
            q1616c = Q16_16.Divide(q1616a, q1616b);
            q1616a = new Q16_16(42);
            q1616b = new Q16_16(100);
            q1616c = Q16_16.Divide(q1616a, q1616b);
            q1616c = Q16_16.Subtract(q1616a, q1616c);
            Console.WriteLine(q1616c);


        }
    }
}
