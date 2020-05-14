using System;
using System.Collections.Generic;
using System.Text;

namespace ToDones.Application.Abstractions
{
    interface ITaskService
    {
        void CreateTask(int userId, string description);
        void EditTask(int taskId, string description);
        void MarkTaskAsComplete(int taskId);
    }
}
