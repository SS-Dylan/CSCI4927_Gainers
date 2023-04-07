using Microsoft.EntityFrameworkCore;
using System;
using CSCI4927_Gainers.Models.Entities;

namespace CSCI4927_Gainers.Services
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Match> Matches => Set<Match>();
        public DbSet<Message> Messages => Set<Message>();

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
