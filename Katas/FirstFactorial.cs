using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    public static class FirstFactorial
    {
        public static int Execute(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            return num*Execute(num - 1);
        }
    }
}
