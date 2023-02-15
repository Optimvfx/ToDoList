using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Data.DataItem;
using ToDoList.Models;

namespace ToDoList.Data
{
    public class TaskContext
    {
        private readonly TaskDbContext _dbContext;

        public TaskContext(TaskDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<TaskItem> GetAll()
        {
            return _dbContext.Tasks;
        }

        public void Add(TaskInput input)
        {
            TaskItem task = input.ConvertToBaseValue();

            _dbContext.Tasks.Add(task);

            SaveChanges();
        }

        public void Remove(Guid id)
        {
            var task = Get(id);

            _dbContext.Tasks.Remove(task);

            SaveChanges();
        }

        public void Complete(Guid taskId)
        {
           var task = Get(taskId);

           task.IsCompleted = true;

           _dbContext.Tasks.Update(task);
           
           SaveChanges();
        }

        public TaskItem Get(Guid id)
        {
            if (Contains(id) == false)
                throw new NullReferenceException();

            return _dbContext.Tasks.First(task => task.Id == id);
        }

        public bool Contains(Guid id)
        {
            return _dbContext.Tasks.Any(task => task.Id == id);
        }

        private void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}