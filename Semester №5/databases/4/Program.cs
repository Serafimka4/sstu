using System;
using System.Data.SqlClient;

namespace ADO.NET_Application
{
	class Program
	{
		static void ConnectToDatabaseAndExecuteQuery(string connectionString, string query)
		{
			SqlConnection connection = new SqlConnection(connectionString);
			SqlCommand command = new SqlCommand(query, connection);

			try
			{
				connection.Open();
				SqlDataReader reader = command.ExecuteReader();

				while (reader.Read())
					Console.WriteLine("\t{0} \t{1}", reader[0], reader[1]);

				reader.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}

		static void Main()
		{
			// Строка подключения к базе данных:
			string connectionString = "Data Source=DESKTOP-A7GM5LG;Initial Catalog=TestDB;User ID=sql_guest;Password=password";

			// Выполняем разрешенный запрос:
			string allowedQuery = "select Id, Name from students where Id < 3;";
			ConnectToDatabaseAndExecuteQuery(connectionString, allowedQuery);

			// Выполняем запрещенный запрос:
			string notAllowedQuery = "drop table students;";
			ConnectToDatabaseAndExecuteQuery(connectionString, notAllowedQuery);
		}
	}
}
