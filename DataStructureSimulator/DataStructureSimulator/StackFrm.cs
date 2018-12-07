using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructureSimulator
{
	public partial class StackFrm : Form
	{
		private LinkedStack<int> inputs;
		private LinkedStack<int> stack;

		public StackFrm(LinkedStack<int> inputs)
		{
			InitializeComponent();
			this.inputs = inputs;
			this.stack = new LinkedStack<int>();
		}

		private void StackFrm_Load(object sender, EventArgs e)
		{

		}
	}
}
