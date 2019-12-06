using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
	public class ElevatorContext
	{
		ElevatorState state;
		public ElevatorContext()
		{
			this.state = new ElevatorL1Dc(this);
		}
		public void changeState(ElevatorState s)
		{
			this.state = s;
		}
		public void onDoorOpen()
		{
			this.state.doorOpen();
		}
		public void onDoorClose()
		{
			this.state.doorClose();
		}
		public void onMoveUp()
		{
			this.state.moveUp();
		}
		public void onMoveDown()
		{
			this.state.moveDown();
		}
	}
}
