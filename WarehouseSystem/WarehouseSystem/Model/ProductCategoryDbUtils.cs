/*
 * Created by SharpDevelop.
 * User: chris
 * Date: 03/18/2018
 * Time: 04:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;
using WarehouseSystem.Poco;
using System.Windows;
using System.Collections.Generic;
using System.Data;


namespace WarehouseSystem.Model
{

	public class ProductCategoryDbUtils
	{
		Database.DbConnection database = new Database.DbConnection();
		MySqlConnection connection;
		MySqlCommand command;
		
		
		public ProductCategoryDbUtils()
		{
			connection = database.getConnection();
			connection.Open();
		}
		
		public void createProductCategory(ProductCategory productCategory) {
			try {
				String query = "INSERT INTO product_category(categoryid, categorycode, description, type) " +
					"VALUES(?, ?, ?, ?)";
				command = new MySqlCommand(query, connection);
				command.Parameters.AddWithValue("@categoryid", productCategory.getCategoryId());
				command.Parameters.AddWithValue("@categorycode", productCategory.getCategoryCode());
				command.Parameters.AddWithValue("@description", productCategory.getCategoryDescription());
				command.Parameters.AddWithValue("@type", productCategory.getCategoryType());
				command.ExecuteNonQuery();
				
			} catch (Exception e) {
				MessageBox.Show("Error: " + e);
			}
			connection.Close();
		}
		
		public ProductCategory getProductCategory(String catCode) {
			var productCat = new ProductCategory();
			MySqlDataReader dr;
			try {
				String query = "SELECT * FROM product_category WHERE categorycode = ?";
				command = new MySqlCommand(query, connection);
				command.Parameters.AddWithValue("@categorycode", catCode);
				dr = command.ExecuteReader();
				while(dr.Read()) {
					productCat.setCategoryId(dr.GetInt32(0));
					productCat.setCategoryCode(dr.GetString(1));
					productCat.setCategoryDescription(dr.GetString(2));
					productCat.setCategoryType(dr.GetString(3));
				}
			} catch (Exception e) {
				
				MessageBox.Show("Error: " + e);
			}
			return productCat;
		}
		
		public Boolean getCategoryByCode(ProductCategory proCategory) {
			Boolean status = false;
			MySqlDataReader dr= null;
			try {
				String query = "SELECT * FROM product_category WHERE categorycode= ?";
				command = new MySqlCommand(query, connection);
				command.Parameters.AddWithValue("@categorycode", proCategory.getCategoryCode());
				dr = command.ExecuteReader();
				while(dr.Read()) {
					status = true;
				}
				dr.Close();
			} catch (Exception e) {
				MessageBox.Show("Error: " + e);
				status = false;
			}
			return status;
		}
		
		public DataTable getAllCategory() {
			MySqlDataAdapter dataAdapter;
			DataTable tempDataTable = null;
			
			try {
				String query = "SELECT * FROM product_category";
				command = new MySqlCommand(query, connection);
				dataAdapter = new MySqlDataAdapter(command);
				tempDataTable = new DataTable();
				dataAdapter.Fill(tempDataTable);
					
			} catch (Exception e) {
				MessageBox.Show("Error: " + e);
			}
			connection.Close();
			return tempDataTable;
		}
		
		public void updateCategory(ProductCategory proCat) {
			try {
				String query = "UPDATE product_category SET description = ?, type =? WHERE categorycode=?";
				command = new MySqlCommand(query, connection);
				command.Parameters.AddWithValue("@description", proCat.getCategoryDescription());
				command.Parameters.AddWithValue("@type", proCat.getCategoryType());
				command.Parameters.AddWithValue("@categorycode", proCat.getCategoryCode());
				command.Prepare();
				command.ExecuteNonQuery();
				MessageBox.Show("Product Category Updated!");
			} catch (Exception e) {
				MessageBox.Show("Error: " + e);
			}
		}
		
		public void deleteCategory(String catCode) {
			try {
				String query = "DELETE FROM product_category WHERE categorycode=?";
				command = new MySqlCommand(query, connection);
				command.Parameters.AddWithValue("@categorycode", catCode);
				command.Prepare();
				command.ExecuteNonQuery();
				MessageBox.Show("Product Category Deleted!");
			} catch (Exception e) {
				
				MessageBox.Show("Error: " + e);
			}
		}
		
		public long categoryCounter() {
			long counter = 0;
			try {
				String query = "SELECT COUNT(*) FROM product_category";
				command = new MySqlCommand(query, connection);
				//counter = Convert.ToInt32(command.ExecuteScalar());
				counter = (long)command.ExecuteScalar();
			} catch (Exception e) {
				MessageBox.Show("Error: " + e);
			}
			return counter;
		}
	}
}
