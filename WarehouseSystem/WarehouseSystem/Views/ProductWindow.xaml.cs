/*
 * Created by SharpDevelop.
 * User: chris
 * Date: 03/20/2018
 * Time: 00:21
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
using WarehouseSystem.Views;

namespace WarehouseSystem
{
	public partial class ProductWindow : Window
	{
		ProductDbUtils productDbUtils;
		Product product;

		public ProductWindow()
		{
			InitializeComponent();
			productDbUtils =new ProductDbUtils();
			product_DataGrid.ItemsSource = productDbUtils.getAllProducts().DefaultView;
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

			if(productCode_Textbox.Text == "") {
				MessageBox.Show("Dont leave blank");
			}else {
				productDbUtils = new ProductDbUtils();
				
				if(productDbUtils.getProductByCode(productCode_Textbox.Text) == false) {
					MessageBox.Show("Product not found!");
				}else {
					var operationWindow= new OperationWindow(productCode_Textbox.Text);
					Close();
					operationWindow.Show();
				}
			}
		}
		
	}
}