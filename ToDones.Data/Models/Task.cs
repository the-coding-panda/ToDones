using System;
using System.Collections.Generic;
using System.Text;
using ToDones.Data.Abstractions;

namespace ToDones.Data.Models
{
    public class Task : Entity
    {
        public string Description { get; set; }
        public bool IsDone { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public List<TimeLog> TimeLogs { get; set; }
        public List<CategoryTask> CategoryTasks { get; set; }
    }
}
