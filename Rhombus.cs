using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3laba
{
	class Rhombus : Figure
	{
		public float DiagX { get; set; }
		public float DiagY { get; set; }

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
			Point center = GetCenter();
			float Angle1 = 0.0f;
			float Angle2 = 0.0f;

			float SideOfRhombus = (float)Math.Sqrt((float)Math.Pow((DiagX / 2), 2) + (float)Math.Pow((DiagY / 2), 2));

			Angle1 = 2 * ((float)Math.Asin((float)(DiagY / 2) / (float)SideOfRhombus) * (180 / (float)Math.PI));
			Angle2 = 2 * ((float)Math.Asin((float)(DiagX / 2) / (float)SideOfRhombus) * (180 / (float)Math.PI));


			PointF[] points =
			{
				new PointF(center.X + ((float)Math.Cos(Angle1 * Math.PI / 180.0f) * (DiagX / 2)),                center.Y + ((float)Math.Sin(Angle2 * Math.PI / 180.0f) * (DiagY / 2))),
				new PointF(center.X + ((float)Math.Cos((Angle1+Angle2) * Math.PI / 180.0f) * (DiagX / 2)),       center.Y + ((float)Math.Sin((Angle2 + Angle1) * Math.PI / 180.0f) * (DiagY / 2))),
				new PointF(center.X + ((float)Math.Cos((Angle1 + 2*Angle2) * Math.PI / 180.0f) * (DiagX / 2)),   center.Y + ((float)Math.Sin((2*Angle2 + Angle1) * Math.PI / 180.0f) * (DiagY / 2))),
				new PointF(center.X + ((float)Math.Cos((2*Angle1 + 3*Angle2) * Math.PI / 180.0f) * (DiagX / 2)), center.Y + ((float)Math.Sin((2*Angle2 + 2*Angle1) * Math.PI / 180.0f) * (DiagY / 2))),
			};

			gr.DrawPolygon(pen, points);
			gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
		}
	}
}