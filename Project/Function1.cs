using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    static class Function1
    {
        public static void main()
        {
            int a = 5;
            a = a.gg();
            a.Print();
        }
        static int gg(this int x)
        {
            return x+5;
        }


    }
}
