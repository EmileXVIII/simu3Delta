﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Library.Code.Inputs
{
    class IntImput:IImput<int>
    {
        private bool check;
        private string text;
        private int textToInt;
        private System.Windows.Forms.TextBox textBox;
        public IntImput(System.Windows.Forms.TextBox textBox)
        {
            this.check = true;
            this.text = "";
            this.textToInt = 0;
            this.textBox = textBox;
        }
        public void reloadText()
        {
            this.text = textBox.Text;
            this.calcFloat();
        }
        private void calcFloat()
        {
            try
            {
                reloadText();
                textToInt = int.Parse(text);
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
        public int getValue()
        {
            this.reloadText();
            return check ? this.textToInt : 0;
        }
    }
}