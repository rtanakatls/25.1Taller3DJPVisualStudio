using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DJP251.Week2
{
    internal class Rectangle : Shape
    {
        protected float b;
        protected float h;

        public Rectangle(string name, float b, float h) : base(name)
        {
            this.b = b;
            this.h = h;
        }

        public override float GetArea()
        {
            return b * h;
        }

        public override string GetData()
        {
            return $"{base.GetData()} - Base: {b} - Altura: {h} ";
        }
    }
}
