using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3laba
{
	class RegularPentagon : Figure
	{
		public float Radius { get; set; }

		public override double GetArea()
		{
			throw new NotImplementedException();
		}

		public override Point GetCenter()
		{
			return new Point(Position.X, Position.Y);
		}

		public override void Draw(Graphics gr)
		{
			Pen pen = new Pen(Brushes.DarkGoldenrod);
			PointF[] points = new PointF[5];
			Point center = GetCenter();
			float startangle = 0.0f;

			for (int i = 0; i < 5; i++, startangle += 72)
			{
				points[i] = new PointF(center.X + (float)Math.Cos(startangle * Math.PI / 180.0f) * Radius, center.Y + (float)Math.Sin(startangle * Math.PI / 180.0f) * Radius);
			}

			gr.DrawPolygon(pen, points);
			gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
		}


	}
}