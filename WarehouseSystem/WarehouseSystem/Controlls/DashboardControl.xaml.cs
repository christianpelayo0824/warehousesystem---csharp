/*
 * Created by SharpDevelop.
 * User: chris
 * Date: 03/21/2018
 * Time: 20:59
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

namespace WarehouseSystem.Controlls
{
	/// <summary>
	/// Interaction logic for DashboardControl.xaml
	/// </summary>
	public partial class DashboardControl : UserControl
	{
		ProductDbUtils productDbutils;
		ProductCategoryDbUtils productCategoryUtils;
		
		public DashboardControl()
		{
			InitializeComponent();
			productDbutils = new ProductDbUtils();
			productCategoryUtils = new ProductCategoryDbUtils();
			long product = productDbutils.productCounter();
			long category = productCategoryUtils.categoryCounter();
			productCount.Content = product.ToString();
			categoryCount.Content = category.ToString();
		}
		
		public void updateCounter(int connection) {
			if(connection == 1) {
				productDbutils = new ProductDbUtils();
				productCategoryUtils = new ProductCategoryDbUtils();
				long product = productDbutils.productCounter();
				long category = productCategoryUtils.categoryCounter();
				productCount.Content = product.ToString();
				categoryCount.Content = category.ToString();
			}
		}
		
		void image1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var contactWindow = new ContactWindow();
			contactWindow.Show();
		}
	}
}