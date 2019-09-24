using lab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная №1 - Инкапсуляция");
            Console.WriteLine("Выполнил - Афанасьев Евгений");

            lab1.Complex a = new lab1.Complex() { Real = 3, Imag = 4 };
            lab1.Complex b = new lab1.Complex() { Real = 5, Imag = 7 };

            a.Add(b);
            Console.WriteLine(" Сложение " );
            Console.WriteLine("a = {0} + {1}i", a.Real, a.Imag);
            a = new lab1.Complex() { Real = 3, Imag = 4 };
            b = new lab1.Complex() { Real = 2, Imag = 8 };

            b.Substract(a);
            Console.WriteLine(" Вычитание ");
            Console.WriteLine("b = {0} + {1}i", b.Real, b.Imag);
            a = new lab1.Complex() { Real = 3, Imag = 4 };
            b = new lab1.Complex() { Real = 2, Imag = 8 };

            a.Multiply(b);
            Console.WriteLine(" Умножение ");
            Console.WriteLine("a = {0} + {1}i", a.Real, a.Imag);
            a = new lab1.Complex() { Real = 2, Imag = 0.4 };
            b = new lab1.Complex() { Real = 5, Imag = 3 };

            b.Divide(a);
            Console.WriteLine(" Деление ");
            Console.WriteLine("b = {0} + {1}i", b.Real, b.Imag);

			Student ns = new Student();
			Student ns1 = new Student();


			ns.MashUp(ns1);
			Console.WriteLine("ns = Имя студента : {0} | Пол  : {1} | Возраст : {2} | Цвет волос : {3} ", ns.name, ns.sex, ns.age, ns.haircolor);
		
			Console.ReadLine();
		}
        
    }
    
}
