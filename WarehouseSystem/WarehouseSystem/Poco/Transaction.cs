/*
 * Created by SharpDevelop.
 * User: chris
 * Date: 03/19/2018
 * Time: 17:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace WarehouseSystem.Poco
{
	/// <summary>
	/// Description of Transaction.
	/// </summary>
	public class Transaction
	{
		int productQuantityInDb;
		int quantityToOut;
		double price;
			
			public void setProductQuantityInDb(int productQuantityInDb) {
			this.productQuantityInDb = productQuantityInDb;
		}
		
		public int getProductQuantityInDb() {
			return this.productQuantityInDb;
		}
		
		public void setQuantityToOut(int quantityToOut) {
			this.quantityToOut = quantityToOut;
		}
		
		public int getQuantityToOut() {
			return  this.quantityToOut;
		}
		
		public void setProductPrice(double price) {
			this.price = price;
		}
		
		public double getProductPrice() {
			return this.price;
		}
			
		public int getCurrentQuantity() {
			return productQuantityInDb - quantityToOut;
		}
		
		public double getTotal() {
			return getQuantityToOut() * price;
		}
	}
}
