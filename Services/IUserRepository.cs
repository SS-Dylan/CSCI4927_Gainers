using System;
using CSCI4927_Gainers.Models.Entities;

namespace CSCI4927_Gainers.Services
{
    public interface IUserRepository
    {
        User Create(User newPerson);
        User? Read(int id);
        ICollection<User> ReadAll();
        void Update(int oldId, User user);
    }
}
