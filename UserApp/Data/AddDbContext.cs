using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserApp.Models;

namespace UserApp.Data
{
    public class AddDbContext : IdentityDbContext<Users>
    {
        public AddDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
