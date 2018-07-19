/*
 * Created by SharpDevelop.
 * User: chris
 * Date: 03/15/2018
 * Time: 09:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace WarehouseSystem.Poco
{
	public class User
	{
		int userid;
		String firstname;
		String lastname;
		String email;
		String username;
		String password;
		
		public void setUserId(int userid)
		{
			this.userid = userid;
		}
		
		public int getUserId()
		{
			return this.userid;
		}
		
		public void setFirstname(String firstname)
		{
			this.firstname = firstname;
		}
		
		public String getFirstname()
		{
			return this.firstname;
		}
		
		public void setLastname(String lastname)
		{
			this.lastname = lastname;
		}
		
		
		public String getLastname()
		{
			return this.lastname;
		}
		
		public void setEmail(String email)
		{
			this.email = email;
		}
		
		public String getEmail()
		{
			return this.email;
		}
		
		public void setUsername(String username)
		{
			this.username = username;
		}
		
		public String getUsername()
		{
			return this.username;
		}
		
		public void setPassword(String password)
		{
			this.password = password;
		}
		
		public String getPassword()
		{
			return this.password;
		}
	}
}
