﻿using System;
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
			Close();
		}
	}
}
