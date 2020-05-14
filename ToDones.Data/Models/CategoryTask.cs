using System;
using System.Collections.Generic;
using System.Text;

namespace ToDones.Data.Models
{
    public class CategoryTask
    {
        public Task Task { get; set; }
        public int TaskId { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
