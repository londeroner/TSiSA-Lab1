using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSiSA_Lab1
{
    class Recktangle : Square
    {
        float length2;
        public Recktangle(float length, float length2) : base(length)
        {
            this.length2 = length2;
        }

        public override void getArea()
        {
            area = (length / 4) * length2;
        }

        public override string ToString()
        {
            return "Recktangle with sides length = " + (length / 4).ToString() + $"and {length2}";
        }
    }
}
