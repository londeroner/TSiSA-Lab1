using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSiSA_Lab1
{
    public class Square : GeometryFigure
    {

        public Square(float length) : base(4, length)
        {

        }

        public override void getArea()
        {
            area = (length / 4) * (length / 4);
        }

        public override string ToString()
        {
            return "Square with side length = " + (length/4).ToString();
        }
    }
}
