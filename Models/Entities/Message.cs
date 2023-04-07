using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCI4927_Gainers.Models.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Datetime { get; set; }
        public int FromUserId { get; set; }
        public int ToUserId { get; set; }
    }
}
