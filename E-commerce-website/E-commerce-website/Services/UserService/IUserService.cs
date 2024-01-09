﻿using E_commerce_website.Models.DatabaseEntity;

namespace E_commerce_website.Services.UserService
{
    public interface IUserService
    {
        public string Login(string userName, string userPassword);
        public string Signup(User user);
    }
}
