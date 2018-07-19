/*
 * Created by SharpDevelop.
 * User: chris
 * Date: 03/23/2018
 * Time: 08:09
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

namespace WarehouseSystem.Views
{
	/// <summary>
	/// Interaction logic for CategoryOpWindow.xaml
	/// </summary>
	public partial class CategoryOpWindow : Window
	{
		ProductCategory productCat;
		ProductCategoryDbUtils productCatDbutils;
		String catCode;
		
		public CategoryOpWindow(String catCode)
		{
			productCat = new ProductCategory();
			productCatDbutils = new ProductCategoryDbUtils();
			
			InitializeComponent();
			this.catCode = catCode;
			code_Textbox.Text = this.catCode;
			
			productCat = productCatDbutils.getProductCategory(this.catCode);
			Description_Textbox.Text = productCat.getCategoryDescription();
			type_Textbox.Text = productCat.getCategoryType();
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
				productCat = new ProductCategory();
				productCatDbutils = new ProductCategoryDbUtils();
				
				
				productCat.setCategoryCode(code_Textbox.Text);
				productCat.setCategoryDescription(Description_Textbox.Text);
				productCat.setCategoryType(type_Textbox.Text);
				productCatDbutils.updateCategory(productCat);
				
				var categoryWindow = new CategoryWindow();
				categoryWindow.Show();
				Hide();
			} catch (Exception) {
				MessageBox.Show("Error");
			}	
		}
		void delete_Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			productCatDbutils = new ProductCategoryDbUtils();
			productCatDbutils.deleteCategory(code_Textbox.Text);
			
			var categoryWindow = new CategoryWindow();
			categoryWindow.Show();
			Hide();
		}
	}
}