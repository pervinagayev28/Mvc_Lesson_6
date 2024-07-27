using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class DbContext
    {
        public static List<User> Users { get; set; } = new List<User>();
    }
}
