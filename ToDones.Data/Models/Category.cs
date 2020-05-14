using System;
using System.Collections.Generic;
using System.Text;
using ToDones.Data.Abstractions;

namespace ToDones.Data.Models
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public List<CategoryTask> CategoryTasks { get; set; }
    }
}
