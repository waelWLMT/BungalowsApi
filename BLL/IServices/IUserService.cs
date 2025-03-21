﻿using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IServices
{
    public interface IUserService : IServicePattern<User>
    {
        public User GetUserByLoginOrEmail(string loginOrEmail);

    }
}
