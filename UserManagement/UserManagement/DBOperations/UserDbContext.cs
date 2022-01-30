using Microsoft.EntityFrameworkCore;

namespace UserManagement.DBOperations
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {

        }
    }
}
