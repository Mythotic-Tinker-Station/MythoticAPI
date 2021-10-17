/*
    Mythotic API - Users Model Class

    This class is the Database Context for Users.cs. Check Users.cs for the data model
 
*/

using Microsoft.EntityFrameworkCore;

namespace MythoticAPI.Models
{
    public class UsersContext : DbContext
    {
        public UsersContext(DbContextOptions<UsersContext> options) : base(options) 
        {

        }
        public DbSet<User> Users {  get; set; }
    }
}
