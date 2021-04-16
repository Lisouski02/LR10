using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        class Triangle//Класс Треугольник
        {
            int a;
            int b;
            int c;
            int p;


            public int A//Поля класса
            {
                set
                {
                    a = value;
                }

                get
                {
                    return a;
                }
            }
            public int B
            {
                set
                {
                    b = value;
                }

                get
                {
                    return b;
                }
            }
            public int C
            {
                set
                {
                    c = value;
                }
                get
                {
                    return c;
                }
            }

            public Triangle(int a, int b, int c)//Конструктор с параметрами
            {
                this.a = a;
                this.b = b;
                this.c = c;
                this.p = (1 / 2) * (a + b + c);
            }

            public void ShowSides()//Вывод сторон треугольника
            {
                Console.WriteLine("a: " + a + " b: " + " b" + " c: " + c);
            }

            public int Perimetr()//Периметр треугольника
            {
                return a + b + c;
            }

            public double PPerimetr()//Полупериметр
            {
                return Perimetr() / 2.0;
            }

            public double Square()//Площадь треугольника
            {
                return Math.Sqrt(PPerimetr() * (PPerimetr() - a) * (PPerimetr() - b) * (PPerimetr() - c));
            }
            public bool IsTriangle()//Проверка на существование треугольника
            {

                if (a + b > c && a + c > b && b + c > a)
                    return true;
                else
                    return false;

            }
        }


        static void Main()
        {
            Triangle t = new Triangle(5, 5, 6);
            t.ShowSides();
            Console.WriteLine("Периметр : " + t.Perimetr());
            Console.WriteLine("Полупериметр : " + t.PPerimetr());
            Console.WriteLine("Площадь : " + t.Square());
            if (t.IsTriangle() == true)
                Console.WriteLine("Треугольник существует.");
            else
                Console.WriteLine("Треугольник не существует");
        }
    }
}
