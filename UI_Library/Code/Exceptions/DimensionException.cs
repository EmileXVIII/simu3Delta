using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Library.Code.Exceptions
{
    class DimensionException : Exception
    {
        public DimensionException():base("Vector have not the same dimension")
        {
        }

    }
}
