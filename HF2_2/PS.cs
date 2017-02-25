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

        public static void PrimOsztok(int szam)
        {
            int o = 1;
            int[] osztok = new int[szam];
            bool egyel = false;
            bool massal = false;
            bool prime = false;

            while (szam < szam + 1)
            {
                if (szam % o == 0 && o == 1)
                    egyel = true;
                else
                    massal = true;

                if (massal == false)
                    prime = true;

                o++;

                for (int c = 0; 0 < szam; c++)
                    osztok[c] = o;
            }
        }
    }
}
