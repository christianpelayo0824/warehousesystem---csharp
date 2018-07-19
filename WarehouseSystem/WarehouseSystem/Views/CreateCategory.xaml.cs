/*
 * Created by SharpDevelop.
 * User: chris
 * Date: 03/18/2018
 * Time: 05:20
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
	/// <summary>
	/// Interaction logic for CreateCategory.xaml
	/// </summary>
	public partial class CreateCategory : Window
	{
		ProductCategoryDbUtils productCatDbutils;
		
		public CreateCategory()
		{
			InitializeComponent();
		}
		void create_Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			productCatDbutils = new ProductCategoryDbUtils();
			var productCategory = new ProductCategory();
			productCategory.setCategoryCode(categorycode_Textbox.Text);
			productCategory.setCategoryDescription(description_Textbox.Text);
			productCategory.setCategoryType(type_Textbox.Text);
			productCatDbutils.createProductCategory(productCategory);
			Hide();
			MessageBox.Show("Created");
		}
		void create_Button_MouseEnter(object sender, MouseEventArgs e)
		{
			create_Button.Background = new SolidColorBrush(Color.FromRgb(255,138,101));
		}
		void create_Button_MouseLeave(object sender, MouseEventArgs e)
		{
			create_Button.Background = new SolidColorBrush(Color.FromRgb(255,87,34));
		}
	}
}