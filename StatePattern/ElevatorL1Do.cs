using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator
{
	public class ElevatorL1Do : ElevatorState
	{
		ElevatorContext elevCon;

		DatabaseCommands datacom = new DatabaseCommands();

		//dependency injection
		public ElevatorL1Do(ElevatorContext ec)
		{
			this.elevCon = ec;
		}
		public void doorOpen()
		{
			//Open the Door of first floor (do nothing because it's already open or restart the auto doorclose timer)
			MessageBox.Show("Door already open on first floor, state 5");
			this.elevCon.changeState(new ElevatorL1Do(this.elevCon)); //passing new state
		}
		public void doorClose()
		{
			//close door on first floor
			MessageBox.Show("Close first floor door, state 6");
			this.elevCon.changeState(new ElevatorL1Dc(this.elevCon));
		}
		public void moveUp()
		{
			//move to first floor (open door)
			MessageBox.Show("Already on this state so nothing happens, state 7");
			this.elevCon.changeState(new ElevatorL1Do(this.elevCon));
		}
		public void moveDown()
		{
			MessageBox.Show("Close doors, and move to ground floor and open ground floor doors, state 8");
			//close door and move to ground floor open door of ground Floor, start auto timer
			this.elevCon.changeState(new ElevatorL0Do(this.elevCon));
		}
	}
}
