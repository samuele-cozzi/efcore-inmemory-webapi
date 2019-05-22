using System;
using Microsoft.EntityFrameworkCore;    

namespace efcore_inmemory_webapi.Models
{
    public class TodoContext: DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<Todo> TodoItems { get; set; }
    }
}
