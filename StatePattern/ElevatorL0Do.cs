using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator
{
	public class ElevatorL0Do : ElevatorState
	{
		ElevatorContext elevCon;

		public ElevatorL0Do(ElevatorContext ec)
		{
			this.elevCon = ec;
		}
		public void doorOpen()
		{
			//do nothing/reset auto timer
			MessageBox.Show("already on this state start auto timer, state 9");
			this.elevCon.changeState(new ElevatorL0Do(this.elevCon));
		}
		public void doorClose()
		{
			//close door of ground floor
			MessageBox.Show("Close ground Floor Doors, state 10");
			this.elevCon.changeState(new ElevatorL0Dc(this.elevCon));
		}
		public void moveUp()
		{
			//close door, move to first floor and open first floor door
			MessageBox.Show("Go to first floor and open door, state 11");
			this.elevCon.changeState(new ElevatorL1Do(this.elevCon));
		}
		public void moveDown()
		{

			//open door of ground floor (reastart auto timer)
			MessageBox.Show("Open door on ground floor(in this state), state 12");
			this.elevCon.changeState(new ElevatorL0Do(this.elevCon));
		}
	}
}
