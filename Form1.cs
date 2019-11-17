using System;
using System.Windows.Forms;

namespace Elevator
{
	public partial class Form1 : Form
	{

		//coordinate variables
		int xLeftDoorOpen = 86;
		int xLeftDoorClosed = 251;
		int xRightDoorOpen = 289;
		int xRightDoorClosed = 226;
		int yElevatorUp = 82;
		int yElevatorDown = 324;

		//function variables
		bool goUpBool = false;
		bool goDownBool = false;
		bool doorClosedBool = true;

		public Form1()
		{
			InitializeComponent();
		}

		private void doorOpen()
		{

			if (elevatorUnit.Top <= yElevatorUp)
			{
				if (rightDoorUp.Left <= xRightDoorOpen && leftDoorUp.Left >= xLeftDoorOpen)
				{
					leftDoorUp.Left -= 1;
					//leftDoorDown.Left -= 1;
					rightDoorUp.Left += 1;
					//rightDoorDown.Left += 1;
				}
				else
				{
					
					doorOpenTimer.Enabled = false;
					doorClosedBool = false;
				}
			}
			else
			{
				if (rightDoorDown.Left <= xRightDoorOpen && leftDoorDown.Left >= xLeftDoorOpen)
				{
					//leftDoorUp.Left -= 1;
					leftDoorDown.Left -= 1;
					//rightDoorUp.Left += 1;
					rightDoorDown.Left += 1;
				}
				else
				{
					doorClosedBool = false;
					doorOpenTimer.Enabled = false;
				}
			}
		}

		private void doorClose()
		{
			if (elevatorUnit.Top >= yElevatorDown)
			{
				if (rightDoorDown.Left >= xRightDoorClosed && leftDoorDown.Left <= xLeftDoorClosed)
				{
					//leftDoorUp.Left += 1;
					leftDoorDown.Left += 1;
					//rightDoorUp.Left -= 1;
					rightDoorDown.Left -= 1;
				}
				else
				{
					doorCloseTimer.Enabled = false;
					doorClosedBool = true;
					//checkUpDown();
				}
			}
			else
			{
				if (rightDoorUp.Left >= xRightDoorClosed && leftDoorUp.Left <= xLeftDoorClosed)
				{
					leftDoorUp.Left += 1;
					//leftDoorDown.Left += 1;
					rightDoorUp.Left -= 1;
					//rightDoorDown.Left -= 1;
				}
				else
				{
					doorCloseTimer.Enabled = false;
					doorClosedBool = true;
					//checkUpDown();
				}
			}
		}

		private void elevatorUp()
		{
			if (elevatorUnit.Top >= yElevatorUp)
			{
				elevatorUnit.Top -= 1;

			}
			else
			{
				goUpBool = false;
				goDownBool = false;
				goUpTimer.Enabled = false;
				doorOpenTimer.Interval = 10;
				doorOpenTimer.Enabled = true;
			}
		}

		private void elevatorDown()
		{
			if (elevatorUnit.Top <= yElevatorDown)
			{
				elevatorUnit.Top += 1;
			}
			else
			{
				goDownBool = false;
				goUpBool = false;
				goDownTimer.Enabled = false;
				doorOpenTimer.Interval = 10;
				doorOpenTimer.Enabled = true;
			}
		}

		private void checkDoorClosed()
		{
			if (!doorClosedBool)
			{
				doorCloseTimer.Interval = 10;
				doorCloseTimer.Enabled = true;
			}
			else
			{
				if (goUpBool)
				{
					goUpTimer.Enabled = true;
				}
				else
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
			doorOpenTimer.Interval = 10;
			doorOpenTimer.Enabled = true;
		}

		private void doorOpenTimer_Tick(object sender, EventArgs e)
		{
			doorOpen();
		}

		private void closeDoorBtn_Click(object sender, EventArgs e)
		{
			doorCloseTimer.Interval = 10;
			doorCloseTimer.Enabled = true;
		}

		private void doorCloseTimer_Tick(object sender, EventArgs e)
		{
			doorClose();
		}

		private void testtxt_Load(object sender, EventArgs e)
		{
		}

		private void goDownBtn_Click(object sender, EventArgs e)
		{
			goDownTimer.Interval = 10;
			goDownBool = true;
			checkDoorClosed();
			//goDownTimer.Enabled = true;

		}

		private void goDownTimer_Tick(object sender, EventArgs e)
		{
			elevatorDown();
		}

		private void goUpBtn_Click(object sender, EventArgs e)
		{
			goUpTimer.Interval = 10;
			goUpBool = true;
			checkDoorClosed();
			//goUpTimer.Enabled = true;
		}

		private void goUpTimer_Tick(object sender, EventArgs e)
		{
			
			elevatorUp();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			goUpTimer.Interval = 10;
			goUpBool = true;
			checkDoorClosed();
		}

		private void callDownBtn_Click(object sender, EventArgs e)
		{
			goDownTimer.Interval = 10;
			goDownBool = true;
			checkDoorClosed();
		}
	}
}
