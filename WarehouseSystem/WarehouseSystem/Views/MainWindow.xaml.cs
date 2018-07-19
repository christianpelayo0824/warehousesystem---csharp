/*
 * Created by SharpDevelop.
 * User: chris
 * Date: 03/16/2018
 * Time: 01:44
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
using WarehouseSystem.Controlls;
using WarehouseSystem.Model;
using WarehouseSystem.Poco;

namespace WarehouseSystem
{
	public partial class MainWindow : Window
	{
		
		DashboardControl dashboardControl = new DashboardControl();
		DatabaseControl databaseControl = new DatabaseControl();
		TransactionControl transactionControl = new TransactionControl();
		DevelopersControl developerControl = new DevelopersControl();
		
		public MainWindow()
		{
			InitializeComponent();
			setDashboardActive();
			mainDockPanel.Children.Add(dashboardControl);
		}
		
		public void getUserConnection(String user, String name) {

			var userConn = new UserDbUtils();
			var userPoco = new User();
			userPoco = userConn.getUserConn(user, name);
			user_Label.Content = userPoco.getFirstname() + " " +userPoco.getLastname();
	
		}
		
		public void setDashboardActive() {
			dashboard_Active.Background = new SolidColorBrush(Color.FromRgb(33,150,243));
			transaction_Active.Background = new SolidColorBrush(Color.FromRgb(38,50,56));
			database_Active.Background = new SolidColorBrush(Color.FromRgb(38,50,56));
			developer_Active.Background = new SolidColorBrush(Color.FromRgb(38,50,56));
		}
		
		public void setTransactionActive() {
			dashboard_Active.Background = new SolidColorBrush(Color.FromRgb(38,50,56));
			transaction_Active.Background = new SolidColorBrush(Color.FromRgb(33,150,243));
			database_Active.Background = new SolidColorBrush(Color.FromRgb(38,50,56));
			developer_Active.Background = new SolidColorBrush(Color.FromRgb(38,50,56));
		}
		
		public void setDatabaseActive() {
			dashboard_Active.Background = new SolidColorBrush(Color.FromRgb(38,50,56));
			transaction_Active.Background = new SolidColorBrush(Color.FromRgb(38,50,56));
			database_Active.Background = new SolidColorBrush(Color.FromRgb(33,150,243));
			developer_Active.Background = new SolidColorBrush(Color.FromRgb(38,50,56));
		}
		
		public void setDeveloperActive() {
			dashboard_Active.Background = new SolidColorBrush(Color.FromRgb(38,50,56));
			transaction_Active.Background = new SolidColorBrush(Color.FromRgb(38,50,56));
			database_Active.Background = new SolidColorBrush(Color.FromRgb(38,50,56));
			developer_Active.Background = new SolidColorBrush(Color.FromRgb(33,150,243));
		}
		
		void developer_Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			setDeveloperActive();
			mainDockPanel.Children.Clear();
			mainDockPanel.Children.Add(developerControl);
		}
		void database_Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			setDatabaseActive();
			mainDockPanel.Children.Clear();
			mainDockPanel.Children.Add(databaseControl);
		}
		void transaction_Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			setTransactionActive();
			mainDockPanel.Children.Clear();
			mainDockPanel.Children.Add(transactionControl);
		}
		void dashboard_Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			setDashboardActive();
			mainDockPanel.Children.Clear();
			mainDockPanel.Children.Add(dashboardControl);
			
			
			dashboardControl.updateCounter(1);
		}
		void logout_Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			Window1 window = new Window1();
			window.Show();
			Hide();
		}
		void logout_Button_MouseEnter(object sender, MouseEventArgs e)
		{
			logout_Button.Background = new SolidColorBrush(Color.FromRgb(100,181,246));
		}
		void dashboard_Button_MouseEnter(object sender, MouseEventArgs e)
		{
			dashboard_Button.Background = new SolidColorBrush(Color.FromRgb(55,71,79));
		}
		void dashboard_Button_MouseLeave(object sender, MouseEventArgs e)
		{
			dashboard_Button.Background = new SolidColorBrush(Color.FromRgb(38,50,56));
		}
		void transaction_Button_MouseEnter(object sender, MouseEventArgs e)
		{
			transaction_Button.Background = new SolidColorBrush(Color.FromRgb(55,71,79));
		}
		void transaction_Button_MouseLeave(object sender, MouseEventArgs e)
		{
			transaction_Button.Background = new SolidColorBrush(Color.FromRgb(38,50,56));
		}
		void database_Button_MouseEnter(object sender, MouseEventArgs e)
		{
			database_Button.Background = new SolidColorBrush(Color.FromRgb(55,71,79));
		}
		void database_Button_MouseLeave(object sender, MouseEventArgs e)
		{
			database_Button.Background = new SolidColorBrush(Color.FromRgb(38,50,56));
		}
		void developer_Button_MouseEnter(object sender, MouseEventArgs e)
		{
			developer_Button.Background = new SolidColorBrush(Color.FromRgb(55,71,79));
		}
		void developer_Button_MouseLeave(object sender, MouseEventArgs e)
		{
			developer_Button.Background = new SolidColorBrush(Color.FromRgb(38,50,56));
		}
		void logout_Button_MouseLeave(object sender, MouseEventArgs e)
		{
			logout_Button.Background = new SolidColorBrush(Color.FromRgb(33,150,243));
		}
	}

}