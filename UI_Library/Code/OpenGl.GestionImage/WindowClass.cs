using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;

namespace UI_Library.Code.OpenGl.GestionImage
{
    class WindowClass : GameWindow
    {
        public WindowClass(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) {}
    }
}
