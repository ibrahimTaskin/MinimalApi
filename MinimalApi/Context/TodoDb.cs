using Microsoft.EntityFrameworkCore;
using MinimalApi.Model;

namespace MinimalApi.Context
{
    public class TodoDb: DbContext
    {
      public TodoDb(DbContextOptions<TodoDb> options) : base(options)
        {
        }
        public DbSet<Todo> Todos => Set<Todo>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().HasKey(t => t.Id);
        }
    }
}
