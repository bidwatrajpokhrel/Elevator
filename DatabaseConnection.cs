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
		//string to store the relative path to the database
		private static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;data source = ./appdata/elevator_db.accdb";

		public static OleDbConnection connection;

		//funcion to connect to the database
		public static void databaseConnectionFn()
		{	//exception handeling using try catch
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
