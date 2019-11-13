using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

		public Form1()
		{
			InitializeComponent();
		}

		private void openDoorBtn_Click(object sender, EventArgs e)
		{
			doorOpenTimer.Interval = 10;
			doorOpenTimer.Enabled = true;
		}

		private void doorOpenTimer_Tick(object sender, EventArgs e)
		{
			if (rightDoorDown.Left <= xRightDoorOpen && leftDoorDown.Left >= xLeftDoorOpen)
			{
				leftDoorUp.Left -= 1;
				leftDoorDown.Left -= 1;
				rightDoorUp.Left += 1;
				rightDoorDown.Left += 1;
				texttxt.Text = leftDoorDown.Left + ", " + rightDoorDown.Left;
			}
			else
			{
				doorOpenTimer.Enabled = false;
			}
		}

		private void closeDoorBtn_Click(object sender, EventArgs e)
		{
			doorCloseTimer.Interval = 10;
			doorCloseTimer.Enabled = true;
		}

		private void doorCloseTimer_Tick(object sender, EventArgs e)
		{
			if (rightDoorDown.Left >= xRightDoorClosed && leftDoorDown.Left <= xLeftDoorClosed)
			{
				leftDoorUp.Left += 1;
				leftDoorDown.Left += 1;
				rightDoorUp.Left -= 1;
				rightDoorDown.Left -= 1;
				texttxt.Text = leftDoorDown.Left + ", " + rightDoorDown.Left;
			}
			else
			{
				doorCloseTimer.Enabled = false;
			}
		}

		private void testtxt_Load(object sender, EventArgs e)
		{
		}

		private void goDownBtn_Click(object sender, EventArgs e)
		{
			goDownTimer.Interval = 10;
			goDownTimer.Enabled = true;
		}

		private void goDownTimer_Tick(object sender, EventArgs e)
		{
			if (elevatorUnit.Top <= yElevatorDown)
			{
				elevatorUnit.Top += 1;
			}
			else
			{
				goDownTimer.Enabled = false;
			}
		}

		private void goUpBtn_Click(object sender, EventArgs e)
		{
			goUpTimer.Interval = 10;
			goUpTimer.Enabled = true;
		}

		private void goUpTimer_Tick(object sender, EventArgs e)
		{
			if (elevatorUnit.Top >= yElevatorUp)
			{
				elevatorUnit.Top -= 1;
				
			}
			else
			{
				goDownTimer.Enabled = false;
			}
		}
	}
}
