using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using ToDones.Data.Abstractions;

namespace ToDones.Data.Models
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public List<Task> Tasks { get; set; }
        public List<Category> Categories { get; set; }
    }
}
