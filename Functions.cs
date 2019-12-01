using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator
{
	class Functions
	{
		DatabaseCommands datacom = new DatabaseCommands();
		public void updateDatalog(DataGrid logTable)
		{
			logTable.DataSource = datacom.updateLog().DefaultView;
		}

		public void clearLog(DataGrid logTable)
		{
			logTable.DataSource = null;
		}

		public void emptyDatabase(DataGrid logTable)
		{
			logTable.DataSource = null;
			datacom.deleteRecords();
		}

		public void disableButtons(Button goUpBtn, Button goDownBtn, 
			Button openDoorBtn, Button closeDoorBtn, Button callDownBtn, Button callUpBtn)
		{
			goUpBtn.Enabled = false;
			goDownBtn.Enabled = false;
			openDoorBtn.Enabled = false;
			closeDoorBtn.Enabled = false;
			callDownBtn.Enabled = false;
			callUpBtn.Enabled = false;
		}

		public void enableButtons(Button goUpBtn, Button goDownBtn,
			Button openDoorBtn, Button closeDoorBtn, Button callDownBtn, Button callUpBtn)
		{
			goUpBtn.Enabled = true;
			goDownBtn.Enabled = true;
			openDoorBtn.Enabled = true;
			closeDoorBtn.Enabled = true;
			callDownBtn.Enabled = true;
			callUpBtn.Enabled = true;
		}



	}
}
