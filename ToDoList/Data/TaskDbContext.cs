using Microsoft.EntityFrameworkCore;
using ToDoList.Data.DataItem;
using ToDoList.Models;

namespace ToDoList.Data
{
    public class TaskDbContext : DbContext 
    {
        public DbSet<TaskItem> Tasks { get; set; }

        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options)
        {
            
        }
    }
}