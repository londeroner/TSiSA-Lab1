using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSiSA_Lab1
{
    class Circle : GeometryFigure
    {
        public float radius;

        public override void setLength(float length)
        {
            this.length = 2 * (float)Math.PI * length;
        }

        public Circle(int length) : base(1, length)
        {
            radius = length;
            setLength(length);
            getArea();
        }

        public override string ToString()
        {
            return $"Circle with side length = {length}, area =  {area}, and radius = {radius}";
        }

        public override void getArea()
        {
            area = 2 * (float)Math.PI * length * length;
        }
    }
}
