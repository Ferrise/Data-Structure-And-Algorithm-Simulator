namespace DataStructureSimulator
{
	partial class StackFrm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StackFrm));
			this.stackSimPicBox = new System.Windows.Forms.PictureBox();
			this.pushBtn = new System.Windows.Forms.Button();
			this.popBtn = new System.Windows.Forms.Button();
			this.pushOLbl = new System.Windows.Forms.Label();
			this.popOLbl = new System.Windows.Forms.Label();
			this.leftArrowBtn = new System.Windows.Forms.Button();
			this.rightArrowBtn = new System.Windows.Forms.Button();
			this.stackTitleLbl = new System.Windows.Forms.Label();
			this.mainMenuBtn = new System.Windows.Forms.Button();
			this.exitBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.stackSimPicBox)).BeginInit();
			this.SuspendLayout();
			// 
			// stackSimPicBox
			// 
			this.stackSimPicBox.BackColor = System.Drawing.Color.White;
			this.stackSimPicBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.stackSimPicBox.Location = new System.Drawing.Point(51, 56);
			this.stackSimPicBox.Name = "stackSimPicBox";
			this.stackSimPicBox.Size = new System.Drawing.Size(590, 367);
			this.stackSimPicBox.TabIndex = 0;
			this.stackSimPicBox.TabStop = false;
			// 
			// pushBtn
			// 
			this.pushBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.pushBtn.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pushBtn.Location = new System.Drawing.Point(220, 460);
			this.pushBtn.Name = "pushBtn";
			this.pushBtn.Size = new System.Drawing.Size(106, 25);
			this.pushBtn.TabIndex = 2;
			this.pushBtn.Text = "Push";
			this.pushBtn.UseVisualStyleBackColor = true;
			// 
			// popBtn
			// 
			this.popBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.popBtn.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.popBtn.Location = new System.Drawing.Point(364, 460);
			this.popBtn.Name = "popBtn";
			this.popBtn.Size = new System.Drawing.Size(106, 25);
			this.popBtn.TabIndex = 3;
			this.popBtn.Text = "Pop";
			this.popBtn.UseVisualStyleBackColor = true;
			// 
			// pushOLbl
			// 
			this.pushOLbl.AutoSize = true;
			this.pushOLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pushOLbl.Location = new System.Drawing.Point(255, 488);
			this.pushOLbl.Name = "pushOLbl";
			this.pushOLbl.Size = new System.Drawing.Size(31, 13);
			this.pushOLbl.TabIndex = 4;
			this.pushOLbl.Text = "O(1)";
			// 
			// popOLbl
			// 
			this.popOLbl.AutoSize = true;
			this.popOLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.popOLbl.Location = new System.Drawing.Point(403, 488);
			this.popOLbl.Name = "popOLbl";
			this.popOLbl.Size = new System.Drawing.Size(31, 13);
			this.popOLbl.TabIndex = 5;
			this.popOLbl.Text = "O(1)";
			// 
			// leftArrowBtn
			// 
			this.leftArrowBtn.BackColor = System.Drawing.Color.Transparent;
			this.leftArrowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.leftArrowBtn.Image = ((System.Drawing.Image)(resources.GetObject("leftArrowBtn.Image")));
			this.leftArrowBtn.Location = new System.Drawing.Point(51, 429);
			this.leftArrowBtn.Name = "leftArrowBtn";
			this.leftArrowBtn.Size = new System.Drawing.Size(25, 20);
			this.leftArrowBtn.TabIndex = 6;
			this.leftArrowBtn.UseVisualStyleBackColor = false;
			// 
			// rightArrowBtn
			// 
			this.rightArrowBtn.BackColor = System.Drawing.Color.Transparent;
			this.rightArrowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rightArrowBtn.Image = ((System.Drawing.Image)(resources.GetObject("rightArrowBtn.Image")));
			this.rightArrowBtn.Location = new System.Drawing.Point(616, 429);
			this.rightArrowBtn.Name = "rightArrowBtn";
			this.rightArrowBtn.Size = new System.Drawing.Size(25, 20);
			this.rightArrowBtn.TabIndex = 7;
			this.rightArrowBtn.UseVisualStyleBackColor = false;
			// 
			// stackTitleLbl
			// 
			this.stackTitleLbl.AutoSize = true;
			this.stackTitleLbl.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.stackTitleLbl.Location = new System.Drawing.Point(235, 9);
			this.stackTitleLbl.Name = "stackTitleLbl";
			this.stackTitleLbl.Size = new System.Drawing.Size(202, 28);
			this.stackTitleLbl.TabIndex = 8;
			this.stackTitleLbl.Text = "Linked Stack Simulator";
			// 
			// mainMenuBtn
			// 
			this.mainMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.mainMenuBtn.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mainMenuBtn.Location = new System.Drawing.Point(75, 460);
			this.mainMenuBtn.Name = "mainMenuBtn";
			this.mainMenuBtn.Size = new System.Drawing.Size(106, 25);
			this.mainMenuBtn.TabIndex = 9;
			this.mainMenuBtn.Text = "Main Menu";
			this.mainMenuBtn.UseVisualStyleBackColor = true;
			// 
			// exitBtn
			// 
			this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.exitBtn.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitBtn.Location = new System.Drawing.Point(499, 460);
			this.exitBtn.Name = "exitBtn";
			this.exitBtn.Size = new System.Drawing.Size(106, 25);
			this.exitBtn.TabIndex = 10;
			this.exitBtn.Text = "Exit";
			this.exitBtn.UseVisualStyleBackColor = true;
			// 
			// StackFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(723, 518);
			this.Controls.Add(this.exitBtn);
			this.Controls.Add(this.mainMenuBtn);
			this.Controls.Add(this.stackTitleLbl);
			this.Controls.Add(this.rightArrowBtn);
			this.Controls.Add(this.leftArrowBtn);
			this.Controls.Add(this.popOLbl);
			this.Controls.Add(this.pushOLbl);
			this.Controls.Add(this.popBtn);
			this.Controls.Add(this.pushBtn);
			this.Controls.Add(this.stackSimPicBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "StackFrm";
			this.Text = "Stack Simulator";
			this.Load += new System.EventHandler(this.StackFrm_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.StackFrm_Paint);
			((System.ComponentModel.ISupportInitialize)(this.stackSimPicBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox stackSimPicBox;
		private System.Windows.Forms.Button pushBtn;
		private System.Windows.Forms.Button popBtn;
		private System.Windows.Forms.Label pushOLbl;
		private System.Windows.Forms.Label popOLbl;
		private System.Windows.Forms.Button leftArrowBtn;
		private System.Windows.Forms.Button rightArrowBtn;
		private System.Windows.Forms.Label stackTitleLbl;
		private System.Windows.Forms.Button mainMenuBtn;
		private System.Windows.Forms.Button exitBtn;
	}
}