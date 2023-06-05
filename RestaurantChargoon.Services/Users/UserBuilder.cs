using FluentResults;
using RestaurantChargoon.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantChargoon.Services.Users
{
    public class UserBuilder
    {
        private readonly Result<User> UserResult=new Result<User>();
        private readonly User user=new User();
		public UserBuilder GetName(string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				UserResult.WithError("لطفا نام را وارد کنید");
			}
			else
				user.Name = name;
			return this;
		}
		public UserBuilder GetFamily(string family)
		{
			if (string.IsNullOrEmpty(family))
			{
				UserResult.WithError("لطفا نام خانوادگی  را وارد کنید");
			}
			else
				user.LastName = family;
			return this;
		}

		public UserBuilder GetNationalCode(string NationalCode)
		{
			if (string.IsNullOrEmpty(NationalCode))
			{
				UserResult.WithError("لطفا کدملی  را وارد کنید");
			}
			else
				user.NationalCode = NationalCode;
			return this;
		}
		public UserBuilder GetPassword(string Password)
		{
			if (string.IsNullOrEmpty(Password))
			{
				UserResult.WithError("لطفا رمز عبور  را وارد کنید");
			}
			else
				user.Password = Password;
			return this;
		} 
	}
}
