using SmartCRM.Models;

namespace SmartCRM.Services
{
    public class AuthService
    {
        private List<User> users = new()
        {
            new User { Username = "admin", Password = "1234" }
        };

        public User? Validate(string username, string password)
        {
            return users.FirstOrDefault(u =>
                u.Username == username && u.Password == password);
        }
    }
}