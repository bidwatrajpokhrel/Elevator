using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator
{
	class ElevatorUnit
	{
		int yElevatorUp = 82;
		int yElevatorDown = 324;

		public void elevatorUp(PictureBox elevatorIndoor, PictureBox elevatorPosition)
		{
			if (elevatorPosition.Top >= yElevatorUp)
			{
				elevatorPosition.Top -= 1;
				elevatorIndoor.Top -= 1;
			}
		}

		public void elevatorDown(PictureBox elevatorIndoor, PictureBox elevatorPosition)
		{
			//insert_activity("Elevator Going Down");
			if (elevatorPosition.Top <= yElevatorDown)
			{
				elevatorPosition.Top += 1;
				elevatorIndoor.Top += 1;
			}
		}
	}
}
