using System;
using System.Linq;
using ToDones.Application.Abstractions;
using ToDones.Data.Data;
using ToDones.Data.Models;

namespace ToDones.Application.Services
{
    public class TimeLogService : ITimeLogService
    {
        private readonly ToDonesContext _dbContext;

        public TimeLogService()
        {
            _dbContext = new ToDonesContext();
        }

        public void EndTimer(int timeLogId)
        {
            var timeLog = _dbContext.TimeLogs.FirstOrDefault(r => r.Id == timeLogId);

            timeLog.End = DateTime.Now;
            _dbContext.SaveChanges();
        }

        public void StartTimer(int taskId)
        {
            var timeLog = new TimeLog
            {
                TaskId = taskId,
                Start = DateTime.Now,
                Created = DateTime.Now
            };

            _dbContext.TimeLogs.Add(timeLog);
            
        }
    }
}
