/*
 * Created by SharpDevelop.
 * User: chris
 * Date: 03/18/2018
 * Time: 03:45
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
using WarehouseSystem.Model;
using WarehouseSystem.Poco;


namespace WarehouseSystem
{
	public partial class InItemWindow : Window
	{
		public InItemWindow()
		{
			InitializeComponent();
		}

		void add_Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			if(supplier_Summary.Text == "" ||
			   contact_Summary.Text == "" ||
			   code_Summary.Text == "" ||
			   name_Summary.Text == "" ||
			   brand_Summary.Text == "" ||
			   quantity_Summary.Text == "" ||
			   price_Summary.Text == "" ||
			   categoryid_Summary.Text == ""
			  ) {
				MessageBox.Show("Verfify first before cheking!");
			}else {
				try {
					var productDbutils = new ProductDbUtils();
					var product= new Product();
					product.setProductCode(code_Textbox.Text);
					product.setProductName(name_Textbox.Text);
					product.setProductBrand(brand_Textbox.Text);
					product.setProductPrice(Int32.Parse(price_Textbox.Text));
					product.setProductQuantity(Int32.Parse(quantity_Textbox.Text));
					product.setProductCategoryCode(categoryid_Textbox.Text);
					productDbutils.createProduct(product);
					Hide();
				} catch (Exception) {
					
					MessageBox.Show("Digits only in Quantity and Price");
				}
				
			}
		}
		void verify_Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var productCategoryDbutils = new ProductCategoryDbUtils();
			var productCategory = new ProductCategory();
			
			productCategory.setCategoryCode(categoryid_Textbox.Text);
			
			if(productCategoryDbutils.getCategoryByCode(productCategory) == false) {
				var createCategory = new CreateCategory();
				createCategory.Show();
				MessageBox.Show("Category not exist! Create category");
			}else {
				
				productCategory = productCategoryDbutils.getProductCategory(categoryid_Textbox.Text);
				description_Summary.Text = productCategory.getCategoryDescription();
				type_Summary.Text = productCategory.getCategoryType();
				
				supplier_Summary.Text = firstname_Textbox.Text + " "+ lastname_Textbox.Text;
				contact_Summary.Text = contact_Textbox.Text;
				code_Summary.Text = code_Textbox.Text;
				name_Summary.Text = name_Textbox.Text;
				brand_Summary.Text = name_Textbox.Text;
				quantity_Summary.Text = quantity_Textbox.Text;
				price_Summary.Text = price_Textbox.Text;
				categoryid_Summary.Text = categoryid_Textbox.Text;
			}
		}
		void verify_Button_MouseEnter(object sender, MouseEventArgs e)
		{
			verify_Button.Background = new SolidColorBrush(Color.FromRgb(100,181,246));
		}
		void verify_Button_MouseLeave(object sender, MouseEventArgs e)
		{
			verify_Button.Background = new SolidColorBrush(Color.FromRgb(33,150,243));
		}
		void add_Button_MouseEnter(object sender, MouseEventArgs e)
		{
			add_Button.Background = new SolidColorBrush(Color.FromRgb(255,138,101));
		}
		void add_Button_MouseLeave(object sender, MouseEventArgs e)
		{
			add_Button.Background = new SolidColorBrush(Color.FromRgb(255,87,34));
		}
	}
}