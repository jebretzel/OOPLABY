using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3laba
{
	class Program
	{
		public static Figure[] figures =
		{
			new Rectangle()
			{
				 Name = "Квадрат",
				 Color = System.Drawing.Color.DarkRed,
				 Position = new System.Drawing.Point(30, 30),
				 Width = 50, Height = 50,
			},

			new Circle()
			{
				 Name = "Круг",
				 Color = System.Drawing.Color.DarkRed,
				 Position = new System.Drawing.Point(200, 200),
				 Radius = 70,
			},

			new Trapezoid()
			{
				 Name = "Трапеция",
				 Color = System.Drawing.Color.DarkRed,
				 Position = new System.Drawing.Point(333, 333),
			},

			new RegularDecagon()
			{
				 Name = "Правильный Десятиугольник",
				 Color = System.Drawing.Color.DarkRed,
				 Position = new System.Drawing.Point(500, 700),
				 Radius = 100
			},

			new RegularPentagon()
			{
				 Name = "Правильный Пятиугольник",
				 Color = System.Drawing.Color.DarkRed,
				 Position = new System.Drawing.Point(700, 200),
				 Radius = 100,
			},

			new Rhombus()
			{
				 Name = "Ромб",
				 Color = System.Drawing.Color.DarkRed,
				 Position = new System.Drawing.Point(900, 500),
				 DiagX = 70, DiagY = 100,
			},

			new Triangle()
			{
				 Name = "Треугольник",
				 Color = System.Drawing.Color.DarkRed,
				 Position = new System.Drawing.Point(200, 650),
				 SideA = 2, SideB = 3, SideC = 4,
			},
	};
		static void Main(string[] args)
		{
			Console.WriteLine("Лабораторная работа №3");
			Console.WriteLine("Выполнил - Афанасьев Евгений");
			Form frm = new Form()
			{
				Text = "Лабораторная работа №3 - полиморфизм. Выполнил - Афанасьев Евгений",
				Size = new System.Drawing.Size(1280, 900),
				StartPosition = FormStartPosition.CenterScreen,
			};

			frm.Paint += Frm_Paint;
			Application.Run(frm);
		}

		private static void Frm_Paint(object sender, PaintEventArgs e)
		{
			foreach (Figure f in figures)
			{
				f.Draw(e.Graphics);
			}
		}
	}
}