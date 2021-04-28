using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class CreateToDoBindingModel
    {
        [Required(ErrorMessage = "Title is a required field")]
        [MaxLength(10, ErrorMessage = "Length cannot be greater than 10 characters")]
        public string Title { get; set; }
        public bool IsCompleted { get; set; } = false;
        public DateTime DateCreated { get; set; }

    }
}
