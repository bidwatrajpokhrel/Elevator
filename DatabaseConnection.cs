using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator
{
	class DatabaseConnection
	{
		private static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;data source = ./appdata/elevator_db.accdb";
		public static OleDbConnection connection;
		public static void databaseConnectionFn()
		{
			try
			{
				connection = new OleDbConnection(connectionString);
				connection.Open();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

	}
}
