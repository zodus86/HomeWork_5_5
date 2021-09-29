using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5_5
{
    class Exercise5
    {
        /// <summary>
        /// рекурсия
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static int Akkerman(int n, int m)
        {
           // Console.WriteLine("я тут был");

            if (n != 0 && m == 0) 
                return Akkerman(n - 1, 1);

            if (n > 0 && m > 0) 
                return Akkerman(n - 1, Akkerman(n, m - 1));

            if (n == 0)
                return m + 1;

            return Akkerman(n, m);
        }
    }
}
