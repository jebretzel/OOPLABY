using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _3laba
{
	class Circle : Figure
	{
		public double Radius { get; set; }

		public override double GetArea()
		{
			return Radius * Radius * Math.PI;
		}

		public override Point GetCenter()
		{
			return new Point((int)(Position.X + ((Radius * 2) / 2)), (int)(Position.Y + ((Radius * 2) / 2)));
		}

		public override void Draw(Graphics gr)
		{
			Pen C = new Pen(Color.Chocolate, 1);

			gr.DrawEllipse(C, Position.X, Position.Y, (int)Radius * 2, (int)Radius * 2);

			gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
		}
	}
}