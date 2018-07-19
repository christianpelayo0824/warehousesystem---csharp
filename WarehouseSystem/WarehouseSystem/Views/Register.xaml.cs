/*
 * Created by SharpDevelop.
 * User: chris
 * Date: 03/16/2018
 * Time: 00:11
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

namespace WarehouseSystem
{
	public partial class Register : Window
	{
		Model.UserDbUtils userDbutils;
		
		public Register()
		{
			InitializeComponent();
			userDbutils = new Model.UserDbUtils();
		}
		
		void create_Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			if (firstname_Textbox.Text == "" || lastname_Textbox.Text == ""
			    || email_Textbox.Text == "" || username_Textbox.Text == ""
			    || password_Textbox.Password == "") {
				MessageBox.Show("Dont leave blank!");
			} else {
				var user = new User();
				user.setFirstname(firstname_Textbox.Text);
				user.setLastname(lastname_Textbox.Text);
				user.setEmail(email_Textbox.Text);
				user.setUsername(username_Textbox.Text);
				user.setPassword(password_Textbox.Password);
				userDbutils.createUserAdmin(user);
				Close();
			}
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