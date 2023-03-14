using API.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ToDoDbContext toDoDbContext)
        {
            if (toDoDbContext.List.Any()) return;

            var lists = new List<List> {
                new List {
                    Name = "General",
                    Description = "For uncategorized tasks"
                },
                new List {
                    Name = "Book",
                    Description = "For books related tasks"
                }
            };

            foreach (var list in lists)
            {
                toDoDbContext.List.Add(list);
            }

            toDoDbContext.SaveChanges();
        }
    }
}