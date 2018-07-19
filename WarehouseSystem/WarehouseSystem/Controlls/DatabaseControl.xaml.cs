/*
 * Created by SharpDevelop.
 * User: chris
 * Date: 03/21/2018
 * Time: 20:38
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

namespace WarehouseSystem.Controlls
{
	/// <summary>
	/// Interaction logic for DatabaseControl.xaml
	/// </summary>
	public partial class DatabaseControl : UserControl
	{
		public DatabaseControl()
		{
			InitializeComponent();
		}
		void share_Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var contactWindow = new ContactWindow();
			contactWindow.Show();
		}
		void product_Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var productWindow = new ProductWindow();
			productWindow.Show();
		}
		void category_Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var categoryWindow = new CategoryWindow();
			categoryWindow.Show();
		}
		void product_Button_MouseEnter(object sender, MouseEventArgs e)
		{
			product_Button.Background = new SolidColorBrush(Color.FromRgb(77,182,172));
		}
		void product_Button_MouseLeave(object sender, MouseEventArgs e)
		{
			product_Button.Background = new SolidColorBrush(Color.FromRgb(0,150,136));
		}
		void category_Button_MouseEnter(object sender, MouseEventArgs e)
		{
			category_Button.Background = new SolidColorBrush(Color.FromRgb(77,182,172));
		}
		void category_Button_MouseLeave(object sender, MouseEventArgs e)
		{
			category_Button.Background = new SolidColorBrush(Color.FromRgb(0,150,136));
		}
	}
}