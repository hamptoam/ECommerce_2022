using System;
using System.Collections.Generic;

namespace ECommerce_2022.Models
{
	public class User
	{
		public int ID { get; set; }
		public string lasName { get; set; }
		public string firstName { get; set; }
		public string email { get; set; }
		public bool isRewardsMember { get; set; }
		public bool isGuest { get; set; }
		public DateTime EnrollmentDate { get; set; }

		public ICollection<Product> Products { get; set; }



		//think of more, like bool isDiscount, etc.


		public User()
		{

		}
	}
}
