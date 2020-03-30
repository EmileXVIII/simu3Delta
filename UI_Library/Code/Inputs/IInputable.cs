using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Library.Code.Inputs
{
    public interface IInputable
    {
        string Text { get; }
        System.Drawing.Color BackColor{set;}
    }
}
