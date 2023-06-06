using FluentResults;
using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RestaurantChargoon.Services.Users
{
    public class UserBuilder
    {
        private readonly Result<User> UserResult = new Result<User>();
        private readonly User user = new User();
        private readonly UserService userService = new UserService();
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
            else if (!(Regex.IsMatch(NationalCode, @"^\d{10,}$")))
            {
                UserResult.WithError("اندازه کد ملی باید 10 رقم باشد");

            }
            else if(userService.GetByNationalCode(NationalCode) != null)
            {
                UserResult.WithError("این کاربر وجود دارد");
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
            else if (!(Regex.IsMatch(Password, @"^[a-zA-Z0-9]{5,}$")))
            {
                UserResult.WithError("رمز عبور باید حداقل 5 کاراکتر و شامل حرف و عدد باشد");

            }
            else
                user.Password = Password;
            return this;
        }
        public UserBuilder GetAddress(string Address)
        {
            if (string.IsNullOrEmpty(Address))
            {
                UserResult.WithError("لطفا آدرس  را وارد کنید");
            }
            else
                user.Address = Address;
            return this;
        }
        public UserBuilder GetUserType(UserType userType)
        {
           
           
                user.UserType =userType ;
            return this;
        }


        public Result<User> Build()
        {
            if (UserResult.IsSuccess)
                UserResult.WithValue(user);
            return UserResult;
        }
    }
}
