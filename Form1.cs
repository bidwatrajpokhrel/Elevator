using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Elevator
{
	public partial class Form1 : Form
	{

		//coordinate variables
		int xLeftDoorOpen = 86;
		int xLeftDoorClosed = 251;
		int xRightDoorOpen = 289;
		int xRightDoorClosed = 226;
		int yElevatorUp = 82;
		int yElevatorDown = 324;

		//function variables
		bool goUpBool = false;
		bool goDownBool = false;
		bool doorClosedBool = true;

		public Form1()
		{
			InitializeComponent();
		}

		
		private void doorOpen()
		{

			if (elevatorUnit.Top <= yElevatorUp)
			{
				//insert_activity("FirstFloor doors Opening");
				if (rightDoorUp.Left <= xRightDoorOpen && leftDoorUp.Left >= xLeftDoorOpen)
				{
					leftDoorUp.Left -= 1;
					//leftDoorDown.Left -= 1;
					rightDoorUp.Left += 1;
					//rightDoorDown.Left += 1;
				}
				else
				{
					doorOpenTimer.Enabled = false;
					doorClosedBool = false;
				}
			}
			else
			{
				//insert_activity("GroundFloor doors Opening");
				if (rightDoorDown.Left <= xRightDoorOpen && leftDoorDown.Left >= xLeftDoorOpen)
				{
					//leftDoorUp.Left -= 1;
					leftDoorDown.Left -= 1;
					//rightDoorUp.Left += 1;
					rightDoorDown.Left += 1;
				}
				else
				{
					doorClosedBool = false;
					doorOpenTimer.Enabled = false;
				}
			}
		}

		private void doorClose()
		{
			if (elevatorUnit.Top >= yElevatorDown)
			{
				//insert_activity("GroundFloor doors closing");
				if (rightDoorDown.Left >= xRightDoorClosed && leftDoorDown.Left <= xLeftDoorClosed)
				{
					//leftDoorUp.Left += 1;
					leftDoorDown.Left += 1;
					//rightDoorUp.Left -= 1;
					rightDoorDown.Left -= 1;
				}
				else
				{
					doorCloseTimer.Enabled = false;
					doorClosedBool = true;
					//checkUpDown();
				}
			}
			else
			{
				//insert_activity("FirstFloor doors closing");
				if (rightDoorUp.Left >= xRightDoorClosed && leftDoorUp.Left <= xLeftDoorClosed)
				{
					leftDoorUp.Left += 1;
					//leftDoorDown.Left += 1;
					rightDoorUp.Left -= 1;
					//rightDoorDown.Left -= 1;
				}
				else
				{
					doorCloseTimer.Enabled = false;
					doorClosedBool = true;
					//checkUpDown();
				}
			}
		}

		private void elevatorUp()
		{
			if (elevatorUnit.Top >= yElevatorUp)
			{
				//insert_activity("Elevator Going Up");
				elevatorUnit.Top -= 1;
				elevatorIndoor.Top -= 1;
				firstFloorDisplay.Text = "GOING UP";
				groundFloorDisplay.Text = "GOING UP";
				controlPanelDisplay.Text = "GOING UP";
				firstFloorPicture.Image = Elevator.Properties.Resources.up;
				groundFloorPicture.Image = Elevator.Properties.Resources.up;
				controlPannelPicture.Image = Elevator.Properties.Resources.up;


			}
			else
			{
				goUpBool = false;
				goDownBool = false;
				goUpTimer.Enabled = false;
				doorOpenTimer.Interval = 10;
				doorOpenTimer.Enabled = true;
				firstFloorDisplay.Text = "FIRST FLOOR";
				groundFloorDisplay.Text = "FIRST FLOOR";
				controlPanelDisplay.Text = "FIRST FLOOR";
				firstFloorPicture.Image = Elevator.Properties.Resources.one;
				groundFloorPicture.Image = Elevator.Properties.Resources.one;
				controlPannelPicture.Image = Elevator.Properties.Resources.one;
			}
		}

		private void elevatorDown()
		{
			//insert_activity("Elevator Going Down");
			if (elevatorUnit.Top <= yElevatorDown)
			{
				elevatorUnit.Top += 1;
				elevatorIndoor.Top += 1;
				firstFloorDisplay.Text = "GOING DOWN";
				groundFloorDisplay.Text = "GOING DOWN";
				controlPanelDisplay.Text = "GOING DOWN";
				firstFloorPicture.Image = Elevator.Properties.Resources.down;
				groundFloorPicture.Image = Elevator.Properties.Resources.down;
				controlPannelPicture.Image = Elevator.Properties.Resources.down;
			}
			else
			{
				goDownBool = false;
				goUpBool = false;
				goDownTimer.Enabled = false;
				doorOpenTimer.Interval = 10;
				doorOpenTimer.Enabled = true;
				firstFloorDisplay.Text = "GROUND FLOOR";
				groundFloorDisplay.Text = "GROND FLOOR";
				controlPanelDisplay.Text = "GROUND FLOOR";
				firstFloorPicture.Image = Elevator.Properties.Resources.G;
				groundFloorPicture.Image = Elevator.Properties.Resources.G;
				controlPannelPicture.Image = Elevator.Properties.Resources.G;

			}
		}

		private void checkDoorClosed()
		{
			if (!doorClosedBool)
			{
				doorCloseTimer.Interval = 10;
				doorCloseTimer.Enabled = true;
			}
			else
			{
				if (goUpBool)
				{
					goUpTimer.Enabled = true;
				}
				else
				{
					goDownTimer.Enabled = true;
				}
			}
		}

		private void checkUpDown()
		{
			if (goDownBool)
			{
				goDownTimer.Enabled = true;
			}
			else
			{
				goUpTimer.Enabled = true;
			}
		}

		private void openDoorBtn_Click(object sender, EventArgs e)
		{
			insert_activity("opening doors");
			doorOpenTimer.Interval = 10;
			doorOpenTimer.Enabled = true;
		}

		private void doorOpenTimer_Tick(object sender, EventArgs e)
		{
			doorOpen();
		}

		private void closeDoorBtn_Click(object sender, EventArgs e)
		{
			insert_activity("closing doors");
			doorCloseTimer.Interval = 10;
			doorCloseTimer.Enabled = true;
		}

		private void doorCloseTimer_Tick(object sender, EventArgs e)
		{
			doorClose();
		}

		private void testtxt_Load(object sender, EventArgs e)
		{
			update_log();
		}

		private void insert_activity(string activity)
		{
			//string conn = @"Provider=Microsoft.ACE.OLEDB.12.0;data source = ./appdata/elevator_db.accdb";
			//OleDbConnection newCon = new OleDbConnection(conn);
			string dbCommand = "insert into elevator_log ([Activities], [Date_and_Time]) values (?, ?)";
			//string dbCommand = "insert into elevator_log ([Date_and_Time]) values (?)";
			string datetime = DateTime.Now.ToString();

			using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;data source = ./appdata/elevator_db.accdb"))
			using (OleDbCommand cmd = new OleDbCommand(dbCommand, conn))
			{

				conn.Open();
				cmd.Parameters.AddWithValue("@Activity", activity);
				cmd.Parameters.AddWithValue("@Date_and_Time", datetime);
				cmd.ExecuteNonQuery();
				conn.Close();
			}

			update_log();


			//OleDbCommand insert_log = new OleDbCommand(dbCommand, newCon);
			//OleDbDataAdapter adapter_insert = new OleDbDataAdapter(insert_log);
			//insert_log.Parameters.AddWithValue("@datetime", datetime);
			//insert_log.Parameters.AddWithValue("@activity", activity);



			//newCon.Open();
			//insert_log.ExecuteNonQuery();
			//newCon.Close();

		}

		private void update_log()
		{
			string conn = @"Provider=Microsoft.ACE.OLEDB.12.0;data source = ./appdata/elevator_db.accdb";
			OleDbConnection newCon = new OleDbConnection(conn);
			OleDbCommand cmd = new OleDbCommand();
			cmd.Connection = newCon;
			cmd.CommandText = "select * from elevator_log";
			OleDbDataAdapter da = new OleDbDataAdapter(cmd);
			DataSet ds = new DataSet();
			newCon.Open();
			da.Fill(ds);
			newCon.Close();
			logTable.DataSource = ds.Tables[0].DefaultView;
		}

		private void goDownBtn_Click(object sender, EventArgs e)
		{
			insert_activity("going down");
			goDownTimer.Interval = 10;
			goDownBool = true;
			checkDoorClosed();
			//goDownTimer.Enabled = true;

		}

		private void goDownTimer_Tick(object sender, EventArgs e)
		{
			elevatorDown();
		}

		private void goUpBtn_Click(object sender, EventArgs e)
		{
			insert_activity("going up");
			goUpTimer.Interval = 10;
			goUpBool = true;
			checkDoorClosed();
			//goUpTimer.Enabled = true;
		}

		private void goUpTimer_Tick(object sender, EventArgs e)
		{
			
			elevatorUp();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			insert_activity("going up");
			goUpTimer.Interval = 10;
			goUpBool = true;
			checkDoorClosed();
		}

		private void callDownBtn_Click(object sender, EventArgs e)
		{
			insert_activity("going down");
			goDownTimer.Interval = 10;
			goDownBool = true;
			checkDoorClosed();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void firstFloorPicture_Click(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
