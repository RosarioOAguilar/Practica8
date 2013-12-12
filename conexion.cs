using MySql.Data.MySqlClient;
using System;

namespace practica8
{
	
	public class conexion
	{
		protected MySqlConnection myConnection;
		public conexion()
		{
		}
		
		protected void abrirConexion(){
			string connectionString =
				"Server=localhost;" +
				"Database=registro;" +
				"User ID=root;" +
				"Password=pifus1234567890;" +
				"Pooling=false;";
			this.myConnection = new MySqlConnection(connectionString);
			this.myConnection.Open();
		}
		
		protected void cerrarConexion(){
			this.myConnection.Close();
			this.myConnection = null;
			
		}
		
	}
}
