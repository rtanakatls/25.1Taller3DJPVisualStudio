using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DJP251.Week2
{
    internal class Shape
    {
        protected string name;

        public Shape(string name)
        {
            this.name = name;
        }

        public virtual float GetArea()
        {
            return 0;
        }

        public virtual string GetData()
        {
            return $"Nombre: {name}";
        }

    }
}
