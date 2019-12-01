using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Elevator
{
	class Door
	{
		//int xLeftDoorOpen = 86;
		//int xLeftDoorClosed = 251;
		//int xRightDoorOpen = 289;
		//int xRightDoorClosed = 226;



		public void doorOpenUp(PictureBox rightDoorUp, PictureBox leftDoorUp)
		{			
			leftDoorUp.Left -= 1;
			rightDoorUp.Left += 1;
		}

		public void doorOpenDown(PictureBox rightDoorDown, PictureBox leftDoorDown)
		{
			leftDoorDown.Left -= 1;
			rightDoorDown.Left += 1;
		}

		public void doorCloseUp(PictureBox rightDoorUp, PictureBox leftDoorUp)
		{

			leftDoorUp.Left += 1;
			rightDoorUp.Left -= 1;

		}


		public void doorCloseDown(PictureBox rightDoorDown, PictureBox leftDoorDown)
		{
			leftDoorDown.Left += 1;
			rightDoorDown.Left -= 1;
		}

		//public void doorOpen(PictureBox rightDoorUp, PictureBox leftDoorUp, PictureBox rightDoorDown, PictureBox leftDoorDown,
		//	PictureBox elevatorPosition, Timer doorOpenTimer, Timer counterTimer)
		//{

		//	if (elevatorPosition.Top <= yElevatorUp)
		//	{
		//		if (rightDoorUp.Left <= xRightDoorOpen && leftDoorUp.Left >= xLeftDoorOpen)
		//		{
		//			doorOpenUp(rightDoorUp, leftDoorUp);
		//			formObj.disableButtons();

		//		}
		//		else
		//		{
		//			datacom.insertActivity("Door Opened at First Floor");
		//			formObj.updateDatalog();
		//			doorOpenTimer.Enabled = false;
		//			formObj.doorClosedBool = false;
		//			formObj.enableButtons();
		//			formObj.counter = 0;
		//			counterTimer.Enabled = true;
		//		}
		//	}
		//	else
		//	{
		//		if (rightDoorDown.Left <= xRightDoorOpen && leftDoorDown.Left >= xLeftDoorOpen)
		//		{
		//			doorOpenDown(rightDoorDown, leftDoorDown);
		//			formObj.disableButtons();
		//		}
		//		else
		//		{
		//			datacom.insertActivity("Door Opened at Ground Floor");
		//			formObj.updateDatalog();
		//			formObj.doorClosedBool = false;
		//			doorOpenTimer.Enabled = false;
		//			formObj.enableButtons();
		//			formObj.counter = 0;
		//			counterTimer.Enabled = true;
		//		}
		//	}
		//}
	}

}
