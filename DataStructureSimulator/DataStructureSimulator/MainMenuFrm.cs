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
	public partial class MainMenuFrm : Form
	{
		public MainMenuFrm()
		{
			InitializeComponent();
		}

		// Gracefully exits the program
		private void quitBtn_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}

		// Opens the configuration form and hides this form
		private void startBtn_Click(object sender, EventArgs e)
		{
			ConfigurationFrm configurationForm = new ConfigurationFrm();
			configurationForm.Show();
			this.Hide();
		}
	}
}
