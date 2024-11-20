using Microsoft.EntityFrameworkCore;
using Poc_Password_hashing.Models;

namespace Poc_Password_hashing.Data
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }
    }
}
