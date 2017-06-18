using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    public delegate int BinaryOp(int x, int y);
    class SimpleMath
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Substract(int x, int y)
        {
            return x - y;
        }
    }
}
