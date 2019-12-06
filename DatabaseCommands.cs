using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator
{
	//this class contains all the necessary database commands
	class DatabaseCommands
	{
		String[] logarray;
		List<String> loglist = new List<string>();
		
		//collected data collects all the log actions when actions are preformed
		public void CollectData(string activity)
		{
			DateTime moment = DateTime.Now;
			string timeNow = moment.ToString();
			string logevent = activity + "+" + timeNow;
			loglist.Add(logevent);
			logarray = loglist.ToArray();
		}

		//inserts data to the database when Update Database button is pressed
		public void insertDataToDatabse()
		{
			try
			{
				string dbCommand = "SELECT * FROM elevator_log";
				OleDbCommand cmd = new OleDbCommand(dbCommand, DatabaseConnection.connection);
				OleDbDataAdapter da = new OleDbDataAdapter(cmd);
				DataSet ds = new DataSet();
				OleDbCommandBuilder ocb = new OleDbCommandBuilder(da);
				ds.Clear();
				da.Fill(ds);
				DataTable dt = ds.Tables[0];
				foreach (string log in logarray)
				{
					DataRow dr = dt.NewRow();
					string[] data = log.Split('+');
					dr["Activities"] = data[0];
					dr["Date_and_Time"] = data[1];
					dt.Rows.Add(dr);
				}
				DataSet dsc = ds.GetChanges();
				da.Update(dsc);					//using data adapter Update() method
				dt.AcceptChanges();
				MessageBox.Show("Successfully updated list", "Database Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				loglist.Clear();
			}
			catch(Exception e)
			{
				throw e;
			}
		}


		//passes a table to update data log on the GUI
		public DataTable updateLog()
		{
			try
			{
				OleDbCommand cmd = new OleDbCommand();
				cmd.Connection = DatabaseConnection.connection;
				cmd.CommandText = "select * from elevator_log";
				OleDbDataAdapter da = new OleDbDataAdapter(cmd);
				DataSet ds = new DataSet();
				da.Fill(ds);
				return ds.Tables[0];
			}
			catch (Exception ex)
			{
				throw ex;
				DataSet sampleds = new DataSet();
				return sampleds.Tables[0];
			}


		}

		//clears out the database entirely
		public void deleteRecords()
		{
			try
			{
				string remove = "DELETE * FROM elevator_log";
				OleDbCommand cmd = new OleDbCommand(remove, DatabaseConnection.connection);
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

	}
}
