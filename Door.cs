using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Elevator
{
	//class for controlling the doors of elevator
	class Door
	{
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
	}

}
