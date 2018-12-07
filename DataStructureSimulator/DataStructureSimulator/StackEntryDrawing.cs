using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureSimulator
{
	class StackEntryDrawing
	{
		private int width;
		private int height;
		private int x;
		private int y;

		public StackEntryDrawing(int width, int height, int x, int y)
		{
			this.width = width;
			this.height = height;
			this.x = x;
			this.y = y;
		}

		// Draws this stack entry onto g
		public void draw(Graphics g, Pen pen)
		{
			g.DrawRectangle(pen, new Rectangle(this.width, this.height, this.x, this.y)); 
		}
	}
}
