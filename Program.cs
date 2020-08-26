using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Работу выполняет Виноградов Евгений Михайлович
            ////Задача №1
            //Console.WriteLine("Введите ваше имя");
            //string box = Console.ReadLine();
            //Console.WriteLine("Введите вашу фамилию");
            //string box1 = Console.ReadLine();
            //Console.WriteLine("Введите ваш возраст");
            //string box2 = Console.ReadLine();
            //Console.WriteLine("Введите ваш рост");
            //string box3 = Console.ReadLine();
            //Console.WriteLine("Введите ваш вес");
            //string box4 = Console.ReadLine();
            ////Console.Write("Ваша анкета, "); колхозный способ
            ////Console.Write(box);
            ////Console.Write(" ");
            ////Console.Write(box1);
            ////Console.Write(" ");
            ////Console.Write(box2);
            ////Console.Write(" ");
            ////Console.Write(box3);
            ////Console.Write(" ");
            ////Console.Write(box4);
            ////Console.Write("Ваше имя, " + box); колхозный способ №2
            ////Console.Write("Ваша фамилия, " + box1);
            ////Console.Write("Ваш возраст, " + box2);
            ////Console.Write("Ваш рост, " + box3);
            ////Console.Write("Ваш вес, " + box4);
            ////Console.Write("Ваше анкета, {0} {1} {2} {3} {4}", box, box1, box2, box3, box4); Продвинутый форматирование строк
            //Console.Write($"Ваше анкета, {box} {box1} {box2} {box3} {box4}"); /*Продвинутый интерполяция строк самый правильный по версии microsoft*/

            ////Задача №2
            //Console.WriteLine("Введите ваш вес в килограммах");
            //double m = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите ваш рост в метрах");
            //double h = Convert.ToDouble(Console.ReadLine());
            //double I = m / (h * h);
            //Console.WriteLine($"Ваш индекс массы тела равен: ({h}*{h})/{m} = {I}");

            //Задача №3
            Console.WriteLine("Введите x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y2");
            int y2 = Convert.ToInt32(Console.ReadLine());
            float r = 0;
            r = (float)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("{0:f2}", r);
        }
    }
}
