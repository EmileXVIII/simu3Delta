using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Library.Code.Exceptions;

namespace UI_Library.Code.CrashObject.Properties
{
    class Vector<T>
    {
        public T[] coordinates { get; }
        public T this[int index] { get => coordinates[index]; set => coordinates[index] = value; }
        public int length { get; }
        public Vector(T[] coordinates)
        {
            this.length = coordinates.Length;
            for (int i = 0; i < this.length; i++)
            {
                this[i] = coordinates[i];
            }
        }
        public Vector<T> Clone()
        {
            T[] deepCopy = new T[this.length];
            for (int i = 0; i < this.length; i++)
            {
                deepCopy[i] = this[i];
            }
            return new Vector<T>(deepCopy);
        }
    }
}
C:\emile.dir\perso\Ynov\projets\Simu3DeltaC#\UI_Library\Code\Objects\Twist.cs