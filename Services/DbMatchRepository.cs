using System;
using CSCI4927_Gainers.Models.Entities;

namespace CSCI4927_Gainers.Services
{
    public class DbMatchRepository : IMatchRepository
    {
        private readonly ApplicationDbContext _db;

        public DbMatchRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public Match Create(Match newMatch)
        {
            _db.Matches.Add(newMatch);
            _db.SaveChanges();
            return newMatch;
        }

        public Match? Read(int id)
        {
            return _db.Matches.Find(id);
        }

        public ICollection<Match> ReadAll()
        {
            return _db.Matches.ToList();
        }
    }
}
