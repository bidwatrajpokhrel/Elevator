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
	class DatabaseCommands
	{
		DatabaseConnection datacon = new DatabaseConnection();
		public void insertActivity(string activity)
		{
			//OleDbDataAdapter da = new OleDbDataAdapter();
			//DataSet ds = new DataSet();
			//OleDbCommandBuilder ocb = new OleDbCommandBuilder(da);
			//ds.Clear();
			//da.Fill(ds);
			//DataTable dt = ds.Tables[0];
			//DataRow dr = dt.NewRow();
			//dr[] = activity;
			//dr[] = DateTime.Now.ToString();
			//dt.Rows.Add(dr);

			//DataSet dsc = ds.GetChanges();
			//da.Update(dsc);
			//dt.AcceptChanges();

			try
			{
				string dbCommand = "insert into elevator_log ([Activities], [Date_and_Time]) values (?, ?)";
				OleDbCommand cmd = new OleDbCommand(dbCommand, DatabaseConnection.connection);

				string datetime = DateTime.Now.ToString();
				cmd.Parameters.AddWithValue("@Activity", activity);
				cmd.Parameters.AddWithValue("@Date_and_Time", datetime);
				cmd.ExecuteNonQuery();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

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
				MessageBox.Show(ex.Message);
				DataSet sampleds = new DataSet();
				return sampleds.Tables[0];
			}


		}

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
				MessageBox.Show(ex.Message);
			}
		}

	}
}
