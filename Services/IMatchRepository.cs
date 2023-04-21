using System;
using CSCI4927_Gainers.Models.Entities;

namespace CSCI4927_Gainers.Services
{
    public interface IMatchRepository
    {
        Match Create(Match newMatch);
        Match? Read(int id);
        ICollection<Match> ReadAll();
    }
}
