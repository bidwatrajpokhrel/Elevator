using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator
{
	public class ElevatorL0Dc : ElevatorState
	{
		ElevatorContext elevCon;
		public ElevatorL0Dc(ElevatorContext ec)
		{
			this.elevCon = ec;
		}
		public void doorOpen()
		{
			//open door at ground floor
			MessageBox.Show("Open door at ground floor, state 13");
			this.elevCon.changeState(new ElevatorL0Do(this.elevCon));
		}
		public void doorClose()
		{
			//do nothing
			MessageBox.Show("Close door at ground floor(in this state, state 14");
			this.elevCon.changeState(new ElevatorL0Dc(this.elevCon));
		}
		public void moveUp()
		{
			//move up to the first floor and open door
			MessageBox.Show("Move up and open door, state 15");
			this.elevCon.changeState(new ElevatorL1Do(this.elevCon));
		}
		public void moveDown()
		{
			//open door of ground floor
			MessageBox.Show("already on ground floor, open door, state 16");
			this.elevCon.changeState(new ElevatorL0Do(this.elevCon));
		}
	}
}
