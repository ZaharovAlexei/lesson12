using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticClassCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода:
            метод, определяющий длину окружности по заданному радиусу;
            метод, определяющий площадь круга по заданному радиусу;
            метод, проверяющий принадлежность точки с координатами(x, y) кругу с радиусом r и координатами центра x0, y0.*/

            Console.WriteLine("Выберите тип решаемой задачи");
            Console.WriteLine("1. Определение длины окружности по радиусу.");
            Console.WriteLine("2. Определение площади круга по радиусу.");
            Console.WriteLine("3. Проверка принадлежности точки с координатами(x, y) кругу с радиусом r и координатами центра x0, y0.");
            Console.Write("Ваш выбор: ");

            string selection = Console.ReadLine();
            double radius, length, square, x, y;
            string member;

            switch (selection)
            {
                case "1":
                    Console.Write("Введите радиус окружности: ");
                    length = Circle.LengthCircle(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Длина окружности составляет: {0:F3}", length);
                    break;

                case "2":
                    Console.Write("Введите радиус окружности: ");
                    square = Circle.SquareCircle(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Площадь круга составляет: {0:F3}", square);
                    break;

                case "3":
                    Console.Write("Введите радиус окружности: ");
                    radius = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите координату точки по оси X: ");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите координату точки по оси Y: ");
                    y = Convert.ToDouble(Console.ReadLine());
                    member = Circle.MemberCircle(radius,x,y);
                    Console.WriteLine(member);
                    break;

                default:
                    Console.WriteLine("Ошибка выбора! Выберите из предложенных вариантов");
                    break;
            }
            Console.WriteLine("Нажмите любую клавишу для выхода");
            Console.ReadKey();
        }
    }
    public static class Circle
    {
        public static double LengthCircle (double radius)
        {
            double lengthCircle = 2 * Math.PI * radius;
            return lengthCircle;
        }
        public static double SquareCircle (double radius)
        {
            double squareCircle = Math.PI * radius * radius;
            return squareCircle;
        }
        public static string MemberCircle (double radius, double coordinateX, double coordinateY)
        {
            double polar = Math.Sqrt(Math.Pow(coordinateX, 2) + Math.Pow(coordinateY, 2));
            string memberCircle;
            if (polar <= radius)
            {
                memberCircle = "Точка с введеными координатами принадлежит кругу";
            }
            else
            {
                memberCircle = "Точка с введеными координатами не принадлежит кругу";
            }
            return memberCircle;
        }
    }
}
