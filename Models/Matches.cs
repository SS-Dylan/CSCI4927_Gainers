using System.ComponentModel.DataAnnotations.Schema;

namespace CSCI4927_Gainers.Models
{
    public class Matches
    {
        public int Id { get; set; }
        public bool MatchChoice { get; set; }
        public int MatchId { get; set; }
    }
}
