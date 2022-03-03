using System;
using System.Collections.Generic;

namespace ECommerce_2022.Models
{
	public class Product
	{
		public int productID { get; set; }
		public string productName { get; set; }
		public double price { get; set; }
		public bool inCart { get; set; }
		public bool isPurchased { get; set; }


		

		public Product()
		{

		}
	}
}

