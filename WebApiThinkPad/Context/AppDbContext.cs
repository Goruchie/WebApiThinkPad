using Microsoft.EntityFrameworkCore;
using WebApiThinkPad.Models;

namespace WebApiThinkPad.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<ThinkPad> ThinkPads { get; set; }
    }
}
