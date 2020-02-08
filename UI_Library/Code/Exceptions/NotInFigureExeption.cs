using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Library.Code.Exceptions
{
    class NotInFigureExeption:Exception
    {
        public NotInFigureExeption():base("Try to use point from ouside the figure")
        {
        }
    }
}
