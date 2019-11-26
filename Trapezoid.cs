using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3laba
{
	class Trapezoid : Figure
	{


		public override double GetArea()
		{
			throw new NotImplementedException();
		}

		public override Point GetCenter()
		{
			return new Point(Position.X + 50, Position.Y + 50);
		}

		public override void Draw(Graphics gr)
		{
			Pen pen = new Pen(Color.Black, 2);
			Point[] pnts =
			{
			  new Point(Position.X +50, Position.Y+ 10),
			  new Point(Position.X +100,Position.Y+ 10),
			  new Point(Position.X +140,Position.Y+ 100),
			  new Point(Position.X +10,Position.Y+ 100),
			  new Point(Position.X +50,Position.Y+ 10)
			};

			gr.DrawLines(pen, pnts);
			gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
		}

	}
}