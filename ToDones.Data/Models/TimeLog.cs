using System;
using System.Collections.Generic;
using System.Text;
using ToDones.Data.Abstractions;

namespace ToDones.Data.Models
{
    public class TimeLog : Entity
    {
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }
        public int TaskId { get; set; }
        public Task Task { get; set; }
    }
}
