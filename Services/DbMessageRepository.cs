using System;
using CSCI4927_Gainers.Models.Entities;

namespace CSCI4927_Gainers.Services
{
    public class DbMessageRepository : IMessageRepository
    {
        private readonly ApplicationDbContext _db;

        public DbMessageRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public Message Create(Message newMessage)
        {
            _db.Messages.Add(newMessage);
            _db.SaveChanges();
            return newMessage;
        }

        public Message? Read(int id)
        {
            return _db.Messages.Find(id);
        }

        public ICollection<Message> ReadAll()
        {
            return _db.Messages.ToList();
        }
    }
}
