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
	public partial class ConfigurationFrm : Form
	{
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
	}
}
