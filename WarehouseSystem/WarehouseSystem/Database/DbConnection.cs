/*
 * Created by SharpDevelop.
 * User: chris
 * Date: 03/12/2018
 * Time: 23:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows;
using MySql.Data.MySqlClient;

namespace WarehouseSystem.Database
{
	public class DbConnection
	{
		static String DB_SERVER = "localhost";
		static String DB_NAME = "mydatabase";
		static String DB_USER = "root";
		static String DB_PASS = "";
		
		MySqlConnection conn = new MySqlConnection("server= " + DB_SERVER + "; " +
		                       "username = " + DB_USER + "; " +
		                       "password = " + DB_PASS + "; " +
		                       "database= " + DB_NAME);
		
		public MySqlConnection getConnection()
		{
			MySqlConnection connection = null;
			try {
				connection = conn;	
			} catch (Exception e) {
				MessageBox.Show("Error: " + e);
			}
			return connection;
		}
	}
}
