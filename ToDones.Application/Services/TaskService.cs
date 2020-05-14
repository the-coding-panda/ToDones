using System;
using System.Linq;
using ToDones.Application.Abstractions;
using ToDones.Data.Data;

namespace ToDones.Application.Services
{
    public class TaskService : ITaskService
    {
        private readonly ToDonesContext _dbContext;

        public TaskService()
        {
            _dbContext = new ToDonesContext();
        }

        public void CreateTask(int userId, string description)
        {
            _dbContext.Tasks.Add(new Data.Models.Task
            {
                UserId = userId,
                Description = description,
                Created = DateTime.Now
            });

            _dbContext.SaveChanges();
        }

        public void EditTask(int taskId, string description)
        {
            var task = _dbContext.Tasks.FirstOrDefault(r => r.Id == taskId);
            task.Description = description;

            _dbContext.SaveChanges();
        }

        public void MarkTaskAsComplete(int taskId)
        {
            var task = _dbContext.Tasks.FirstOrDefault(r => r.Id == taskId);
            task.IsDone = true;

            _dbContext.SaveChanges();
        }
    }
}
