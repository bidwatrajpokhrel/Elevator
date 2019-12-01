using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Elevator
{
	public partial class Form1 : Form
	{
		DatabaseCommands datacom = new DatabaseCommands();

		Door doorObj = new Door();

		ElevatorUnit elevObj = new ElevatorUnit();

		//coordinate variables
		int xLeftDoorOpen = 86;
		int xLeftDoorClosed = 251;
		int xRightDoorOpen = 289;
		int xRightDoorClosed = 226;
		int yElevatorUp = 82;
		int yElevatorDown = 324;

		//function variables
		public bool goUpBool = false;
		public bool goDownBool = false;
		public bool doorClosedBool = true;

		//counter variables
		public int counter = 0;

		public Form1()
		{
			InitializeComponent();
		}

		
		private void doorOpen()
		{
			//doorObj.doorOpen(rightDoorUp, leftDoorUp, rightDoorDown, leftDoorDown, elevatorUnit, doorOpenTimer, doorCloseTimer);

			if (elevatorUnit.Top <= yElevatorUp)
			{
				if (rightDoorUp.Left <= xRightDoorOpen && leftDoorUp.Left >= xLeftDoorOpen)
				{
					/*
					leftDoorUp.Left -= 1;
					rightDoorUp.Left += 1;
					*/
					doorObj.doorOpenUp(rightDoorUp, leftDoorUp);
					disableButtons();

				}
				else
				{
					datacom.insertActivity("Door Opened at First Floor");
					updateDatalog();
					doorOpenTimer.Enabled = false;
					doorClosedBool = false;
					enableButtons();
					counter = 0;
					counterTimer.Enabled = true;
				}
			}
			else
			{
				if (rightDoorDown.Left <= xRightDoorOpen && leftDoorDown.Left >= xLeftDoorOpen)
				{
					/*
					leftDoorDown.Left -= 1;
					rightDoorDown.Left += 1;
					*/
					doorObj.doorOpenDown(rightDoorDown, leftDoorDown);
					disableButtons();
				}
				else
				{
					datacom.insertActivity("Door Opened at Ground Floor");
					updateDatalog();
					doorClosedBool = false;
					doorOpenTimer.Enabled = false;
					enableButtons();
					counter = 0;
					counterTimer.Enabled = true;
				}
			}
		}

		private void doorClose()
		{
			if (elevatorUnit.Top >= yElevatorDown)
			{
				if (rightDoorDown.Left >= xRightDoorClosed && leftDoorDown.Left <= xLeftDoorClosed)
				{
					/*
					leftDoorDown.Left += 1;
					rightDoorDown.Left -= 1;
					*/
					doorObj.doorCloseDown(rightDoorDown, leftDoorDown);
					disableButtons();
				}
				else
				{
					datacom.insertActivity("Door Closed at Ground Floor");
					updateDatalog();
					doorCloseTimer.Enabled = false;
					doorClosedBool = true;
					checkDoorClosed();
					enableButtons();
				}
			}
			else
			{
				if (rightDoorUp.Left >= xRightDoorClosed && leftDoorUp.Left <= xLeftDoorClosed)
				{
					/*
					leftDoorUp.Left += 1;
					rightDoorUp.Left -= 1;
					*/
					doorObj.doorCloseUp(rightDoorUp, leftDoorUp);
					disableButtons();
				}
				else
				{
					datacom.insertActivity("Door Closed at First Floor");
					updateDatalog();
					doorCloseTimer.Enabled = false;
					doorClosedBool = true;
					checkDoorClosed();
					enableButtons();
				}
			}
		}

		private void elevatorUp()
		{
			if (elevatorUnit.Top >= yElevatorUp)
			{
				/*
				elevatorUnit.Top -= 1;
				elevatorIndoor.Top -= 1;
				*/
				elevObj.elevatorUp(elevatorUnit, elevatorIndoor);
				firstFloorDisplay.Text = "GOING UP";
				groundFloorDisplay.Text = "GOING UP";
				controlPanelDisplay.Text = "GOING UP";
				firstFloorPicture.Image = Elevator.Properties.Resources.up;
				groundFloorPicture.Image = Elevator.Properties.Resources.up;
				controlPannelPicture.Image = Elevator.Properties.Resources.up;
				disableButtons();

			}
			else
			{
				datacom.insertActivity("Elevator at First Floor");
				updateDatalog();
				goUpBool = false;
				goDownBool = false;
				goUpTimer.Enabled = false;
				doorOpenTimer.Enabled = true;
				firstFloorDisplay.Text = "FIRST FLOOR";
				groundFloorDisplay.Text = "FIRST FLOOR";
				controlPanelDisplay.Text = "FIRST FLOOR";
				firstFloorPicture.Image = Elevator.Properties.Resources.one;
				groundFloorPicture.Image = Elevator.Properties.Resources.one;
				controlPannelPicture.Image = Elevator.Properties.Resources.one;
				enableButtons();
			}
		}

		private void elevatorDown()
		{
			if (elevatorUnit.Top <= yElevatorDown)
			{
				/*
				elevatorUnit.Top += 1;
				elevatorIndoor.Top += 1;
				*/
				elevObj.elevatorDown(elevatorUnit, elevatorIndoor);
				firstFloorDisplay.Text = "GOING DOWN";
				groundFloorDisplay.Text = "GOING DOWN";
				controlPanelDisplay.Text = "GOING DOWN";
				firstFloorPicture.Image = Elevator.Properties.Resources.down;
				groundFloorPicture.Image = Elevator.Properties.Resources.down;
				controlPannelPicture.Image = Elevator.Properties.Resources.down;
				disableButtons();
			}
			else
			{
				datacom.insertActivity("Elevator at Ground Floor");
				updateDatalog();
				goDownBool = false;
				goUpBool = false;
				goDownTimer.Enabled = false;
				doorOpenTimer.Enabled = true;
				firstFloorDisplay.Text = "GROUND FLOOR";
				groundFloorDisplay.Text = "GROND FLOOR";
				controlPanelDisplay.Text = "GROUND FLOOR";
				firstFloorPicture.Image = Elevator.Properties.Resources.G;
				groundFloorPicture.Image = Elevator.Properties.Resources.G;
				controlPannelPicture.Image = Elevator.Properties.Resources.G;
				enableButtons();

			}
		}

		private void checkDoorClosed()
		{
			if (!doorClosedBool)
			{
				doorCloseTimer.Enabled = true;
			}
			else
			{
				if (goUpBool)
				{
					goUpTimer.Enabled = true;
				}
				else if (goDownBool)
				{
					goDownTimer.Enabled = true;
				}
			}
		}

		private void checkUpDown()
		{
			if (goDownBool)
			{
				goDownTimer.Enabled = true;
			}
			else
			{
				goUpTimer.Enabled = true;
			}
		}

		private void openDoorBtn_Click(object sender, EventArgs e)
		{
			doorOpenTimer.Enabled = true;
		}

		private void doorOpenTimer_Tick(object sender, EventArgs e)
		{
			doorOpen();
		}

		private void closeDoorBtn_Click(object sender, EventArgs e)
		{
			doorCloseTimer.Enabled = true;
		}

		private void doorCloseTimer_Tick(object sender, EventArgs e)
		{
			doorClose();
		}

		private void testtxt_Load(object sender, EventArgs e)
		{
			DatabaseConnection.databaseConnectionFn();
		}

		
		private void goDownBtn_Click(object sender, EventArgs e)
		{
			goDownBool = true;
			checkDoorClosed();
		}

		private void goDownTimer_Tick(object sender, EventArgs e)
		{
			elevatorDown();
		}

		private void goUpBtn_Click(object sender, EventArgs e)
		{
			goUpBool = true;
			checkDoorClosed();
		}

		private void goUpTimer_Tick(object sender, EventArgs e)
		{
			
			elevatorUp();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			goUpBool = true;
			checkDoorClosed();
		}

		private void callDownBtn_Click(object sender, EventArgs e)
		{
			goDownBool = true;
			checkDoorClosed();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void firstFloorPicture_Click(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void counterTimer_Tick(object sender, EventArgs e)
		{
			counter++;
			if (counter >= 400)
			{
				counter = 0;
				doorCloseTimer.Enabled = true;
				counterTimer.Enabled = false;
			}
		}

		public void disableButtons()
		{
			goUpBtn.Enabled = false;
			goDownBtn.Enabled = false;
			openDoorBtn.Enabled = false;
			closeDoorBtn.Enabled = false;
			callDownBtn.Enabled = false;
			callUpBtn.Enabled = false;
		}

		public void enableButtons()
		{
			goUpBtn.Enabled = true;
			goDownBtn.Enabled = true;
			openDoorBtn.Enabled = true;
			closeDoorBtn.Enabled = true;
			callDownBtn.Enabled = true;
			callUpBtn.Enabled = true;
		}



		public void updateDatalog()
		{
			logTable.DataSource = datacom.updateLog().DefaultView;
		}

		public void clearLog()
		{
			logTable.DataSource = null;
		}

		public void emptyDatabase()
		{
			logTable.DataSource = null;
			datacom.deleteRecords();
		}

		private void clearLogBtn_Click(object sender, EventArgs e)
		{
			clearLog();
		}

		private void emptyDatabaseBtn_Click(object sender, EventArgs e)
		{
			emptyDatabase();
		}
	}
}
