using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FS.Todo.Core.Models
{
    public class TodoModel
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public bool IsCompleted { get; set; }
    }
}