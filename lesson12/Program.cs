using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода:
            //метод, определяющий длину окружности по заданному радиусу;
            //метод, определяющий площадь круга по заданному радиусу;
            //метод, проверяющий принадлежность точки с координатами(x, y) кругу с радиусом r и координатами центра x0, y0.

            Console.WriteLine("Введите радиус круга с координатами центра 0, 0");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки Х, Y");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Circle circle = new Circle(radius,x,y);
            circle.LenthCircle();
            circle.SquareCircle();
            circle.MemberCircle();
            Console.ReadKey();
        }
    }
    class Circle
    {
        public double radius;
        public double coordinateX;
        public double coordinateY;
        public double Radius
        {
            set
            {
                if (value>=0)
                {
                    radius = value;
                }
                else
                {
                    Console.WriteLine("Радиус должен быть больше нуля");
                }
            }
            get
            {
                return radius;
            }
        }

        public Circle (double radius, double coordinateX=0, double coordinateY=0)
        {
            Radius = radius;
            this.coordinateX= coordinateX;
            this.coordinateY= coordinateY;
        }

        public void LenthCircle()
        {
            double lenthCircle = 2 * Math.PI * radius;
            Console.WriteLine("Длина окружности равна {0}",lenthCircle);
        }
        public void SquareCircle()
        {
            double squareCircle = Math.PI * radius * radius;
            Console.WriteLine("Площадь круга равна {0}", squareCircle);
        }
        public void MemberCircle()
        {
            double polar = Math.Sqrt(Math.Pow(coordinateX, 2) + Math.Pow(coordinateY, 2));
            if (polar>radius)
            {
                Console.WriteLine("Точка с введеными координатами X, Y не принадлежит кругу");
            }
            else
            {
                Console.WriteLine("Точка с введеными координатами X, Y принадлежит кругу");
            }
        }

    }
}
