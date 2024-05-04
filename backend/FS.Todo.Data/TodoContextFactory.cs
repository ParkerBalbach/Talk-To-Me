using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace FS.Todo.Data
{

    public class TodoContextFactory : IDesignTimeDbContextFactory<TodoContext> {

        public TodoContext CreateDbContext(String[] args) {

            var optionsBuilder = new DbContextOptionsBuilder<TodoContext>();
            optionsBuilder.UseSqlite("Data Source=todos.db");

            return new TodoContext(optionsBuilder.Options);

        }
    }
}