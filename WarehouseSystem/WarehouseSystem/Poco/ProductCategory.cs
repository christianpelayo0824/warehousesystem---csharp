/*
 * Created by SharpDevelop.
 * User: chris
 * Date: 03/18/2018
 * Time: 04:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace WarehouseSystem.Poco
{
	/// <summary>
	/// Description of ProductCategory.
	/// </summary>
	public class ProductCategory
	{
		int categoryId;
		String categoryCode;
		String categoryDescription;
		String categoryType;
		
		public void setCategoryId(int categoryId) {
			this.categoryId = categoryId;
		}
		
		public int getCategoryId() {
			return this.categoryId;
		}
		
		public void setCategoryCode(String categoryCode) {
			this.categoryCode = categoryCode;
		}
		
		public String getCategoryCode() {
			return this.categoryCode;
		}
		
		public void setCategoryDescription(String categoryDescription) {
			this.categoryDescription = categoryDescription;
		}
		
		public String getCategoryDescription() {
			return this.categoryDescription;
		}
		
		public void setCategoryType(String categoryType) {
			this.categoryType = categoryType;
		}
		
		public String getCategoryType() {
			return this.categoryType;
		}
	}
}
