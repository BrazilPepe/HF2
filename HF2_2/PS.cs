using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF2_2
{
    class PS
    {
        public static bool Prime(int x)
        {
            int i = 2;
            while (i <= Math.Sqrt(x) && x % i != 0)
            {
                i++;
            }
            return i > Math.Sqrt(x);
        }
    }
}
