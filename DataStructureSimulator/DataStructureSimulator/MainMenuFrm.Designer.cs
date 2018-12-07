namespace DataStructureSimulator
{
	partial class MainMenuFrm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuFrm));
			this.startBtn = new System.Windows.Forms.Button();
			this.titleLbl = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// startBtn
			// 
			this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.startBtn.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startBtn.Location = new System.Drawing.Point(82, 62);
			this.startBtn.Name = "startBtn";
			this.startBtn.Size = new System.Drawing.Size(106, 25);
			this.startBtn.TabIndex = 0;
			this.startBtn.Text = "Start";
			this.startBtn.UseVisualStyleBackColor = true;
			// 
			// titleLbl
			// 
			this.titleLbl.AutoSize = true;
			this.titleLbl.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleLbl.Location = new System.Drawing.Point(30, 19);
			this.titleLbl.Name = "titleLbl";
			this.titleLbl.Size = new System.Drawing.Size(221, 28);
			this.titleLbl.TabIndex = 1;
			this.titleLbl.Text = "Data Structure Simulator";
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(82, 124);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(106, 25);
			this.button2.TabIndex = 2;
			this.button2.Text = "Resources";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button4.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(82, 190);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(106, 25);
			this.button4.TabIndex = 4;
			this.button4.Text = "Quit";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// MainMenuFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 251);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.titleLbl);
			this.Controls.Add(this.startBtn);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainMenuFrm";
			this.Text = "Data Structure Simulator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button startBtn;
		private System.Windows.Forms.Label titleLbl;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button4;
	}
}

