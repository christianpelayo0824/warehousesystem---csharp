/*
 * Created by SharpDevelop.
 * User: chris
 * Date: 03/15/2018
 * Time: 19:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows;
using MySql.Data.MySqlClient;
using WarehouseSystem.Poco;

namespace WarehouseSystem.Model
{
	public class UserDbUtils
	{
		Database.DbConnection database = new Database.DbConnection();
		MySqlCommand command;
		MySqlConnection connection;
		
		public UserDbUtils()
		{
			connection = database.getConnection();
			connection.Open();
		}
		
		public void createUserAdmin(User user)
		{
			try {
				String query = "INSERT INTO users(userid,firstname, lastname, email, username, password) " +
				               "VALUES(?, ?, ?, ?, ? , ?)";
				command = new MySqlCommand(query, connection);
				command.Parameters.AddWithValue("@userid", user.getUserId());
				command.Parameters.AddWithValue("@firstname", user.getFirstname());
				command.Parameters.AddWithValue("@lastname", user.getLastname());
				command.Parameters.AddWithValue("@email", user.getEmail());
				command.Parameters.AddWithValue("@username", user.getUsername());
				command.Parameters.AddWithValue("@password", user.getPassword());
				command.ExecuteNonQuery();
				MessageBox.Show("Created!");
			} catch (Exception e) {
				MessageBox.Show("Error" + e);
			}
			connection.Close();
		}
		
		public Boolean getCredentials(User user)
		{
			MySqlDataReader dr = null;
			Boolean status = false;
			try {
				String query = "SELECT * FROM users WHERE username = ? && password = ?";
				command = new MySqlCommand(query, connection);
				command.Parameters.AddWithValue("@username", user.getUsername());
				command.Parameters.AddWithValue("@password", user.getPassword());
				dr = command.ExecuteReader();
				while (dr.Read()) {
					status = true;
				}
				dr.Close();
			} catch (Exception e) {
				status = false;
				MessageBox.Show("Error: " + e);
			}
			return status;
		}
		
		public User getUserConn(String username, String password)
		{
			MySqlDataReader dr = null;
			var userFire = new User();
			try {
				String query = "SELECT * FROM users WHERE username = ? && password = ?";
				command = new MySqlCommand(query, connection);
				command.Parameters.AddWithValue("@username", username);
				command.Parameters.AddWithValue("@password", password);
				dr = command.ExecuteReader();
				while (dr.Read()) {
					userFire.setUserId(dr.GetInt32(0));
					userFire.setFirstname(dr.GetString(1));
					userFire.setLastname(dr.GetString(2));
					userFire.setEmail(dr.GetString(3));
					userFire.setUsername(dr.GetString(4));
					userFire.setPassword(dr.GetString(5));
				}
				dr.Close();
			} catch (Exception e) {
				
				MessageBox.Show("Error: " + e);
			}
			return userFire;
		}
	}
}
