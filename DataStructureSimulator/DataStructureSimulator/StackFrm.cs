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
		private Stack inputs;
		private LinkedStack<int> stack;

		public StackFrm(Stack inputs)
		{
			InitializeComponent();
			this.inputs = inputs;
			this.stack = new LinkedStack<int>();
		}

		private void StackFrm_Load(object sender, EventArgs e)
		{

		}

		private void StackFrm_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
            
		}
	}
}
