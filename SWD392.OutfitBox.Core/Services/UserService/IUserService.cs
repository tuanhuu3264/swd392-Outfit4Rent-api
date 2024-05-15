﻿using SWD392.OutfitBox.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD392.OutfitBox.Core.Services.UserService
{
    public interface IUserService
    {
       public Task<List<User>> GetAllUsers();   
       
       public Task<User> GetUserById(int id);
       
       public Task<User> CreateUser(User user);

       public Task<User> UpdateUser(User user);
       
       public Task<User> ActiveAndDeactiveUser(int id);
    }
}
