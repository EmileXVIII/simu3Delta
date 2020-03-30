using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Library.Code.Exceptions;

namespace UI_Library.Code.Objects
{
    public class Vector<T>
    {
        public T[] coordinates;
        public T this[int index] { get => coordinates[index]; set { coordinates[index] = value; } }
        public int length { get; }
        public Vector(T[] coordinates)
        {
            this.length = coordinates.Length;
            this.coordinates = new T[coordinates.Length];
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
