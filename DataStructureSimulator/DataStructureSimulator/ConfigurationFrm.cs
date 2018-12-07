using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Note: the part of my code "Split((char[]) null, StringSplitOptions.RemoveEmptyEntries)" 
// was obtained from this link https://stackoverflow.com/questions/11142676/c-sharp-split-string-by-any-number-of-tabs-and-spaces

namespace DataStructureSimulator
{
	public partial class ConfigurationFrm : Form
	{
		private Boolean hasBeenEntered = false;

		enum DataStrucutre { Stack };

		public ConfigurationFrm()
		{
			InitializeComponent();
		}

		// Returns to main menu form and hides this form
		private void backBtn_Click(object sender, EventArgs e)
		{
			MainMenuFrm mainMenuForm = new MainMenuFrm();
			mainMenuForm.Show();
			this.Hide();
		}

		// Produces a simulation form based on the selected configurations
		private void simulateBtn_Click(object sender, EventArgs e)
		{
			int dataStructure = dataStructCmbBox.SelectedIndex;
			LinkedStack<int> inputs = new LinkedStack<int>();

			// Populates inputs by converting each digit entered into a 32-bit integer
			// The string array produced by trimming then splitting by all whitespace is iterated over
			foreach (String entry in inputTxtBox.Text.Trim().Split((char[]) null, StringSplitOptions.RemoveEmptyEntries))
			{
				// Handles the case where one the numbers entred is too small or large
				try
				{
					inputs.push(Int32.Parse(entry));
				}
				catch (OverflowException ex)
				{
					MessageBox.Show("One of the numbers you entered is too large. Please reenter your input.");
					inputTxtBox.Text = "";
					return;
				}
			}

			// Determines which simulation to open based on the selected data structure
			switch(dataStructure)
			{
				case 0:
					StackFrm stackForm = new StackFrm(inputs);
					stackForm.Show();
					this.Hide();
					break;
			}
		}

		// Clears the text box when it is entered for the first time
		private void inputTxtBox_Enter(object sender, EventArgs e)
		{
			if (hasBeenEntered == false)
			{
				inputTxtBox.Text = "";
			}
			hasBeenEntered = true;
		}

		// Prompts user to enter a digit if they did not
		private void inputTxtBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			char key = e.KeyChar;
			// Only digits and spaces are permitted
			if (!char.IsDigit(key) && key != ' ')
			{
				MessageBox.Show("Not a digit! Please only enter digits.");
				// Ensures key is not added to the text
				e.Handled = true; 
			}
		}
	}
}
