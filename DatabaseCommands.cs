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
				DataRow dr = dt.NewRow();
				dt.Rows.Add(dr);
				dr["Activities"] = activity;
				dr["Date_and_Time"] = DateTime.Now.ToString();
				DataSet dsc = ds.GetChanges();
				da.Update(dsc);
				dt.AcceptChanges();
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
