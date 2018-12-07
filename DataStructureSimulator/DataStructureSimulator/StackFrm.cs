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

		private void StackFrm_Load(object sender, EventArgs e)
		{
		}

		private void stackSimPicBox_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.Clear(Color.White);
			Pen pen = new Pen(Color.Red, 5);
			this.stackImage.draw(g, pen);
		}
	}
}
