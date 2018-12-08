using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructureSimulator
{
	public partial class inputFrm : Form
	{
		private int intInput;
		private StackDrawing stackDrawing;
		private PictureBox context;

		public inputFrm(StackDrawing drawing, PictureBox context)
		{
			InitializeComponent();
			intInput = 0;
			this.stackDrawing = drawing;
			this.context = context;
		}

		// Returns the input entered by the user
		public int getIntInput()
		{
			return this.intInput;
		}

		// Ensures that the user only enters one digit
		private void pushTxtBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			char key = e.KeyChar;
			// Only digits and spaces are permitted
			if (!char.IsDigit(key))
			{
				MessageBox.Show("Not a digit! Please only enter digits.");
				// Ensures key is not added to the text
				e.Handled = true;
			}
		
		}

		// Retrieves value to push onto the stack from the user
		private void pushBtn_Click(object sender, EventArgs e)
		{
			String input = pushTxtBox.Text;

			if (input == "")
			{
				MessageBox.Show("You must enter a number.");
			}
			else
			{
				intInput = int.Parse(input);
				this.stackDrawing.add(intInput);
				context.Refresh();
				Close();
			}

		}
	}
}
