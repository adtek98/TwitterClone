namespace TwitterWebAPI.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ProfilePicture { get; set; }
        public List<User> Following { get; set; } = new List<User>();
        public List<User> Followers { get; set; } = new List<User>();

        public User(string name, string username, string password)
        {
            Id = username;
            Name = name;
            Username = username;
            Password = BCrypt.Net.BCrypt.HashPassword(password);
        }

    }
}
