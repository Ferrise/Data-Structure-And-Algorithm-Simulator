using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructureSimulator
{
	class StackEntryDrawing
	{
		private int width;
		private int height;
		private int x;
		private int y;
		private int data;

		public StackEntryDrawing(int width, int height, int x, int y, int data)
		{
			this.width = width;
			this.height = height;
			this.x = x;
			this.y = y;
			this.data = data;
		}

		// Draws this stack entry onto g
		public void draw(Graphics g, Pen pen)
		{
			g.DrawRectangle(pen, new Rectangle(this.x, this.y, this.width, this.height));
			g.DrawString(String.Format("{0}", data), new Font("arial", 8), new SolidBrush(Color.Red), 
				(this.x + this.width) - (this.width/2), (this.y + this.height / 2));
		}
	}
}
