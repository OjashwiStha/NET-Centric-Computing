using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 40, b = 12;
            Console.WriteLine("Before swapping a= " + a + " b= " + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.Write("After swapping a= " + a + " b= " + b);
        }
    }
}
