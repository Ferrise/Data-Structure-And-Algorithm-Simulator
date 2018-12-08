namespace DataStructureSimulator
{
	partial class inputFrm
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
			this.enterIntLbl = new System.Windows.Forms.Label();
			this.pushTxtBox = new System.Windows.Forms.TextBox();
			this.pushBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// enterIntLbl
			// 
			this.enterIntLbl.AutoSize = true;
			this.enterIntLbl.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.enterIntLbl.Location = new System.Drawing.Point(12, 25);
			this.enterIntLbl.Name = "enterIntLbl";
			this.enterIntLbl.Size = new System.Drawing.Size(87, 19);
			this.enterIntLbl.TabIndex = 0;
			this.enterIntLbl.Text = "Enter integer:";
			// 
			// pushTxtBox
			// 
			this.pushTxtBox.Location = new System.Drawing.Point(105, 24);
			this.pushTxtBox.Name = "pushTxtBox";
			this.pushTxtBox.Size = new System.Drawing.Size(99, 20);
			this.pushTxtBox.TabIndex = 1;
			this.pushTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pushTxtBox_KeyPress);
			// 
			// pushBtn
			// 
			this.pushBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.pushBtn.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pushBtn.Location = new System.Drawing.Point(53, 50);
			this.pushBtn.Name = "pushBtn";
			this.pushBtn.Size = new System.Drawing.Size(106, 25);
			this.pushBtn.TabIndex = 3;
			this.pushBtn.Text = "Push";
			this.pushBtn.UseVisualStyleBackColor = true;
			this.pushBtn.Click += new System.EventHandler(this.pushBtn_Click);
			// 
			// inputFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(220, 85);
			this.Controls.Add(this.pushBtn);
			this.Controls.Add(this.pushTxtBox);
			this.Controls.Add(this.enterIntLbl);
			this.Name = "inputFrm";
			this.Text = "Stack Input";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label enterIntLbl;
		private System.Windows.Forms.TextBox pushTxtBox;
		private System.Windows.Forms.Button pushBtn;
	}
}