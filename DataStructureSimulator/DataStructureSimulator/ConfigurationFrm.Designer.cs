namespace DataStructureSimulator
{
	partial class ConfigurationFrm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationFrm));
			this.simulateBtn = new System.Windows.Forms.Button();
			this.backBtn = new System.Windows.Forms.Button();
			this.dataStructLbl = new System.Windows.Forms.Label();
			this.dataStructCmbBox = new System.Windows.Forms.ComboBox();
			this.inputLbl = new System.Windows.Forms.Label();
			this.inputTxtBox = new System.Windows.Forms.TextBox();
			this.compLbl = new System.Windows.Forms.Label();
			this.compCmbBox = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// simulateBtn
			// 
			this.simulateBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.simulateBtn.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.simulateBtn.Location = new System.Drawing.Point(30, 224);
			this.simulateBtn.Name = "simulateBtn";
			this.simulateBtn.Size = new System.Drawing.Size(106, 25);
			this.simulateBtn.TabIndex = 1;
			this.simulateBtn.Text = "Simulate";
			this.simulateBtn.UseVisualStyleBackColor = true;
			this.simulateBtn.Click += new System.EventHandler(this.simulateBtn_Click);
			// 
			// backBtn
			// 
			this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.backBtn.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.backBtn.Location = new System.Drawing.Point(142, 224);
			this.backBtn.Name = "backBtn";
			this.backBtn.Size = new System.Drawing.Size(106, 25);
			this.backBtn.TabIndex = 2;
			this.backBtn.Text = "Back";
			this.backBtn.UseVisualStyleBackColor = true;
			this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
			// 
			// dataStructLbl
			// 
			this.dataStructLbl.AutoSize = true;
			this.dataStructLbl.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataStructLbl.Location = new System.Drawing.Point(27, 21);
			this.dataStructLbl.Name = "dataStructLbl";
			this.dataStructLbl.Size = new System.Drawing.Size(95, 19);
			this.dataStructLbl.TabIndex = 3;
			this.dataStructLbl.Text = "Data structure:";
			// 
			// dataStructCmbBox
			// 
			this.dataStructCmbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataStructCmbBox.FormattingEnabled = true;
			this.dataStructCmbBox.Items.AddRange(new object[] {
            "Stack"});
			this.dataStructCmbBox.Location = new System.Drawing.Point(127, 21);
			this.dataStructCmbBox.Name = "dataStructCmbBox";
			this.dataStructCmbBox.Size = new System.Drawing.Size(121, 21);
			this.dataStructCmbBox.TabIndex = 4;
			this.dataStructCmbBox.Text = "         -- Select --";
			// 
			// inputLbl
			// 
			this.inputLbl.AutoSize = true;
			this.inputLbl.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputLbl.Location = new System.Drawing.Point(27, 175);
			this.inputLbl.Name = "inputLbl";
			this.inputLbl.Size = new System.Drawing.Size(84, 19);
			this.inputLbl.TabIndex = 9;
			this.inputLbl.Text = "Integer input:";
			// 
			// inputTxtBox
			// 
			this.inputTxtBox.Location = new System.Drawing.Point(127, 175);
			this.inputTxtBox.Name = "inputTxtBox";
			this.inputTxtBox.Size = new System.Drawing.Size(120, 20);
			this.inputTxtBox.TabIndex = 10;
			this.inputTxtBox.Text = "Seperate with Spaces";
			this.inputTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.inputTxtBox.Enter += new System.EventHandler(this.inputTxtBox_Enter);
			this.inputTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputTxtBox_KeyPress);
			// 
			// compLbl
			// 
			this.compLbl.AutoSize = true;
			this.compLbl.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.compLbl.Location = new System.Drawing.Point(27, 96);
			this.compLbl.Name = "compLbl";
			this.compLbl.Size = new System.Drawing.Size(77, 19);
			this.compLbl.TabIndex = 7;
			this.compLbl.Text = "Comparison:";
			// 
			// compCmbBox
			// 
			this.compCmbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.compCmbBox.FormattingEnabled = true;
			this.compCmbBox.Location = new System.Drawing.Point(127, 96);
			this.compCmbBox.Name = "compCmbBox";
			this.compCmbBox.Size = new System.Drawing.Size(121, 21);
			this.compCmbBox.TabIndex = 8;
			this.compCmbBox.Text = "         -- Select --";
			// 
			// ConfigurationFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.inputTxtBox);
			this.Controls.Add(this.inputLbl);
			this.Controls.Add(this.compCmbBox);
			this.Controls.Add(this.compLbl);
			this.Controls.Add(this.dataStructCmbBox);
			this.Controls.Add(this.dataStructLbl);
			this.Controls.Add(this.backBtn);
			this.Controls.Add(this.simulateBtn);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ConfigurationFrm";
			this.Text = "Data Structure Configuration";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button simulateBtn;
		private System.Windows.Forms.Button backBtn;
		private System.Windows.Forms.Label dataStructLbl;
		private System.Windows.Forms.ComboBox dataStructCmbBox;
		private System.Windows.Forms.Label inputLbl;
		private System.Windows.Forms.TextBox inputTxtBox;
		private System.Windows.Forms.Label compLbl;
		private System.Windows.Forms.ComboBox compCmbBox;
	}
}