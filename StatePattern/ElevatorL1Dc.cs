using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator
{
	public class ElevatorL1Dc : ElevatorState
	{
		
		public ElevatorL1Dc(ElevatorContext ec)
		{
			this.elevCon = ec;
		}
		public void doorOpen()
		{
			//formObj.doorOpenUp();
			//open door of first floor
			MessageBox.Show("Open First Floor Door, state1");
			this.elevCon.changeState(new ElevatorL1Do(this.elevCon));
		}
		public void doorClose()
		{
			//do nothing beause it's already in this state
			MessageBox.Show("Door already closed on first floor, state2");
			this.elevCon.changeState(new ElevatorL1Dc(this.elevCon));
		}
		public void moveUp()
		{
			//open door
			MessageBox.Show("Door Already on first floor, open door; state3");
			this.elevCon.changeState(new ElevatorL1Do(this.elevCon));
		}
		public void moveDown()
		{
			//move to ground floor and open door
			MessageBox.Show("Move to ground floor and open door, state4");
			this.elevCon.changeState(new ElevatorL0Do(this.elevCon));

		}
	}
}
