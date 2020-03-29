using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSiSA_Lab1
{
    class Triangle : GeometryFigure
    {
        public float side1, side2, side3;

        public override void setLength(float length)
        {
            this.length = side1 + side2 + side3;
        }

        public Triangle(float side1, float side2, float side3) : base(3, 0)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            setLength(0);
            getArea();
        }

        public override string ToString()
        {
            return $"Triangle with side length = {length}, area =  {area}, and sides = {side1} {side2} {side3}";
        }

        public override void getArea()
        {
            float p = (side1 + side2 + side3) / 2;
            area = (float)Math.Sqrt(p*(p-side1)*(p-side2)*(p-side3));
        }
    }
}
