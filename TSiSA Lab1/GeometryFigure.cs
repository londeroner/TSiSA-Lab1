using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSiSA_Lab1
{
    public abstract class GeometryFigure
    {
        public static int allFigures;
        public int countSizes { get; set; }
        public float length { get; set; }
        public float area { get; set; }

        public virtual void setLength(float length) { this.length = length * countSizes; }

        public abstract void getArea();

        public GeometryFigure(int countSizes, float length)
        {
            this.countSizes = countSizes;
            setLength(length);
        }
    }
}
