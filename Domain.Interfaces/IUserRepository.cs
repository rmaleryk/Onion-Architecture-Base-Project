using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();

        User GetById(Guid id);

        User Add(User user);

        User Update(User user);

        void Delete(User user);
    }
}