using System;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Note: Refrenced https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control.paint?view=netframework-4.7.2 to write the code for the StackFrm_Paint method 

namespace DataStructureSimulator
{
	public partial class StackFrm : Form
	{
		private LinkedStack<int> inputs;
		private LinkedStack<int> stack;
		private StackDrawing stackImage;

		public StackFrm(LinkedStack<int> inputs)
		{
			InitializeComponent();
			this.inputs = inputs;
			this.stack = new LinkedStack<int>();
			this.stackImage = new StackDrawing(stackSimPicBox.Width / 2, stackSimPicBox.Height, 50, 50, this.inputs);
		}


		// Draws the stack onto the picture box
		private void stackSimPicBox_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			Pen pen = new Pen(Color.Red, 5);
			this.stackImage.draw(g, pen);
		}

		// Opens up a form that will prompt the user to enter the integer to be pushed and push that integer to the stack
		private void pushBtn_Click(object sender, EventArgs e)
		{
			inputFrm inputForm = new inputFrm(this.stackImage, stackSimPicBox);
			inputForm.Show();
		}

		// Removes the top element of the stack from the graphic when clicked
		private void popBtn_Click(object sender, EventArgs e)
		{
			if (stackImage.isEmpty())
			{
				return;
			}

			this.stackImage.pop();
			stackSimPicBox.Refresh();
		}
	}
}
