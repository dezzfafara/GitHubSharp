using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryOp b = new BinaryOp(SimpleMath.Substract);
            Console.WriteLine(b(5, 6));
        }
    }
}
