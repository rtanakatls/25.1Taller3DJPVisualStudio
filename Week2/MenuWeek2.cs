using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DJP251.Week2
{
    internal class MenuWeek2 : Menu
    {
        private List<Shape> shapes;

        public MenuWeek2()
        {
            shapes = new List<Shape>();
        }

        public override void Execute()
        {
            shapes.Add(GetCircle());
            shapes.Add(GetRectangle());

            foreach(Shape shape in shapes)
            {
                Console.WriteLine(shape.GetData());
                Console.WriteLine(shape.GetArea());
            }
        }

        private Circle GetCircle()
        {
            string name;
            float radius;
            Circle circle;

            Console.WriteLine("Introduce el nombre");
            name = Console.ReadLine();
            Console.WriteLine("Introduce el radio");
            radius=float.Parse(Console.ReadLine());
            circle = new Circle(name,radius);

            return circle;

        }

        private Rectangle GetRectangle()
        {
            string name;
            float b;
            float h;
            Rectangle r;

            Console.WriteLine("Introduce el nombre");
            name = Console.ReadLine();
            Console.WriteLine("Introduce la base");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la altura");
            h = float.Parse(Console.ReadLine());
            r = new Rectangle(name, b, h);

            return r;

        }
    }
}
