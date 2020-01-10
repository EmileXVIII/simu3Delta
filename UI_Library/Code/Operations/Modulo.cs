using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Library.Code.Operations
{
    class Modulo
    {
        public static int posModulo(int nb, int mod)
        {
            if (nb < 0) { nb += (nb / mod + 1) * mod; }
            return nb % mod;
        }
    }
}
