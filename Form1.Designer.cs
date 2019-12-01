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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
			this.controlPannelPicture = new System.Windows.Forms.PictureBox();
			this.controlPanelDisplay = new System.Windows.Forms.Label();
			this.callUpBtn = new System.Windows.Forms.Button();
			this.callDownBtn = new System.Windows.Forms.Button();
			this.logTable = new System.Windows.Forms.DataGridView();
			this.firstFloorDisplay = new System.Windows.Forms.Label();
			this.groundFloorDisplay = new System.Windows.Forms.Label();
			this.firstFloorPicture = new System.Windows.Forms.PictureBox();
			this.groundFloorPicture = new System.Windows.Forms.PictureBox();
			this.elevatorIndoor = new System.Windows.Forms.PictureBox();
			this.counterTimer = new System.Windows.Forms.Timer(this.components);
			this.clearLogBtn = new System.Windows.Forms.Button();
			this.emptyDatabaseBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.leftDoorUp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rightDoorUp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rightDoorDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.leftDoorDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.elevatorUnit)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.controlPannelPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.logTable)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.firstFloorPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groundFloorPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.elevatorIndoor)).BeginInit();
			this.SuspendLayout();
			// 
			// leftDoorUp
			// 
			this.leftDoorUp.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.leftDoorUp.Image = ((System.Drawing.Image)(resources.GetObject("leftDoorUp.Image")));
			this.leftDoorUp.Location = new System.Drawing.Point(200, 100);
			this.leftDoorUp.Name = "leftDoorUp";
			this.leftDoorUp.Size = new System.Drawing.Size(100, 200);
			this.leftDoorUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.leftDoorUp.TabIndex = 0;
			this.leftDoorUp.TabStop = false;
			// 
			// rightDoorUp
			// 
			this.rightDoorUp.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.rightDoorUp.Image = ((System.Drawing.Image)(resources.GetObject("rightDoorUp.Image")));
			this.rightDoorUp.Location = new System.Drawing.Point(300, 100);
			this.rightDoorUp.Name = "rightDoorUp";
			this.rightDoorUp.Size = new System.Drawing.Size(100, 200);
			this.rightDoorUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.rightDoorUp.TabIndex = 1;
			this.rightDoorUp.TabStop = false;
			// 
			// rightDoorDown
			// 
			this.rightDoorDown.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.rightDoorDown.Image = ((System.Drawing.Image)(resources.GetObject("rightDoorDown.Image")));
			this.rightDoorDown.Location = new System.Drawing.Point(300, 400);
			this.rightDoorDown.Name = "rightDoorDown";
			this.rightDoorDown.Size = new System.Drawing.Size(100, 200);
			this.rightDoorDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.rightDoorDown.TabIndex = 2;
			this.rightDoorDown.TabStop = false;
			// 
			// leftDoorDown
			// 
			this.leftDoorDown.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.leftDoorDown.Image = ((System.Drawing.Image)(resources.GetObject("leftDoorDown.Image")));
			this.leftDoorDown.Location = new System.Drawing.Point(200, 400);
			this.leftDoorDown.Name = "leftDoorDown";
			this.leftDoorDown.Size = new System.Drawing.Size(100, 200);
			this.leftDoorDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.leftDoorDown.TabIndex = 3;
			this.leftDoorDown.TabStop = false;
			// 
			// openDoorBtn
			// 
			this.openDoorBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openDoorBtn.BackgroundImage")));
			this.openDoorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.openDoorBtn.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
			this.openDoorBtn.Location = new System.Drawing.Point(17, 253);
			this.openDoorBtn.Name = "openDoorBtn";
			this.openDoorBtn.Size = new System.Drawing.Size(80, 71);
			this.openDoorBtn.TabIndex = 4;
			this.openDoorBtn.UseVisualStyleBackColor = true;
			this.openDoorBtn.Click += new System.EventHandler(this.openDoorBtn_Click);
			// 
			// closeDoorBtn
			// 
			this.closeDoorBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeDoorBtn.BackgroundImage")));
			this.closeDoorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.closeDoorBtn.Location = new System.Drawing.Point(120, 253);
			this.closeDoorBtn.Name = "closeDoorBtn";
			this.closeDoorBtn.Size = new System.Drawing.Size(80, 71);
			this.closeDoorBtn.TabIndex = 5;
			this.closeDoorBtn.UseVisualStyleBackColor = true;
			this.closeDoorBtn.Click += new System.EventHandler(this.closeDoorBtn_Click);
			// 
			// doorOpenTimer
			// 
			this.doorOpenTimer.Interval = 10;
			this.doorOpenTimer.Tick += new System.EventHandler(this.doorOpenTimer_Tick);
			// 
			// doorCloseTimer
			// 
			this.doorCloseTimer.Interval = 10;
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
			this.goDownBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("goDownBtn.BackgroundImage")));
			this.goDownBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.goDownBtn.Location = new System.Drawing.Point(17, 128);
			this.goDownBtn.Name = "goDownBtn";
			this.goDownBtn.Size = new System.Drawing.Size(80, 75);
			this.goDownBtn.TabIndex = 8;
			this.goDownBtn.UseVisualStyleBackColor = true;
			this.goDownBtn.Click += new System.EventHandler(this.goDownBtn_Click);
			// 
			// goUpBtn
			// 
			this.goUpBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("goUpBtn.BackgroundImage")));
			this.goUpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.goUpBtn.Location = new System.Drawing.Point(120, 128);
			this.goUpBtn.Name = "goUpBtn";
			this.goUpBtn.Size = new System.Drawing.Size(80, 75);
			this.goUpBtn.TabIndex = 9;
			this.goUpBtn.UseVisualStyleBackColor = true;
			this.goUpBtn.Click += new System.EventHandler(this.goUpBtn_Click);
			// 
			// goDownTimer
			// 
			this.goDownTimer.Interval = 10;
			this.goDownTimer.Tick += new System.EventHandler(this.goDownTimer_Tick);
			// 
			// goUpTimer
			// 
			this.goUpTimer.Interval = 10;
			this.goUpTimer.Tick += new System.EventHandler(this.goUpTimer_Tick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.panel1.Controls.Add(this.controlPannelPicture);
			this.panel1.Controls.Add(this.controlPanelDisplay);
			this.panel1.Controls.Add(this.goDownBtn);
			this.panel1.Controls.Add(this.goUpBtn);
			this.panel1.Controls.Add(this.openDoorBtn);
			this.panel1.Controls.Add(this.closeDoorBtn);
			this.panel1.Location = new System.Drawing.Point(565, 101);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(208, 499);
			this.panel1.TabIndex = 10;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// controlPannelPicture
			// 
			this.controlPannelPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.controlPannelPicture.Image = ((System.Drawing.Image)(resources.GetObject("controlPannelPicture.Image")));
			this.controlPannelPicture.Location = new System.Drawing.Point(76, 32);
			this.controlPannelPicture.Name = "controlPannelPicture";
			this.controlPannelPicture.Size = new System.Drawing.Size(57, 50);
			this.controlPannelPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.controlPannelPicture.TabIndex = 18;
			this.controlPannelPicture.TabStop = false;
			// 
			// controlPanelDisplay
			// 
			this.controlPanelDisplay.AutoSize = true;
			this.controlPanelDisplay.Location = new System.Drawing.Point(40, 94);
			this.controlPanelDisplay.Name = "controlPanelDisplay";
			this.controlPanelDisplay.Size = new System.Drawing.Size(133, 17);
			this.controlPanelDisplay.TabIndex = 15;
			this.controlPanelDisplay.Text = "controlPanelDisplay";
			// 
			// callUpBtn
			// 
			this.callUpBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("callUpBtn.BackgroundImage")));
			this.callUpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.callUpBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.callUpBtn.Location = new System.Drawing.Point(12, 164);
			this.callUpBtn.Name = "callUpBtn";
			this.callUpBtn.Size = new System.Drawing.Size(68, 66);
			this.callUpBtn.TabIndex = 11;
			this.callUpBtn.UseVisualStyleBackColor = true;
			this.callUpBtn.Click += new System.EventHandler(this.button1_Click);
			// 
			// callDownBtn
			// 
			this.callDownBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("callDownBtn.BackgroundImage")));
			this.callDownBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.callDownBtn.Location = new System.Drawing.Point(12, 457);
			this.callDownBtn.Name = "callDownBtn";
			this.callDownBtn.Size = new System.Drawing.Size(68, 66);
			this.callDownBtn.TabIndex = 12;
			this.callDownBtn.UseVisualStyleBackColor = true;
			this.callDownBtn.Click += new System.EventHandler(this.callDownBtn_Click);
			// 
			// logTable
			// 
			this.logTable.AllowUserToAddRows = false;
			this.logTable.AllowUserToDeleteRows = false;
			this.logTable.AllowUserToResizeRows = false;
			this.logTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.logTable.Location = new System.Drawing.Point(884, 101);
			this.logTable.Name = "logTable";
			this.logTable.RowHeadersWidth = 51;
			this.logTable.RowTemplate.Height = 24;
			this.logTable.Size = new System.Drawing.Size(470, 500);
			this.logTable.TabIndex = 13;
			// 
			// firstFloorDisplay
			// 
			this.firstFloorDisplay.AutoSize = true;
			this.firstFloorDisplay.Location = new System.Drawing.Point(248, 69);
			this.firstFloorDisplay.Name = "firstFloorDisplay";
			this.firstFloorDisplay.Size = new System.Drawing.Size(0, 17);
			this.firstFloorDisplay.TabIndex = 14;
			// 
			// groundFloorDisplay
			// 
			this.groundFloorDisplay.AutoSize = true;
			this.groundFloorDisplay.Location = new System.Drawing.Point(238, 380);
			this.groundFloorDisplay.Name = "groundFloorDisplay";
			this.groundFloorDisplay.Size = new System.Drawing.Size(0, 17);
			this.groundFloorDisplay.TabIndex = 15;
			// 
			// firstFloorPicture
			// 
			this.firstFloorPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.firstFloorPicture.Image = ((System.Drawing.Image)(resources.GetObject("firstFloorPicture.Image")));
			this.firstFloorPicture.Location = new System.Drawing.Point(29, 122);
			this.firstFloorPicture.Name = "firstFloorPicture";
			this.firstFloorPicture.Size = new System.Drawing.Size(38, 36);
			this.firstFloorPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.firstFloorPicture.TabIndex = 16;
			this.firstFloorPicture.TabStop = false;
			this.firstFloorPicture.Click += new System.EventHandler(this.firstFloorPicture_Click);
			// 
			// groundFloorPicture
			// 
			this.groundFloorPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.groundFloorPicture.Image = ((System.Drawing.Image)(resources.GetObject("groundFloorPicture.Image")));
			this.groundFloorPicture.Location = new System.Drawing.Point(29, 415);
			this.groundFloorPicture.Name = "groundFloorPicture";
			this.groundFloorPicture.Size = new System.Drawing.Size(38, 36);
			this.groundFloorPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.groundFloorPicture.TabIndex = 17;
			this.groundFloorPicture.TabStop = false;
			// 
			// elevatorIndoor
			// 
			this.elevatorIndoor.Image = ((System.Drawing.Image)(resources.GetObject("elevatorIndoor.Image")));
			this.elevatorIndoor.Location = new System.Drawing.Point(201, 101);
			this.elevatorIndoor.Name = "elevatorIndoor";
			this.elevatorIndoor.Size = new System.Drawing.Size(200, 200);
			this.elevatorIndoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.elevatorIndoor.TabIndex = 18;
			this.elevatorIndoor.TabStop = false;
			// 
			// counterTimer
			// 
			this.counterTimer.Interval = 10;
			this.counterTimer.Tick += new System.EventHandler(this.counterTimer_Tick);
			// 
			// clearLogBtn
			// 
			this.clearLogBtn.Location = new System.Drawing.Point(884, 607);
			this.clearLogBtn.Name = "clearLogBtn";
			this.clearLogBtn.Size = new System.Drawing.Size(100, 29);
			this.clearLogBtn.TabIndex = 19;
			this.clearLogBtn.Text = "ClearLog";
			this.clearLogBtn.UseVisualStyleBackColor = true;
			this.clearLogBtn.Click += new System.EventHandler(this.clearLogBtn_Click);
			// 
			// emptyDatabaseBtn
			// 
			this.emptyDatabaseBtn.BackColor = System.Drawing.Color.Red;
			this.emptyDatabaseBtn.Location = new System.Drawing.Point(1224, 607);
			this.emptyDatabaseBtn.Name = "emptyDatabaseBtn";
			this.emptyDatabaseBtn.Size = new System.Drawing.Size(130, 29);
			this.emptyDatabaseBtn.TabIndex = 20;
			this.emptyDatabaseBtn.Text = "Clear Database";
			this.emptyDatabaseBtn.UseVisualStyleBackColor = false;
			this.emptyDatabaseBtn.Click += new System.EventHandler(this.emptyDatabaseBtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.ClientSize = new System.Drawing.Size(1378, 693);
			this.Controls.Add(this.emptyDatabaseBtn);
			this.Controls.Add(this.clearLogBtn);
			this.Controls.Add(this.groundFloorPicture);
			this.Controls.Add(this.firstFloorPicture);
			this.Controls.Add(this.groundFloorDisplay);
			this.Controls.Add(this.firstFloorDisplay);
			this.Controls.Add(this.logTable);
			this.Controls.Add(this.callDownBtn);
			this.Controls.Add(this.callUpBtn);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.elevatorUnit);
			this.Controls.Add(this.leftDoorDown);
			this.Controls.Add(this.rightDoorDown);
			this.Controls.Add(this.rightDoorUp);
			this.Controls.Add(this.leftDoorUp);
			this.Controls.Add(this.elevatorIndoor);
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
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.controlPannelPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.logTable)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.firstFloorPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groundFloorPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.elevatorIndoor)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

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
		private System.Windows.Forms.DataGridView logTable;
		private System.Windows.Forms.Label firstFloorDisplay;
		private System.Windows.Forms.Label groundFloorDisplay;
		private System.Windows.Forms.Label controlPanelDisplay;
		private System.Windows.Forms.PictureBox controlPannelPicture;
		private System.Windows.Forms.PictureBox firstFloorPicture;
		private System.Windows.Forms.PictureBox groundFloorPicture;
		private System.Windows.Forms.PictureBox elevatorIndoor;
		private System.Windows.Forms.Timer counterTimer;
		private System.Windows.Forms.Button clearLogBtn;
		private System.Windows.Forms.Button emptyDatabaseBtn;
	}
}

