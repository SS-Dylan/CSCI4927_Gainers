namespace CSCI4927_Gainers.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ProfilePictureUrl { get; set; }
        public int Squats { get; set; }
        public int Bench { get; set; }
        public int Deadlift { get; set; }
        public string Bio { get; set; }
    }
}
