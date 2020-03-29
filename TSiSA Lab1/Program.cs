using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSiSA_Lab1
{
    class Program
    {
        public static List<GeometryFigure> mainList = new List<GeometryFigure>();

        static void Main(string[] args)
        {
            
            //list.Sort(delegate (Recktangle r1, Recktangle r2) {
            //    return r1.b.CompareTo(r2.b);
            //});
            while (true)
            {
                Run();
            }
        }

        static int showContextMenu(string[] mas)
        {
            int state = 0;
            ConsoleKey key;
            while (true)
            {
                Console.Clear();
                for (int i = 0; i < mas.Length; i++)
                    Console.WriteLine((state == i ? ">" : " ") + mas[i]);

                Console.WriteLine();
                foreach (var item in mainList)
                {
                    if (item is Square) Console.WriteLine((Square)item);
                    else if (item is Circle) Console.WriteLine((Circle)item);
                    else if (item is Triangle) Console.WriteLine((Triangle)item);
                    else if (item is Recktangle) Console.WriteLine((Recktangle)item);
                }

                key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.DownArrow)
                {
                    if (state != mas.Length - 1) state++;
                }
                else if (key == ConsoleKey.UpArrow)
                {
                    if (state != 0) state--;
                }
                else if (key == ConsoleKey.Enter) { return state; }
            }
        }

        static void Run()
        {
            Console.Clear();
            action(showContextMenu(new string[]{ "Create new", "Filter"}));
        }

        static void action(int z)
        {
            switch (z)
            {
                case 0:
                    createElement(showContextMenu(new string[] { "Square", "Circle", "Triangle", "Recktangle" }));
                    break;
                case 1:
                    filter(showContextMenu(new string[] { "Filter by typeof ", "Filter squares", "Filter circles", "Filter triangles", "Filter recktangles" }));
                    break;
            }
        }

        static void createElement(int z)
        {
            switch (z)
            {
                case 0:
                    Console.Clear();
                    Console.Write("Input side length of a square: ");
                    mainList.Add(new Square(int.Parse(Console.ReadLine())));
                    break;
                case 1:
                    Console.Clear();
                    Console.Write("Input radius of a circle: ");
                    mainList.Add(new Circle(int.Parse(Console.ReadLine())));
                    break;
                case 2:
                    Console.Clear();
                    Console.Write("Input 3 sides of a triangle: ");
                    string[] str = Console.ReadLine().Split(' ');
                    mainList.Add(new Triangle(int.Parse(str[0]), int.Parse(str[1]), int.Parse(str[2])));
                    break;
                case 3:
                    Console.Clear();
                    Console.Write("Input 2 sides of a recktangle: ");
                    string[] str2 = Console.ReadLine().Split(' ');
                    mainList.Add(new Recktangle(int.Parse(str2[0]), int.Parse(str2[1])));
                    break;
            }
        }

        static void filter(int z)
        {
            switch (z)
            {
                case 0:
                    mainList.Sort(delegate (GeometryFigure g1, GeometryFigure g2)
                    {
                        return g1.GetType().Name.CompareTo(g2.GetType().Name);
                    });
                    break;
                case 1:
                    mainList.Sort(delegate (GeometryFigure g1, GeometryFigure g2)
                    {
                        if (g1 is Square && g2 is Square)
                            return g1.length.CompareTo(g2.length);
                        else return 1;
                    });
                    break;
                case 2:
                    mainList.Sort(delegate (GeometryFigure g1, GeometryFigure g2)
                    {
                        if (g1 is Circle && g2 is Circle)
                            return g1.length.CompareTo(g2.length);
                        else return 1;
                    });
                    break;
                case 3:
                    mainList.Sort(delegate (GeometryFigure g1, GeometryFigure g2)
                    {
                        if (g1 is Triangle && g2 is Triangle)
                            return g1.length.CompareTo(g2.length);
                        else return 1;
                    });
                    break;
                case 4:
                    mainList.Sort(delegate (GeometryFigure g1, GeometryFigure g2)
                    {
                        if (g1 is Recktangle && g2 is Recktangle)
                            return g1.length.CompareTo(g2.length);
                        else return 1;
                    });
                    break;
            }
        }
    }
}
