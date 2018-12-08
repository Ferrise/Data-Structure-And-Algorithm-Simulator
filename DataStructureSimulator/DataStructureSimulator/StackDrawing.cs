using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureSimulator
{
	class StackDrawing
	{
		private int x;
		private int y;
		private int width;
		private int height;
		private LinkedStack<StackEntryDrawing> stackEntries;

		public StackDrawing(int x, int startY, int width, int height, LinkedStack<int> inputs)
		{
			this.y = startY - height;
			this.stackEntries = new LinkedStack<StackEntryDrawing>();

			// Populate stackEntries. The first entry is the last element of inputs.
			// This is because the stack is drawn from the base -- as a result, we must reverse the order of inputs
			// when drawing the image of the stack itself.
			while (!inputs.isEmpty())
			{
				StackEntryDrawing currEntry = new StackEntryDrawing(width, height, x, y, inputs.First.Value);
				inputs.RemoveFirst();
				this.stackEntries.AddFirst(currEntry);
				y -= height;
			}

			this.x = x;
			this.width = width;
			this.height = height;
		}

		// Adds a new stack entry to stackEntries
		public void add(int input)
		{
			StackEntryDrawing inputStackEntry = new StackEntryDrawing(width, height, x, y, input);
			this.stackEntries.push(inputStackEntry);
		}

		// Removes the top element of this
		public void pop()
		{
			stackEntries.pop();
		}

		// Returns whether this is empty
		public Boolean isEmpty()
		{
			return this.stackEntries.isEmpty();
		}

		// Draws the stack represented by this StackDrawing onto g
		public void draw(Graphics g, Pen pen)
		{
			LinkedList<StackEntryDrawing>.Enumerator iter = this.stackEntries.GetEnumerator();
			
			while (iter.MoveNext())
			{
				iter.Current.draw(g, pen);
			}
		}
	}
}
