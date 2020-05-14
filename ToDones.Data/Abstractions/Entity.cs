using System;
using System.Collections.Generic;
using System.Text;

namespace ToDones.Data.Abstractions
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
    }
}
