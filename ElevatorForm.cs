using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Elevator
{
	public partial class ElevatorForm : Form
	{
		//object for database commands, used for database related functons
		DatabaseCommands datacom = new DatabaseCommands();

		//objects for the door and elevator components
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

		public ElevatorForm()
		{
			InitializeComponent();
		}

		//function to open the doors of the elevator
		private void doorOpen()
		{
			counterTimer.Enabled = false;
			counter = 0;
			if (elevatorUnit.Top <= yElevatorUp) //elevator on first floor
			{
				if (rightDoorUp.Left <= xRightDoorOpen && leftDoorUp.Left >= xLeftDoorOpen)
				{
					doorObj.doorOpenUp(rightDoorUp, leftDoorUp);
					disableButtons();

				}
				else
				{
					datacom.CollectData("Door Opened at First Floor");
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
					doorObj.doorOpenDown(rightDoorDown, leftDoorDown);
					disableButtons();
				}
				else
				{
					datacom.CollectData("Door Opened at Ground Floor");
					doorClosedBool = false;
					doorOpenTimer.Enabled = false;
					enableButtons();
					counter = 0;
					counterTimer.Enabled = true;
				}
			}
		}

		//function to close the doors of the elevator
		private void doorClose()
		{
			counterTimer.Enabled = false;
			counter = 0;
			if (elevatorUnit.Top >= yElevatorDown) //if elevator on first floor
			{
				if (rightDoorDown.Left >= xRightDoorClosed && leftDoorDown.Left <= xLeftDoorClosed)
				{
					doorObj.doorCloseDown(rightDoorDown, leftDoorDown);
					disableButtons();
				}
				else
				{
					datacom.CollectData("Door Closed at Ground Floor");
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
					doorObj.doorCloseUp(rightDoorUp, leftDoorUp);
					disableButtons();
				}
				else
				{
					datacom.CollectData("Door Closed at First Floor");
					doorCloseTimer.Enabled = false;
					doorClosedBool = true;
					checkDoorClosed();
					enableButtons();
				}
			}
		}

		//function to move elevator up
		private void elevatorUp()
		{
			counterTimer.Enabled = false;
			counter = 0;
			if (elevatorUnit.Top >= yElevatorUp)
			{
				elevObj.elevatorUp(elevatorUnit, elevatorIndoor);
				firstFloorDisplay.Text = "GOING UP";
				groundFloorDisplay.Text = "GOING UP";
				firstFloorPicture.Image = Elevator.Properties.Resources.up;
				groundFloorPicture.Image = Elevator.Properties.Resources.up;
				controlPannelPicture.Image = Elevator.Properties.Resources.up;
				disableButtons();

			}
			else
			{
				datacom.CollectData("Elevator at First Floor");
				goUpBool = false;
				goDownBool = false;
				goUpTimer.Enabled = false;
				doorOpenTimer.Enabled = true;
				firstFloorDisplay.Text = "FIRST FLOOR";
				groundFloorDisplay.Text = "FIRST FLOOR";
				firstFloorPicture.Image = Elevator.Properties.Resources.one;
				groundFloorPicture.Image = Elevator.Properties.Resources.one;
				controlPannelPicture.Image = Elevator.Properties.Resources.one;
				enableButtons();
			}
		}

		//function to move the elevator down
		private void elevatorDown()
		{
			counterTimer.Enabled = false;
			counter = 0;
			if (elevatorUnit.Top <= yElevatorDown)
			{
				elevObj.elevatorDown(elevatorUnit, elevatorIndoor);
				firstFloorDisplay.Text = "GOING DOWN";
				groundFloorDisplay.Text = "GOING DOWN";
				firstFloorPicture.Image = Elevator.Properties.Resources.down;
				groundFloorPicture.Image = Elevator.Properties.Resources.down;
				controlPannelPicture.Image = Elevator.Properties.Resources.down;
				disableButtons();
			}
			else
			{
				datacom.CollectData("Elevator at Ground Floor");
				goDownBool = false;
				goUpBool = false;
				goDownTimer.Enabled = false;
				doorOpenTimer.Enabled = true;
				firstFloorDisplay.Text = "GROUND FLOOR";
				groundFloorDisplay.Text = "GROND FLOOR";
				firstFloorPicture.Image = Elevator.Properties.Resources.G;
				groundFloorPicture.Image = Elevator.Properties.Resources.G;
				controlPannelPicture.Image = Elevator.Properties.Resources.G;
				enableButtons();

			}
		}

		//function to check whether doors are closed or open
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

		//button and timer  event handlers


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

		//connect database when the form loads
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

		//enable or disable buttons when the elevator is in use
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

		//database functions:

		public void updateDatalog()
		{
			logTable.DataSource = datacom.updateLog();
		}

		public void clearLog()
		{
			logTable.DataSource = null;
		}

		public void emptyDatabase()
		{
			//try catch block to avoid logical errors
			try
			{
				logTable.DataSource = null;
				datacom.deleteRecords();
				MessageBox.Show("Successfully deleted records", "Database Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch(Exception)
			{
				MessageBox.Show("Failed to delete Records", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void clearLogBtn_Click(object sender, EventArgs e)
		{
			clearLog();
		}

		private void emptyDatabaseBtn_Click(object sender, EventArgs e)
		{
			//handeling events when doing database related tasks
			//more than one database function cannot be executed at a single time
			if (!deleteDatabaseBackgroundWorker.IsBusy & !updateDatabseBackgroundWorker.IsBusy)
			{
				deleteDatabaseBackgroundWorker.RunWorkerAsync();
			}
			else if (deleteDatabaseBackgroundWorker.IsBusy)
			{
				MessageBox.Show("Emptying out the database");
			}
			else if (updateDatabseBackgroundWorker.IsBusy)
			{
				MessageBox.Show("Please wait while other Database functions are run");
			}
		}

		private void retriveLogBtn_Click(object sender, EventArgs e)
		{
			updateDatalog();
		}

		private void updateDatabaseBtn_Click(object sender, EventArgs e)
		{
			if (!updateDatabseBackgroundWorker.IsBusy && !deleteDatabaseBackgroundWorker.IsBusy)
			{
				updateDatabseBackgroundWorker.RunWorkerAsync();
			}
			else if (updateDatabseBackgroundWorker.IsBusy)
			{
				MessageBox.Show("Updating Database");
			}
			else if (deleteDatabaseBackgroundWorker.IsBusy)
			{
				MessageBox.Show("Please wait while other Database functions are running");
			}
		}

		//background worker (do work event)
		private void updateDatabseBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			try
			{
				datacom.insertDataToDatabse();
			}
			catch (Exception)
			{
				MessageBox.Show("Failed to update database. \n Please make sure at least one action is preformed.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void deleteDatabaseBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			emptyDatabase();
		}
	}
}
