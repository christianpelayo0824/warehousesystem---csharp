/*
 * Created by SharpDevelop.
 * User: chris
 * Date: 03/21/2018
 * Time: 20:14
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
	/// Interaction logic for TransactionControl.xaml
	/// </summary>
	public partial class TransactionControl : UserControl
	{
		public TransactionControl()
		{
			InitializeComponent();
		}
		void share_Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			ContactWindow contactWindow = new ContactWindow();
			contactWindow.Show();
		}
		void inItem_Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			InItemWindow inItemWindow = new InItemWindow();
			inItemWindow.Show();
		}
		void outItem_Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			OutItemWindow outItemWindow = new OutItemWindow();
			outItemWindow.Show();
		}
		void outItem_Button_MouseEnter(object sender, MouseEventArgs e)
		{
			outItem_Button.Background = new SolidColorBrush(Color.FromRgb(121,134,203));
		}
		void outItem_Button_MouseLeave(object sender, MouseEventArgs e)
		{
			outItem_Button.Background = new SolidColorBrush(Color.FromRgb(63,81,181));
		}
		void inItem_Button_MouseEnter(object sender, MouseEventArgs e)
		{
			inItem_Button.Background = new SolidColorBrush(Color.FromRgb(121,134,203));
		}
		void inItem_Button_MouseLeave(object sender, MouseEventArgs e)
		{
			inItem_Button.Background = new SolidColorBrush(Color.FromRgb(63,81,181));
		}
		
	}
}