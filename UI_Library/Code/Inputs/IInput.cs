using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Library.Code.Inputs
{
    interface IInput<T>
    {
        void reloadText();
        bool getConvertionStatus();
        T getValue();
    }
}
