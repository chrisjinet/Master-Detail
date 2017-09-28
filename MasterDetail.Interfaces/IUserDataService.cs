﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterDetail.Business.Entities;

namespace MasterDetail.Interfaces
{
    /// <summary>
    /// IUserDataService
    /// </summary>
    public interface IUserDataService : IDataRepository, IDisposable
    {
        void CreateUser(User user);
        void UpdateUser(User user);
        User GetUser(string emailAddress);
        User GetUser(int userID);
    }
}
