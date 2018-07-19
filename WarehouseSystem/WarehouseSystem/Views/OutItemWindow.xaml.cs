/*
 * Created by SharpDevelop.
 * User: chris
 * Date: 03/17/2018
 * Time: 23:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using WarehouseSystem.Poco;
using WarehouseSystem.Model;

namespace WarehouseSystem
{
	public partial class OutItemWindow : Window
	{

		Transaction transaction;
		Product product;
		ProductDbUtils productDbUtils;
		ProductCategory productCategory;
		
		public OutItemWindow()
		{
			InitializeComponent();
		}
		
		void search_Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var productDbUtils1 = new ProductDbUtils();
			var productDbUtils2 = new ProductDbUtils();
			var productCategoryDbUtils = new ProductCategoryDbUtils();
			
			if (productcode_Textbox.Text == "") {
				MessageBox.Show("Dont leave empty!");
			} else {
				if (productDbUtils1.getProductByCode(productcode_Textbox.Text) == true) {
					product = new Product();
					productCategory = new ProductCategory();
					product = productDbUtils2.getProduct(productcode_Textbox.Text);
					productCategory = productCategoryDbUtils.getProductCategory(product.getProductCategoryCode());
					
					costumer_Reciept.Text = firstname_TextBox.Text + " " + lastname_TextBox.Text;
					contact_Reciept.Text = contact_Textbox.Text;
					name_Reciept.Text = product.getProductName();
					brand_Reciept.Text = product.getProductBrand();
					description_Reciept.Text = productCategory.getCategoryDescription();
					type_Reciept.Text = productCategory.getCategoryType();
					price_Reciept.Text = product.getProductPrice().ToString();
				} else {
					MessageBox.Show("No Product found!");
				}
			}
		}
		void checkOut_Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			productDbUtils = new ProductDbUtils();
			transaction = new Transaction();
			if (quantity_Textbox.Text == "" || firstname_TextBox.Text == "" ||
			    lastname_TextBox.Text == "" || contact_Textbox.Text == "" || address_Textbox.Text == "") {
				MessageBox.Show("Dont leave blank!");
			} else {
				try {
					product = new Product();
					
					product = productDbUtils.getProduct(productcode_Textbox.Text);
					if (product.getProductQuantity() < Int32.Parse(quantity_Textbox.Text)) {
						MessageBox.Show("There is no enough stock!");
					} else {
						transaction.setQuantityToOut(Int32.Parse(quantity_Textbox.Text));
						transaction.setProductPrice(product.getProductPrice());
						
						total_Reciept.Text = "P " + transaction.getTotal().ToString();
						quantity_Reciept.Text = quantity_Textbox.Text;
					}
					
				} catch (Exception) {
					
					MessageBox.Show("Digits only in Quantity!");
				}
				
			}
		}
		void search_Button_MouseEnter(object sender, MouseEventArgs e)
		{
			search_Button.Background = new SolidColorBrush(Color.FromRgb(100,181,246));
		}
		void search_Button_MouseLeave(object sender, MouseEventArgs e)
		{
			search_Button.Background = new SolidColorBrush(Color.FromRgb(33,150,243));
		}
		void checkOut_Button_MouseEnter(object sender, MouseEventArgs e)
		{
			checkOut_Button.Background = new SolidColorBrush(Color.FromRgb(100,181,246));
		}
		void checkOut_Button_MouseLeave(object sender, MouseEventArgs e)
		{
			checkOut_Button.Background = new SolidColorBrush(Color.FromRgb(33,150,243));
		}
		void buy_Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			productDbUtils = new ProductDbUtils();
			product = new Product();
			
			var product2 = new Product();
			var productDbUtils2 = new ProductDbUtils();
			
			if (name_Reciept.Text == "" || contact_Reciept.Text == "" ||
			    name_Reciept.Text == "" || brand_Reciept.Text == "" ||
			    description_Reciept.Text == "" || type_Reciept.Text == "" ||
			    price_Reciept.Text == "" || quantity_Reciept.Text == "" || total_Reciept.Text == "") {
				
				MessageBox.Show("Verify first before buying!");
			}else {
				try {
					product = productDbUtils.getProduct(productcode_Textbox.Text);
					
					transaction.setProductQuantityInDb(product.getProductQuantity());
					transaction.setQuantityToOut(Int32.Parse(quantity_Textbox.Text));

					product2.setProductCode(productcode_Textbox.Text);
					product2.setProductQuantity(transaction.getCurrentQuantity());
					productDbUtils2.updateCurrentQuantity(product2);
					Hide();
				} catch (Exception) {
					
					MessageBox.Show("Digits only Quantity!");
				}
				
			}
		}
		void buy_Button_MouseEnter(object sender, MouseEventArgs e)
		{
			buy_Button.Background = new SolidColorBrush(Color.FromRgb(255,138,101));
		}
		void buy_Button_MouseLeave(object sender, MouseEventArgs e)
		{
			buy_Button.Background = new SolidColorBrush(Color.FromRgb(255,87,34));
		}
		
	}
}