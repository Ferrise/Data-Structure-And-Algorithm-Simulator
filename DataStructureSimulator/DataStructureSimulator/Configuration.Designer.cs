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
			this.label2 = new System.Windows.Forms.Label();
			this.inputGrpBox = new System.Windows.Forms.GroupBox();
			this.strRadBtn = new System.Windows.Forms.RadioButton();
			this.numRadBtn = new System.Windows.Forms.RadioButton();
			this.compCmbBox = new System.Windows.Forms.ComboBox();
			this.compLbl = new System.Windows.Forms.Label();
			this.inputLbl = new System.Windows.Forms.Label();
			this.inputTxtBox = new System.Windows.Forms.TextBox();
			this.inputGrpBox.SuspendLayout();
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
			this.dataStructCmbBox.Location = new System.Drawing.Point(127, 21);
			this.dataStructCmbBox.Name = "dataStructCmbBox";
			this.dataStructCmbBox.Size = new System.Drawing.Size(121, 21);
			this.dataStructCmbBox.TabIndex = 4;
			this.dataStructCmbBox.Text = "         -- Select --";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(27, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 19);
			this.label2.TabIndex = 5;
			this.label2.Text = "Input type:";
			// 
			// inputGrpBox
			// 
			this.inputGrpBox.Controls.Add(this.strRadBtn);
			this.inputGrpBox.Controls.Add(this.numRadBtn);
			this.inputGrpBox.Location = new System.Drawing.Point(103, 48);
			this.inputGrpBox.Name = "inputGrpBox";
			this.inputGrpBox.Size = new System.Drawing.Size(145, 59);
			this.inputGrpBox.TabIndex = 6;
			this.inputGrpBox.TabStop = false;
			// 
			// strRadBtn
			// 
			this.strRadBtn.AutoSize = true;
			this.strRadBtn.Location = new System.Drawing.Point(6, 36);
			this.strRadBtn.Name = "strRadBtn";
			this.strRadBtn.Size = new System.Drawing.Size(52, 17);
			this.strRadBtn.TabIndex = 1;
			this.strRadBtn.TabStop = true;
			this.strRadBtn.Text = "String";
			this.strRadBtn.UseVisualStyleBackColor = true;
			// 
			// numRadBtn
			// 
			this.numRadBtn.AutoSize = true;
			this.numRadBtn.Location = new System.Drawing.Point(6, 13);
			this.numRadBtn.Name = "numRadBtn";
			this.numRadBtn.Size = new System.Drawing.Size(72, 17);
			this.numRadBtn.TabIndex = 0;
			this.numRadBtn.TabStop = true;
			this.numRadBtn.Text = "Numerical";
			this.numRadBtn.UseVisualStyleBackColor = true;
			// 
			// compCmbBox
			// 
			this.compCmbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.compCmbBox.FormattingEnabled = true;
			this.compCmbBox.Location = new System.Drawing.Point(128, 129);
			this.compCmbBox.Name = "compCmbBox";
			this.compCmbBox.Size = new System.Drawing.Size(121, 21);
			this.compCmbBox.TabIndex = 8;
			this.compCmbBox.Text = "         -- Select --";
			// 
			// compLbl
			// 
			this.compLbl.AutoSize = true;
			this.compLbl.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.compLbl.Location = new System.Drawing.Point(27, 129);
			this.compLbl.Name = "compLbl";
			this.compLbl.Size = new System.Drawing.Size(95, 19);
			this.compLbl.TabIndex = 7;
			this.compLbl.Text = "Data structure:";
			// 
			// inputLbl
			// 
			this.inputLbl.AutoSize = true;
			this.inputLbl.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputLbl.Location = new System.Drawing.Point(27, 175);
			this.inputLbl.Name = "inputLbl";
			this.inputLbl.Size = new System.Drawing.Size(75, 19);
			this.inputLbl.TabIndex = 9;
			this.inputLbl.Text = "Initial input:";
			// 
			// inputTxtBox
			// 
			this.inputTxtBox.Location = new System.Drawing.Point(127, 175);
			this.inputTxtBox.Name = "inputTxtBox";
			this.inputTxtBox.Size = new System.Drawing.Size(120, 20);
			this.inputTxtBox.TabIndex = 10;
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
			this.Controls.Add(this.inputGrpBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataStructCmbBox);
			this.Controls.Add(this.dataStructLbl);
			this.Controls.Add(this.backBtn);
			this.Controls.Add(this.simulateBtn);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ConfigurationFrm";
			this.Text = "Data Structure Configuration";
			this.inputGrpBox.ResumeLayout(false);
			this.inputGrpBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button simulateBtn;
		private System.Windows.Forms.Button backBtn;
		private System.Windows.Forms.Label dataStructLbl;
		private System.Windows.Forms.ComboBox dataStructCmbBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox inputGrpBox;
		private System.Windows.Forms.RadioButton strRadBtn;
		private System.Windows.Forms.RadioButton numRadBtn;
		private System.Windows.Forms.ComboBox compCmbBox;
		private System.Windows.Forms.Label compLbl;
		private System.Windows.Forms.Label inputLbl;
		private System.Windows.Forms.TextBox inputTxtBox;
	}
}