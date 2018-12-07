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
			this.resourceBtn = new System.Windows.Forms.Button();
			this.quitBtn = new System.Windows.Forms.Button();
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
			// resourceBtn
			// 
			this.resourceBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.resourceBtn.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resourceBtn.Location = new System.Drawing.Point(82, 124);
			this.resourceBtn.Name = "resourceBtn";
			this.resourceBtn.Size = new System.Drawing.Size(106, 25);
			this.resourceBtn.TabIndex = 2;
			this.resourceBtn.Text = "Resources";
			this.resourceBtn.UseVisualStyleBackColor = true;
			// 
			// quitBtn
			// 
			this.quitBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.quitBtn.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.quitBtn.Location = new System.Drawing.Point(82, 190);
			this.quitBtn.Name = "quitBtn";
			this.quitBtn.Size = new System.Drawing.Size(106, 25);
			this.quitBtn.TabIndex = 4;
			this.quitBtn.Text = "Quit";
			this.quitBtn.UseVisualStyleBackColor = true;
			this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
			// 
			// MainMenuFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 251);
			this.Controls.Add(this.quitBtn);
			this.Controls.Add(this.resourceBtn);
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
		private System.Windows.Forms.Button resourceBtn;
		private System.Windows.Forms.Button quitBtn;
	}
}

