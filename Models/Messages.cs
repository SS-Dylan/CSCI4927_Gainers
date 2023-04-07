using System.ComponentModel.DataAnnotations.Schema;

namespace CSCI4927_Gainers.Models
{
    public class Messages
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string Datetime { get; set; }
        public int FromUserId { get; set; }
        public int ToUserId { get; set; }
    }
}
