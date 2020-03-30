using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Library.Code.Exceptions
{
    class NoApplicationPointException:Exception
    {
        public NoApplicationPointException() : base("No application point") {}
    }
}
