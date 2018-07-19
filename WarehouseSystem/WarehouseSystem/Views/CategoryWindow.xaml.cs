/*
 * Created by SharpDevelop.
 * User: chris
 * Date: 03/22/2018
 * Time: 12:19
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
using System.Data;
using WarehouseSystem.Model;
using WarehouseSystem.Poco;

namespace WarehouseSystem.Views
{

	public partial class CategoryWindow : Window
	{
		ProductCategoryDbUtils productCategoryDbUtils;
		ProductCategory productCategory;
		
		public CategoryWindow()
		{
			InitializeComponent();
			productCategoryDbUtils = new ProductCategoryDbUtils();
			category_DataGrid.ItemsSource = productCategoryDbUtils.getAllCategory().DefaultView;
		}
		void search_Button_MouseEnter(object sender, MouseEventArgs e)
		{
			search_Button.Background = new SolidColorBrush(Color.FromRgb(100,181,246));
		}
		void search_Button_MouseLeave(object sender, MouseEventArgs e)
		{
			search_Button.Background = new SolidColorBrush(Color.FromRgb(33,150,243));
		}
		void search_Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			if(categoryCode_Textbox.Text == "") {
				MessageBox.Show("Dont leave blank!");
			}else {
				productCategoryDbUtils = new ProductCategoryDbUtils();
				productCategory =new ProductCategory();
				productCategory.setCategoryCode(categoryCode_Textbox.Text);
				
				if(productCategoryDbUtils.getCategoryByCode(productCategory) == false) {
					MessageBox.Show("Category not found!");
				}else {
					var categoryOpWindow =new CategoryOpWindow(categoryCode_Textbox.Text);
					Close();
					categoryOpWindow.Show();
				}		
			}
		}
	}
}