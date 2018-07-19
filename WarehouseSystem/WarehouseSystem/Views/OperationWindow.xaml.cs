/*
 * Created by SharpDevelop.
 * User: chris
 * Date: 03/22/2018
 * Time: 13:13
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
using WarehouseSystem.Views;
using WarehouseSystem.Model;
using WarehouseSystem.Poco;

namespace WarehouseSystem.Views
{
	/// <summary>
	/// Interaction logic for OperationWindow.xaml
	/// </summary>
	public partial class OperationWindow : Window
	{
		String productCode;
		ProductDbUtils productDbUtils;
		ProductCategoryDbUtils productCategoryDbUtils;
		ProductCategory productCategory;
		Product product;
		
		public OperationWindow(String productCode)
		{
			product = new Product();
			productDbUtils = new ProductDbUtils();
			
			InitializeComponent();
			this.productCode = productCode;
			code_Textbox.Text = this.productCode;
			
			product = productDbUtils.getProduct(this.productCode);
			
			name_Textbox.Text = product.getProductName();
			brand_Textbox.Text = product.getProductBrand();
			quantity_Textbox.Text =product.getProductQuantity().ToString();
			price_Textbox.Text = product.getProductPrice().ToString();
			categoryid_Textbox.Text = product.getProductCategoryCode();
		}
		void update_Button_MouseEnter(object sender, MouseEventArgs e)
		{
			update_Button.Background = new SolidColorBrush(Color.FromRgb(129,199,132));
		}
		void update_Button_MouseLeave(object sender, MouseEventArgs e)
		{
			update_Button.Background = new SolidColorBrush(Color.FromRgb(76,175,80));
		}
		void delete_Button_MouseEnter(object sender, MouseEventArgs e)
		{
			delete_Button.Background = new SolidColorBrush(Color.FromRgb(255,138,101));
		}
		void delete_Button_MouseLeave(object sender, MouseEventArgs e)
		{
			delete_Button.Background = new SolidColorBrush(Color.FromRgb(255,87,34));
		}
		void update_Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			try {
				productCategoryDbUtils = new ProductCategoryDbUtils();
				productDbUtils = new ProductDbUtils();
				product = new Product();
				productCategory = new ProductCategory();
				
				
				productCategory.setCategoryCode(categoryid_Textbox.Text);
				
				if(productCategoryDbUtils.getCategoryByCode(productCategory) == false) {
					MessageBox.Show("No Category Found! Create First.");
					categoryid_Textbox.Text = "";
				}else {
					product.setProductCode(code_Textbox.Text);
					product.setProductName(name_Textbox.Text);
					product.setProductBrand(brand_Textbox.Text);
					product.setProductQuantity(Int32.Parse(quantity_Textbox.Text));
					product.setProductPrice(Int32.Parse(price_Textbox.Text));
					product.setProductCategoryCode(categoryid_Textbox.Text);
					productDbUtils.updateProduct(product);
					
					var productWindow = new ProductWindow();
					productWindow.Show();
					Hide();
				}
			} catch (Exception) {
				
				MessageBox.Show("Digits only in Quantity and Price!");
			}
			
			
		}
		void delete_Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			productDbUtils = new ProductDbUtils();
			productDbUtils.deleteProduct(code_Textbox.Text);
			
			var productWindow = new ProductWindow();
			productWindow.Show();
			Hide();
		}
	}
}