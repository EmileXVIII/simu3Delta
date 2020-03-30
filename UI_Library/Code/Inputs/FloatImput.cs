using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Library.Code.Inputs
{
    public class FloatImput : IImput<float>
    {
        private bool check;
        private string text;
        private float textToFloat;
        private System.Windows.Forms.TextBox textBox;
        public FloatImput(System.Windows.Forms.TextBox textBox)
        {
            this.check = true;
            this.text = "";
            this.textToFloat = 0;
            this.textBox = textBox;
        }
        public void reloadText()
        {
            this.text = textBox.Text;
            this.calcFloat();
        }
        private void calcFloat()
        {
            string[] textSplited = this.text.Split('e');
            float pow=0;
            try
            {
                textToFloat = float.Parse(textSplited[0]);
                if (textSplited.Length > 1)
                {
                    textToFloat *= (float)Math.Pow(10, float.Parse(textSplited[1]));
                }
                this.check = true;
                this.textBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                this.textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
                this.check = false;
            }
        }
        public bool getConvertionStatus() { return check; }
        public float getValue()
        {
            this.reloadText();
            return check?this.textToFloat:0;
        }
    }
}
