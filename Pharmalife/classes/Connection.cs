﻿using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

public class Connection
{
	public Connection()
	{
		
	}

	public static MySqlConnection connectToDb()
	{
		const String DB_SERVER = "127.0.0.1";
		const String DB_PORT = "3306";
		const String DB_USER = "pharmalife_user";
		const String DB_PASSWORD = "pharmalife_password";
		const String DB_NAME = "pharmalife_db";

		String cadena = "Database  = " + DB_NAME + "; Data Source = " + DB_SERVER + "; Port = " + DB_PORT + "; User Id = " + DB_USER + "; Password = " + DB_PASSWORD;

		try
		{
			MySqlConnection connection = new MySqlConnection(cadena);
			return connection;
		}
		catch (MySqlException ex)
		{
			MessageBox.Show("Error al conectar con BD: " + ex.Message);
			return null;
		}
	}
}