using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3laba
{
	class Triangle : Figure
	{
		public double SideA { get; set; }
		public double SideB { get; set; }
		public double SideC { get; set; }
		public override double GetArea()

		{
			if ((SideA < SideB + SideC) && (SideA > SideB - SideC) && (SideB < SideA + SideC) && (SideB > SideA - SideC) && (SideC < SideA + SideB) && (SideC > SideA - SideB))
			{
				double P = 0.5 * (SideA + SideB + SideC);
				return (Math.Sqrt(P * (P - SideA) * (P - SideB) * (P - SideC)));
			}
			else
			{
				Console.WriteLine("Ошибка. Повторите ввод значений, такой фигуры не может существовать");
				return 0;
			}

		}

		public override Point GetCenter()
		{
			return new Point(Position.X, Position.Y);
		}

		public override void Draw(Graphics gr)
		{
			Point[] points =
			{
				new Point(Position.X,Position.Y + 100),
				new Point(Position.X + 50,Position.Y - 100),
				new Point(Position.X - 50,Position.Y - 100),
				new Point(Position.X, Position.Y + 100),
			};
			Pen pen = new Pen(Brushes.BlueViolet);
			gr.DrawLines(pen, points);
			gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
		}
	}
}