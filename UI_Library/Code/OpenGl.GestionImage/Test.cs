using OpenTK.Graphics.ES20;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Library.Code.OpenGl.GestionImage
{
    class Test
    {
        public Test()
        {
            WindowClass game = new WindowClass(800, 600, "LearnOpenTK");
            game.Run();
            GL.Clear(ClearBufferMask.ColorBufferBit);
            float[] vertices = {
                -0.5f, -0.5f, 0.0f, //Bottom-left vertex
                 0.5f, -0.5f, 0.0f, //Bottom-right vertex
                 0.0f,  0.5f, 0.0f  //Top vertex
            };
            int VertexBufferHandle;
            VertexBufferHandle = GL.GenBuffer();

        }
    }
}
