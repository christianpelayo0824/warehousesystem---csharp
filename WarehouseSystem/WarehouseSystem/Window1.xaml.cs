/*
 * Created by SharpDevelop.
 * User: chris
 * Date: 3/12/2018
 * Time: 2:32 PM
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
using WarehouseSystem.Views;


namespace WarehouseSystem
{

	public partial class Window1 : Window
	{
		UserDbUtils userDbUtils = new UserDbUtils();
		
		public Window1()
		{
			InitializeComponent();
		}
		
		void register_Button_Click(object sender, RoutedEventArgs e)
		{
			var registerForm = new Register();
			registerForm.Show();
		}
		void createAcount_Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var register = new Register();
			register.Show();
		}
		void createAcount_Button_MouseEnter(object sender, MouseEventArgs e)
		{
			createAcount_Button.Background = new SolidColorBrush(Color.FromRgb(255,138,101));
		}
		void createAcount_Button_MouseLeave(object sender, MouseEventArgs e)
		{
			createAcount_Button.Background = new SolidColorBrush(Color.FromRgb(255,87,34));
		}
		void signIn_Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var user = new User();
			user.setUsername(username_Textbox.Text);
			user.setPassword(password_Textbox.Password);
			
			if (username_Textbox.Text == "" || password_Textbox.Password == "") {
				MessageBox.Show("Dont leave empty!");
			} else {
				if (userDbUtils.getCredentials(user) == false) {
					MessageBox.Show("Error");
				} else {
					MainWindow mainWindow = new MainWindow();
					mainWindow.getUserConnection(username_Textbox.Text,  password_Textbox.Password);
					mainWindow.Show();
					Hide();
				}
			}
		}
		void signIn_Button_MouseEnter(object sender, MouseEventArgs e)
		{
			signIn_Button.Background = new SolidColorBrush(Color.FromRgb(100,181,246));
		}
		void signIn_Button_MouseLeave(object sender, MouseEventArgs e)
		{
			signIn_Button.Background = new SolidColorBrush(Color.FromRgb(33,150,243));
		}
		void contact_Button_Click(object sender, RoutedEventArgs e)
		{
			var contactWindow = new ContactWindow();
			contactWindow.Show();
		}
		
	}
}