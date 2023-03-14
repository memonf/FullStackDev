using API.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class ToDoDbContext : DbContext
    {
        public ToDoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<List> List { get; set; }
    }
}