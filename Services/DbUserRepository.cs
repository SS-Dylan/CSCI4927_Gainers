using System;
using CSCI4927_Gainers.Models.Entities;

namespace CSCI4927_Gainers.Services
{
    public class DbUserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _db;

        public DbUserRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public User Create(User newUser)
        {
            _db.Users.Add(newUser);
            _db.SaveChanges();
            return newUser;
        }

        public User? Read(int id)
        {
            return _db.Users.Find(id);
        }

        public ICollection<User> ReadAll()
        {
            return _db.Users.ToList();
        }

        public void Update(int oldId, User person)
        {
        }
    }
}
