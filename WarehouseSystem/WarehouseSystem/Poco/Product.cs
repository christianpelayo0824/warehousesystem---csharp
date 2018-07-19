/*
 * Created by SharpDevelop.
 * User: chris
 * Date: 03/15/2018
 * Time: 09:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace WarehouseSystem.Model
{
	public class Product
	{
		int productId;
		String productCode;
		String productCategoryCode;
		String productName;
		String productBrand;
		int productPrice;
		int productQuantity;
		
		public void setProductCode(String productCode) {
			this.productCode = productCode;
		}
		
		public String getProductCode() {
			return this.productCode;
		}
		
		public void setProductId(int productId) {
			this.productId = productId;
		}
		
		public int getProductId() {
			return this.productId;
		}
		
		public void setProductCategoryCode(String productCategoryId) {
			this.productCategoryCode = productCategoryId;
		}
		
		public String getProductCategoryCode() {
			return this.productCategoryCode;
		}
		
		public void setProductName(String productName) {
			this.productName = productName;
		}
		
		public String getProductName() {
			return this.productName;
		}
		
		
		public void setProductBrand(String productBrand) {
			this.productBrand = productBrand;
		}
		
		
		public String getProductBrand() {
			return this.productBrand;
		}
		
		public void setProductPrice(int productPrice) {
			this.productPrice = productPrice;
		}
		
		public int getProductPrice() {
			return this.productPrice;
		}
		
		public void setProductQuantity(int productQuantity) {
			this.productQuantity = productQuantity;
		}
		
		public int getProductQuantity() {
			return this.productQuantity;
		}
		
	}
}
