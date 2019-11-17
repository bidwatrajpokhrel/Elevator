namespace Elevator
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.leftDoorUp = new System.Windows.Forms.PictureBox();
			this.rightDoorUp = new System.Windows.Forms.PictureBox();
			this.rightDoorDown = new System.Windows.Forms.PictureBox();
			this.leftDoorDown = new System.Windows.Forms.PictureBox();
			this.openDoorBtn = new System.Windows.Forms.Button();
			this.closeDoorBtn = new System.Windows.Forms.Button();
			this.doorOpenTimer = new System.Windows.Forms.Timer(this.components);
			this.doorCloseTimer = new System.Windows.Forms.Timer(this.components);
			this.elevatorUnit = new System.Windows.Forms.PictureBox();
			this.goDownBtn = new System.Windows.Forms.Button();
			this.goUpBtn = new System.Windows.Forms.Button();
			this.goDownTimer = new System.Windows.Forms.Timer(this.components);
			this.goUpTimer = new System.Windows.Forms.Timer(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.callUpBtn = new System.Windows.Forms.Button();
			this.callDownBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.leftDoorUp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rightDoorUp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rightDoorDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.leftDoorDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.elevatorUnit)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// leftDoorUp
			// 
			this.leftDoorUp.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.leftDoorUp.Location = new System.Drawing.Point(200, 100);
			this.leftDoorUp.Name = "leftDoorUp";
			this.leftDoorUp.Size = new System.Drawing.Size(100, 200);
			this.leftDoorUp.TabIndex = 0;
			this.leftDoorUp.TabStop = false;
			// 
			// rightDoorUp
			// 
			this.rightDoorUp.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.rightDoorUp.Location = new System.Drawing.Point(300, 100);
			this.rightDoorUp.Name = "rightDoorUp";
			this.rightDoorUp.Size = new System.Drawing.Size(100, 200);
			this.rightDoorUp.TabIndex = 1;
			this.rightDoorUp.TabStop = false;
			// 
			// rightDoorDown
			// 
			this.rightDoorDown.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.rightDoorDown.Location = new System.Drawing.Point(300, 400);
			this.rightDoorDown.Name = "rightDoorDown";
			this.rightDoorDown.Size = new System.Drawing.Size(100, 200);
			this.rightDoorDown.TabIndex = 2;
			this.rightDoorDown.TabStop = false;
			// 
			// leftDoorDown
			// 
			this.leftDoorDown.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.leftDoorDown.Location = new System.Drawing.Point(200, 400);
			this.leftDoorDown.Name = "leftDoorDown";
			this.leftDoorDown.Size = new System.Drawing.Size(100, 200);
			this.leftDoorDown.TabIndex = 3;
			this.leftDoorDown.TabStop = false;
			// 
			// openDoorBtn
			// 
			this.openDoorBtn.Location = new System.Drawing.Point(17, 201);
			this.openDoorBtn.Name = "openDoorBtn";
			this.openDoorBtn.Size = new System.Drawing.Size(80, 30);
			this.openDoorBtn.TabIndex = 4;
			this.openDoorBtn.Text = "Open";
			this.openDoorBtn.UseVisualStyleBackColor = true;
			this.openDoorBtn.Click += new System.EventHandler(this.openDoorBtn_Click);
			// 
			// closeDoorBtn
			// 
			this.closeDoorBtn.Location = new System.Drawing.Point(120, 201);
			this.closeDoorBtn.Name = "closeDoorBtn";
			this.closeDoorBtn.Size = new System.Drawing.Size(80, 30);
			this.closeDoorBtn.TabIndex = 5;
			this.closeDoorBtn.Text = "Close";
			this.closeDoorBtn.UseVisualStyleBackColor = true;
			this.closeDoorBtn.Click += new System.EventHandler(this.closeDoorBtn_Click);
			// 
			// doorOpenTimer
			// 
			this.doorOpenTimer.Tick += new System.EventHandler(this.doorOpenTimer_Tick);
			// 
			// doorCloseTimer
			// 
			this.doorCloseTimer.Tick += new System.EventHandler(this.doorCloseTimer_Tick);
			// 
			// elevatorUnit
			// 
			this.elevatorUnit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.elevatorUnit.Location = new System.Drawing.Point(527, 100);
			this.elevatorUnit.Name = "elevatorUnit";
			this.elevatorUnit.Size = new System.Drawing.Size(32, 200);
			this.elevatorUnit.TabIndex = 7;
			this.elevatorUnit.TabStop = false;
			// 
			// goDownBtn
			// 
			this.goDownBtn.Location = new System.Drawing.Point(17, 29);
			this.goDownBtn.Name = "goDownBtn";
			this.goDownBtn.Size = new System.Drawing.Size(80, 30);
			this.goDownBtn.TabIndex = 8;
			this.goDownBtn.Text = "Go Down";
			this.goDownBtn.UseVisualStyleBackColor = true;
			this.goDownBtn.Click += new System.EventHandler(this.goDownBtn_Click);
			// 
			// goUpBtn
			// 
			this.goUpBtn.Location = new System.Drawing.Point(117, 29);
			this.goUpBtn.Name = "goUpBtn";
			this.goUpBtn.Size = new System.Drawing.Size(80, 30);
			this.goUpBtn.TabIndex = 9;
			this.goUpBtn.Text = "Go Up";
			this.goUpBtn.UseVisualStyleBackColor = true;
			this.goUpBtn.Click += new System.EventHandler(this.goUpBtn_Click);
			// 
			// goDownTimer
			// 
			this.goDownTimer.Tick += new System.EventHandler(this.goDownTimer_Tick);
			// 
			// goUpTimer
			// 
			this.goUpTimer.Tick += new System.EventHandler(this.goUpTimer_Tick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.panel1.Controls.Add(this.goDownBtn);
			this.panel1.Controls.Add(this.goUpBtn);
			this.panel1.Controls.Add(this.openDoorBtn);
			this.panel1.Controls.Add(this.closeDoorBtn);
			this.panel1.Location = new System.Drawing.Point(565, 239);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(208, 273);
			this.panel1.TabIndex = 10;
			// 
			// callUpBtn
			// 
			this.callUpBtn.Location = new System.Drawing.Point(12, 164);
			this.callUpBtn.Name = "callUpBtn";
			this.callUpBtn.Size = new System.Drawing.Size(68, 66);
			this.callUpBtn.TabIndex = 11;
			this.callUpBtn.Text = "Call Up";
			this.callUpBtn.UseVisualStyleBackColor = true;
			this.callUpBtn.Click += new System.EventHandler(this.button1_Click);
			// 
			// callDownBtn
			// 
			this.callDownBtn.Location = new System.Drawing.Point(12, 457);
			this.callDownBtn.Name = "callDownBtn";
			this.callDownBtn.Size = new System.Drawing.Size(68, 66);
			this.callDownBtn.TabIndex = 12;
			this.callDownBtn.Text = "Call Down";
			this.callDownBtn.UseVisualStyleBackColor = true;
			this.callDownBtn.Click += new System.EventHandler(this.callDownBtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1378, 693);
			this.Controls.Add(this.callDownBtn);
			this.Controls.Add(this.callUpBtn);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.elevatorUnit);
			this.Controls.Add(this.leftDoorDown);
			this.Controls.Add(this.rightDoorDown);
			this.Controls.Add(this.rightDoorUp);
			this.Controls.Add(this.leftDoorUp);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.testtxt_Load);
			((System.ComponentModel.ISupportInitialize)(this.leftDoorUp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rightDoorUp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rightDoorDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.leftDoorDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.elevatorUnit)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox leftDoorUp;
		private System.Windows.Forms.PictureBox rightDoorUp;
		private System.Windows.Forms.PictureBox rightDoorDown;
		private System.Windows.Forms.PictureBox leftDoorDown;
		private System.Windows.Forms.Button openDoorBtn;
		private System.Windows.Forms.Button closeDoorBtn;
		private System.Windows.Forms.Timer doorOpenTimer;
		private System.Windows.Forms.Timer doorCloseTimer;
		private System.Windows.Forms.PictureBox elevatorUnit;
		private System.Windows.Forms.Button goDownBtn;
		private System.Windows.Forms.Button goUpBtn;
		private System.Windows.Forms.Timer goDownTimer;
		private System.Windows.Forms.Timer goUpTimer;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button callUpBtn;
		private System.Windows.Forms.Button callDownBtn;
	}
}

