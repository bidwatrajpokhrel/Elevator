namespace Elevator
{
	partial class ElevatorForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElevatorForm));
			this.doorOpenTimer = new System.Windows.Forms.Timer(this.components);
			this.doorCloseTimer = new System.Windows.Forms.Timer(this.components);
			this.goDownTimer = new System.Windows.Forms.Timer(this.components);
			this.goUpTimer = new System.Windows.Forms.Timer(this.components);
			this.controlPanel = new System.Windows.Forms.Panel();
			this.controlPannelPicture = new System.Windows.Forms.PictureBox();
			this.goDownBtn = new System.Windows.Forms.Button();
			this.goUpBtn = new System.Windows.Forms.Button();
			this.openDoorBtn = new System.Windows.Forms.Button();
			this.closeDoorBtn = new System.Windows.Forms.Button();
			this.logTable = new System.Windows.Forms.DataGridView();
			this.firstFloorDisplay = new System.Windows.Forms.Label();
			this.groundFloorDisplay = new System.Windows.Forms.Label();
			this.counterTimer = new System.Windows.Forms.Timer(this.components);
			this.clearLogBtn = new System.Windows.Forms.Button();
			this.emptyDatabaseBtn = new System.Windows.Forms.Button();
			this.retriveLogBtn = new System.Windows.Forms.Button();
			this.updateDatabaseBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.updateDatabseBackgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.deleteDatabaseBackgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.liftInteriorPic1 = new System.Windows.Forms.PictureBox();
			this.leftDoorDown = new System.Windows.Forms.PictureBox();
			this.rightDoorDown = new System.Windows.Forms.PictureBox();
			this.groundFloorPicture = new System.Windows.Forms.PictureBox();
			this.firstFloorPicture = new System.Windows.Forms.PictureBox();
			this.callDownBtn = new System.Windows.Forms.Button();
			this.callUpBtn = new System.Windows.Forms.Button();
			this.elevatorUnit = new System.Windows.Forms.PictureBox();
			this.leftDoorUp = new System.Windows.Forms.PictureBox();
			this.elevatorIndoor = new System.Windows.Forms.PictureBox();
			this.rightDoorUp = new System.Windows.Forms.PictureBox();
			this.liftInteriorPic2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.controlPanelLbl = new System.Windows.Forms.Label();
			this.controlPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.controlPannelPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.logTable)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.liftInteriorPic1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.leftDoorDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rightDoorDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groundFloorPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.firstFloorPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.elevatorUnit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.leftDoorUp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.elevatorIndoor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rightDoorUp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.liftInteriorPic2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
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
			// controlPanel
			// 
			this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.controlPanel.Controls.Add(this.controlPanelLbl);
			this.controlPanel.Controls.Add(this.controlPannelPicture);
			this.controlPanel.Controls.Add(this.goDownBtn);
			this.controlPanel.Controls.Add(this.goUpBtn);
			this.controlPanel.Controls.Add(this.openDoorBtn);
			this.controlPanel.Controls.Add(this.closeDoorBtn);
			this.controlPanel.Location = new System.Drawing.Point(607, 101);
			this.controlPanel.Name = "controlPanel";
			this.controlPanel.Size = new System.Drawing.Size(208, 499);
			this.controlPanel.TabIndex = 10;
			// 
			// controlPannelPicture
			// 
			this.controlPannelPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.controlPannelPicture.Image = ((System.Drawing.Image)(resources.GetObject("controlPannelPicture.Image")));
			this.controlPannelPicture.Location = new System.Drawing.Point(17, 44);
			this.controlPannelPicture.Name = "controlPannelPicture";
			this.controlPannelPicture.Size = new System.Drawing.Size(175, 171);
			this.controlPannelPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.controlPannelPicture.TabIndex = 18;
			this.controlPannelPicture.TabStop = false;
			// 
			// goDownBtn
			// 
			this.goDownBtn.BackgroundImage = global::Elevator.Properties.Resources.Groundfloorbutton;
			this.goDownBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.goDownBtn.Location = new System.Drawing.Point(17, 221);
			this.goDownBtn.Name = "goDownBtn";
			this.goDownBtn.Size = new System.Drawing.Size(80, 75);
			this.goDownBtn.TabIndex = 8;
			this.goDownBtn.UseVisualStyleBackColor = true;
			this.goDownBtn.Click += new System.EventHandler(this.goDownBtn_Click);
			// 
			// goUpBtn
			// 
			this.goUpBtn.BackgroundImage = global::Elevator.Properties.Resources.firstfloorbutton;
			this.goUpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.goUpBtn.Location = new System.Drawing.Point(112, 221);
			this.goUpBtn.Name = "goUpBtn";
			this.goUpBtn.Size = new System.Drawing.Size(80, 75);
			this.goUpBtn.TabIndex = 9;
			this.goUpBtn.UseVisualStyleBackColor = true;
			this.goUpBtn.Click += new System.EventHandler(this.goUpBtn_Click);
			// 
			// openDoorBtn
			// 
			this.openDoorBtn.BackgroundImage = global::Elevator.Properties.Resources.opendoor;
			this.openDoorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.openDoorBtn.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
			this.openDoorBtn.Location = new System.Drawing.Point(17, 356);
			this.openDoorBtn.Name = "openDoorBtn";
			this.openDoorBtn.Size = new System.Drawing.Size(80, 71);
			this.openDoorBtn.TabIndex = 4;
			this.openDoorBtn.UseVisualStyleBackColor = true;
			this.openDoorBtn.Click += new System.EventHandler(this.openDoorBtn_Click);
			// 
			// closeDoorBtn
			// 
			this.closeDoorBtn.BackgroundImage = global::Elevator.Properties.Resources.closedoor;
			this.closeDoorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.closeDoorBtn.Location = new System.Drawing.Point(112, 354);
			this.closeDoorBtn.Name = "closeDoorBtn";
			this.closeDoorBtn.Size = new System.Drawing.Size(80, 71);
			this.closeDoorBtn.TabIndex = 5;
			this.closeDoorBtn.UseVisualStyleBackColor = true;
			this.closeDoorBtn.Click += new System.EventHandler(this.closeDoorBtn_Click);
			// 
			// logTable
			// 
			this.logTable.AllowUserToAddRows = false;
			this.logTable.AllowUserToDeleteRows = false;
			this.logTable.AllowUserToResizeRows = false;
			this.logTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.logTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.logTable.Location = new System.Drawing.Point(933, 101);
			this.logTable.Name = "logTable";
			this.logTable.RowHeadersVisible = false;
			this.logTable.RowHeadersWidth = 55;
			this.logTable.RowTemplate.Height = 24;
			this.logTable.Size = new System.Drawing.Size(398, 500);
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
			// counterTimer
			// 
			this.counterTimer.Interval = 10;
			this.counterTimer.Tick += new System.EventHandler(this.counterTimer_Tick);
			// 
			// clearLogBtn
			// 
			this.clearLogBtn.Location = new System.Drawing.Point(1149, 607);
			this.clearLogBtn.Name = "clearLogBtn";
			this.clearLogBtn.Size = new System.Drawing.Size(135, 29);
			this.clearLogBtn.TabIndex = 19;
			this.clearLogBtn.Text = "ClearLog";
			this.clearLogBtn.UseVisualStyleBackColor = true;
			this.clearLogBtn.Click += new System.EventHandler(this.clearLogBtn_Click);
			// 
			// emptyDatabaseBtn
			// 
			this.emptyDatabaseBtn.BackColor = System.Drawing.Color.Red;
			this.emptyDatabaseBtn.Location = new System.Drawing.Point(1149, 642);
			this.emptyDatabaseBtn.Name = "emptyDatabaseBtn";
			this.emptyDatabaseBtn.Size = new System.Drawing.Size(135, 29);
			this.emptyDatabaseBtn.TabIndex = 20;
			this.emptyDatabaseBtn.Text = "Clear Database";
			this.emptyDatabaseBtn.UseVisualStyleBackColor = false;
			this.emptyDatabaseBtn.Click += new System.EventHandler(this.emptyDatabaseBtn_Click);
			// 
			// retriveLogBtn
			// 
			this.retriveLogBtn.Location = new System.Drawing.Point(959, 607);
			this.retriveLogBtn.Name = "retriveLogBtn";
			this.retriveLogBtn.Size = new System.Drawing.Size(130, 29);
			this.retriveLogBtn.TabIndex = 21;
			this.retriveLogBtn.Text = "Retrive Log";
			this.retriveLogBtn.UseVisualStyleBackColor = true;
			this.retriveLogBtn.Click += new System.EventHandler(this.retriveLogBtn_Click);
			// 
			// updateDatabaseBtn
			// 
			this.updateDatabaseBtn.BackColor = System.Drawing.Color.Cyan;
			this.updateDatabaseBtn.Location = new System.Drawing.Point(954, 642);
			this.updateDatabaseBtn.Name = "updateDatabaseBtn";
			this.updateDatabaseBtn.Size = new System.Drawing.Size(135, 29);
			this.updateDatabaseBtn.TabIndex = 22;
			this.updateDatabaseBtn.Text = "Update Database";
			this.updateDatabaseBtn.UseVisualStyleBackColor = false;
			this.updateDatabaseBtn.Click += new System.EventHandler(this.updateDatabaseBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(1072, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 27);
			this.label1.TabIndex = 23;
			this.label1.Text = "Log Table";
			// 
			// updateDatabseBackgroundWorker
			// 
			this.updateDatabseBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.updateDatabseBackgroundWorker_DoWork);
			// 
			// deleteDatabaseBackgroundWorker
			// 
			this.deleteDatabaseBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.deleteDatabaseBackgroundWorker_DoWork);
			// 
			// liftInteriorPic1
			// 
			this.liftInteriorPic1.BackgroundImage = global::Elevator.Properties.Resources.liftInterior;
			this.liftInteriorPic1.Location = new System.Drawing.Point(200, 98);
			this.liftInteriorPic1.Name = "liftInteriorPic1";
			this.liftInteriorPic1.Size = new System.Drawing.Size(200, 203);
			this.liftInteriorPic1.TabIndex = 24;
			this.liftInteriorPic1.TabStop = false;
			// 
			// leftDoorDown
			// 
			this.leftDoorDown.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.leftDoorDown.Image = global::Elevator.Properties.Resources.download;
			this.leftDoorDown.Location = new System.Drawing.Point(200, 400);
			this.leftDoorDown.Name = "leftDoorDown";
			this.leftDoorDown.Size = new System.Drawing.Size(100, 200);
			this.leftDoorDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.leftDoorDown.TabIndex = 3;
			this.leftDoorDown.TabStop = false;
			// 
			// rightDoorDown
			// 
			this.rightDoorDown.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.rightDoorDown.Image = global::Elevator.Properties.Resources.download;
			this.rightDoorDown.Location = new System.Drawing.Point(300, 400);
			this.rightDoorDown.Name = "rightDoorDown";
			this.rightDoorDown.Size = new System.Drawing.Size(100, 200);
			this.rightDoorDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.rightDoorDown.TabIndex = 2;
			this.rightDoorDown.TabStop = false;
			// 
			// groundFloorPicture
			// 
			this.groundFloorPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.groundFloorPicture.Image = ((System.Drawing.Image)(resources.GetObject("groundFloorPicture.Image")));
			this.groundFloorPicture.Location = new System.Drawing.Point(12, 390);
			this.groundFloorPicture.Name = "groundFloorPicture";
			this.groundFloorPicture.Size = new System.Drawing.Size(68, 61);
			this.groundFloorPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.groundFloorPicture.TabIndex = 17;
			this.groundFloorPicture.TabStop = false;
			// 
			// firstFloorPicture
			// 
			this.firstFloorPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.firstFloorPicture.Image = ((System.Drawing.Image)(resources.GetObject("firstFloorPicture.Image")));
			this.firstFloorPicture.Location = new System.Drawing.Point(12, 97);
			this.firstFloorPicture.Name = "firstFloorPicture";
			this.firstFloorPicture.Size = new System.Drawing.Size(68, 61);
			this.firstFloorPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.firstFloorPicture.TabIndex = 16;
			this.firstFloorPicture.TabStop = false;
			// 
			// callDownBtn
			// 
			this.callDownBtn.BackgroundImage = global::Elevator.Properties.Resources.calldown;
			this.callDownBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.callDownBtn.Location = new System.Drawing.Point(12, 457);
			this.callDownBtn.Name = "callDownBtn";
			this.callDownBtn.Size = new System.Drawing.Size(68, 66);
			this.callDownBtn.TabIndex = 12;
			this.callDownBtn.UseVisualStyleBackColor = true;
			this.callDownBtn.Click += new System.EventHandler(this.callDownBtn_Click);
			// 
			// callUpBtn
			// 
			this.callUpBtn.BackgroundImage = global::Elevator.Properties.Resources.callup;
			this.callUpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.callUpBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.callUpBtn.Location = new System.Drawing.Point(12, 164);
			this.callUpBtn.Name = "callUpBtn";
			this.callUpBtn.Size = new System.Drawing.Size(68, 66);
			this.callUpBtn.TabIndex = 11;
			this.callUpBtn.UseVisualStyleBackColor = true;
			this.callUpBtn.Click += new System.EventHandler(this.button1_Click);
			// 
			// elevatorUnit
			// 
			this.elevatorUnit.BackColor = System.Drawing.Color.Gray;
			this.elevatorUnit.Location = new System.Drawing.Point(541, 100);
			this.elevatorUnit.Name = "elevatorUnit";
			this.elevatorUnit.Size = new System.Drawing.Size(60, 200);
			this.elevatorUnit.TabIndex = 7;
			this.elevatorUnit.TabStop = false;
			// 
			// leftDoorUp
			// 
			this.leftDoorUp.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.leftDoorUp.Image = global::Elevator.Properties.Resources.download;
			this.leftDoorUp.Location = new System.Drawing.Point(200, 100);
			this.leftDoorUp.Name = "leftDoorUp";
			this.leftDoorUp.Size = new System.Drawing.Size(100, 200);
			this.leftDoorUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.leftDoorUp.TabIndex = 0;
			this.leftDoorUp.TabStop = false;
			// 
			// elevatorIndoor
			// 
			this.elevatorIndoor.Image = global::Elevator.Properties.Resources.liftBox;
			this.elevatorIndoor.Location = new System.Drawing.Point(201, 101);
			this.elevatorIndoor.Name = "elevatorIndoor";
			this.elevatorIndoor.Size = new System.Drawing.Size(200, 200);
			this.elevatorIndoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.elevatorIndoor.TabIndex = 18;
			this.elevatorIndoor.TabStop = false;
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
			// liftInteriorPic2
			// 
			this.liftInteriorPic2.BackgroundImage = global::Elevator.Properties.Resources.liftInterior;
			this.liftInteriorPic2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.liftInteriorPic2.Location = new System.Drawing.Point(201, 400);
			this.liftInteriorPic2.Name = "liftInteriorPic2";
			this.liftInteriorPic2.Size = new System.Drawing.Size(199, 200);
			this.liftInteriorPic2.TabIndex = 25;
			this.liftInteriorPic2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::Elevator.Properties.Resources.backgroung;
			this.pictureBox1.Location = new System.Drawing.Point(1, -6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(851, 704);
			this.pictureBox1.TabIndex = 26;
			this.pictureBox1.TabStop = false;
			// 
			// controlPanelLbl
			// 
			this.controlPanelLbl.AutoSize = true;
			this.controlPanelLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.controlPanelLbl.Location = new System.Drawing.Point(4, 9);
			this.controlPanelLbl.Name = "controlPanelLbl";
			this.controlPanelLbl.Size = new System.Drawing.Size(201, 32);
			this.controlPanelLbl.TabIndex = 19;
			this.controlPanelLbl.Text = "Control Panel";
			// 
			// ElevatorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.ClientSize = new System.Drawing.Size(1378, 693);
			this.Controls.Add(this.rightDoorDown);
			this.Controls.Add(this.leftDoorDown);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.updateDatabaseBtn);
			this.Controls.Add(this.retriveLogBtn);
			this.Controls.Add(this.emptyDatabaseBtn);
			this.Controls.Add(this.clearLogBtn);
			this.Controls.Add(this.groundFloorPicture);
			this.Controls.Add(this.firstFloorPicture);
			this.Controls.Add(this.groundFloorDisplay);
			this.Controls.Add(this.firstFloorDisplay);
			this.Controls.Add(this.logTable);
			this.Controls.Add(this.callDownBtn);
			this.Controls.Add(this.callUpBtn);
			this.Controls.Add(this.controlPanel);
			this.Controls.Add(this.elevatorUnit);
			this.Controls.Add(this.leftDoorUp);
			this.Controls.Add(this.rightDoorUp);
			this.Controls.Add(this.liftInteriorPic1);
			this.Controls.Add(this.liftInteriorPic2);
			this.Controls.Add(this.elevatorIndoor);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "ElevatorForm";
			this.Text = "Elevator";
			this.Load += new System.EventHandler(this.testtxt_Load);
			this.controlPanel.ResumeLayout(false);
			this.controlPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.controlPannelPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.logTable)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.liftInteriorPic1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.leftDoorDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rightDoorDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groundFloorPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.firstFloorPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.elevatorUnit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.leftDoorUp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.elevatorIndoor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rightDoorUp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.liftInteriorPic2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
		private System.Windows.Forms.Panel controlPanel;
		private System.Windows.Forms.Button callUpBtn;
		private System.Windows.Forms.Button callDownBtn;
		private System.Windows.Forms.DataGridView logTable;
		private System.Windows.Forms.Label firstFloorDisplay;
		private System.Windows.Forms.Label groundFloorDisplay;
		private System.Windows.Forms.PictureBox controlPannelPicture;
		private System.Windows.Forms.PictureBox firstFloorPicture;
		private System.Windows.Forms.PictureBox groundFloorPicture;
		private System.Windows.Forms.PictureBox elevatorIndoor;
		private System.Windows.Forms.Timer counterTimer;
		private System.Windows.Forms.Button clearLogBtn;
		private System.Windows.Forms.Button emptyDatabaseBtn;
		private System.Windows.Forms.Button retriveLogBtn;
		private System.Windows.Forms.Button updateDatabaseBtn;
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.BackgroundWorker updateDatabseBackgroundWorker;
		private System.ComponentModel.BackgroundWorker deleteDatabaseBackgroundWorker;
		private System.Windows.Forms.PictureBox liftInteriorPic1;
		private System.Windows.Forms.PictureBox liftInteriorPic2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label controlPanelLbl;
	}
}

