/*
 * Created by SharpDevelop.
 * User: chris
 * Date: 03/18/2018
 * Time: 02:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;


namespace WarehouseSystem.Model
{
	
	public class ProductDbUtils
	{
		Database.DbConnection database = new Database.DbConnection();
		MySqlConnection connection;
		MySqlCommand command;
		
		
		public ProductDbUtils()
		{
			connection = database.getConnection();
			connection.Open();
		}
		
		public void createProduct(Product product) {
			
			try {
				String query = "INSERT INTO product(productid, productcode, categorycode, name, brand, price, quantity) " +
					"VALUES(?, ?, ?, ?, ?, ?, ?)";
				command = new MySqlCommand(query, connection);
				command.Parameters.AddWithValue("@productid", product.getProductId());
				command.Parameters.AddWithValue("@productcode", product.getProductCode());
				command.Parameters.AddWithValue("@categoryid",product.getProductCategoryCode());
				command.Parameters.AddWithValue("@name",product.getProductName());
				command.Parameters.AddWithValue("@brand", product.getProductBrand());
				command.Parameters.AddWithValue("@price", product.getProductPrice());
				command.Parameters.AddWithValue("@qauntity", product.getProductQuantity());
				command.Prepare();
				command.ExecuteNonQuery();
				MessageBox.Show("Product Created!");
			} catch (Exception e) {
				MessageBox.Show("Error: "  + e);
			}
			connection.Close();
		}
		
		public Boolean getProductByCode(String code) {
			
			MySqlDataReader dr;
			Boolean status = false;
			try {
				String query = "SELECT * FROM product WHERE productcode=?";
				command = new MySqlCommand(query, connection);
				command.Parameters.AddWithValue("@productcode", code);
				dr = command.ExecuteReader();
				while(dr.Read()) {
					status = true;
				}
				dr.Close();
			} catch (Exception e) {
				status = false;
				MessageBox.Show("Error: " + e);
			}
			connection.Close();
			return status;
		}
		
		public Product getProduct(String prodCode) {
			MySqlDataReader dr;
			var product = new Product();
			try {
				String query = "SELECT * FROM product WHERE productcode = ?";
				command = new MySqlCommand(query, connection);
				command.Parameters.AddWithValue("@productcode", prodCode);
				dr = command.ExecuteReader();
				while(dr.Read()) {
					product.setProductId(dr.GetInt32(0));
					product.setProductCode(dr.GetString(1));
					product.setProductCategoryCode(dr.GetString(2));
					product.setProductName(dr.GetString(3));
					product.setProductBrand(dr.GetString(4));
					product.setProductPrice(dr.GetInt32(5));
					product.setProductQuantity(dr.GetInt32(6));
				}
			} catch (Exception e) {
				MessageBox.Show("Error: " + e);
			}
			connection.Close();
			return product;
		}
		
		public void updateCurrentQuantity(Product product) {
			try {
				String query = "UPDATE product SET quantity = ? WHERE productcode = ?";
				command = new MySqlCommand(query, connection);
				command.Parameters.AddWithValue("@quantity", product.getProductQuantity());
				command.Parameters.AddWithValue("@productcode", product.getProductCode());
				command.Prepare();
				command.ExecuteNonQuery();
				
				MessageBox.Show("Thankyou for purchasing");
			} catch (Exception e) {
				MessageBox.Show("Error" + e);
			}
			connection.Close();
		}
		
		public DataTable getAllProducts() {
			MySqlDataAdapter dataAdapter;
			DataTable tempDataTable = null;
			
			try {
				String query = "SELECT * FROM product";
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
		
		public void updateProduct(Product product) {
			try {
				String query = "UPDATE product SET categorycode=?, name =?, brand=?, price=?, quantity=? WHERE productcode=?";
				command = new MySqlCommand(query, connection);
				command.Parameters.AddWithValue("@categorycode", product.getProductCategoryCode());
				command.Parameters.AddWithValue("@name", product.getProductName());
				command.Parameters.AddWithValue("@brand", product.getProductBrand());
				command.Parameters.AddWithValue("@price", product.getProductPrice());
				command.Parameters.AddWithValue("@quantity", product.getProductQuantity());
				command.Parameters.AddWithValue("@productcode", product.getProductCode());
				command.Prepare();
				command.ExecuteNonQuery();
				MessageBox.Show("Product Updated!");
				
			} catch (Exception e) {
				MessageBox.Show("Error: " + e);;
			}
		}
		
		public void deleteProduct(String proCode) {
			try {
				String query ="DELETE FROM product WHERE productcode=?";
				command = new MySqlCommand(query, connection);
				command.Parameters.AddWithValue("@productcode", proCode);
				command.Prepare();
				command.ExecuteNonQuery();
				MessageBox.Show("Product Deleted!");
			} catch (Exception e) {
				MessageBox.Show("Error: " + e);
			}
			connection.Close();
		}
		
		public long productCounter() {
			long counter = 0;
			try {
				String query = "SELECT COUNT(*) FROM product";
				command = new MySqlCommand(query, connection);
				//	counter = Convert.ToInt32(command.ExecuteScalar());
				counter = (long)command.ExecuteScalar();
			} catch (Exception e) {
				MessageBox.Show("Error: " + e);
			}
			return counter;
		}
	}
}
