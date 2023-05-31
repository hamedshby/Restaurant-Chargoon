﻿namespace RestaurantChargoon.Domain.Entities
{
	public class User : BaseEntity
	{       
        public string Name { get; set; }
		public string LastName { get; set; }
		public string NationalCode { get; set; }
		public string Address { get; set; }
		public string Password { get; set; }
		public UserType UserType { get; set; }
	}

	public enum UserType
	{
		User = 1,
		RestaurantManager = 2
	}
}
