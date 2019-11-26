using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace _3laba
{
	public abstract class Figure
	{
		public string Name { get; set; }
		public System.Drawing.Color Color { get; set; }
		public System.Drawing.Point Position { get; set; }

		public abstract double GetArea();
		public abstract System.Drawing.Point GetCenter();
		public abstract void Draw(Graphics gr);
	}
}