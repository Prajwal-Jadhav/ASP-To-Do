using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Data
{
    public class Todo
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        public string Title { get; set; }

        public bool IsCompleted { get; set; } = false;
    }
}
