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
		int xLeftDoorOpen = 86;
		int xLeftDoorClosed = 251;
		int xRightDoorOpen = 289;
		int xRightDoorClosed = 226;

		public void doorOpen(PictureBox rightDoorUp, PictureBox rightDoorDown, PictureBox leftDoorUp, PictureBox leftDoorDown)
		{
				if (rightDoorUp.Left <= xRightDoorOpen && leftDoorUp.Left >= xLeftDoorOpen)
				{
					leftDoorUp.Left -= 1;
					rightDoorUp.Left += 1;
				}
				else if (rightDoorDown.Left <= xRightDoorOpen && leftDoorDown.Left >= xLeftDoorOpen)
				{
					leftDoorDown.Left -= 1;
					rightDoorDown.Left += 1;
				}

		}

		public void doorClose(PictureBox rightDoorUp, PictureBox rightDoorDown, PictureBox leftDoorUp, PictureBox leftDoorDown)
		{
			if (rightDoorDown.Left >= xRightDoorClosed && leftDoorDown.Left <= xLeftDoorClosed)
			{
				leftDoorDown.Left += 1;
				rightDoorDown.Left -= 1;
				
			}
			else if (rightDoorUp.Left >= xRightDoorClosed && leftDoorUp.Left <= xLeftDoorClosed)
			{
				leftDoorUp.Left += 1;
				rightDoorUp.Left -= 1;
			}
				
		}

	}

}
