using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Models;
using ToDoApp.Data;
using System.Diagnostics;

namespace ToDoApp
{
    public class ToDoService
    {
        private readonly ToDoContext _context;

        public ToDoService(ToDoContext context)
        {
            _context = context;
        }

        public async Task CreateTask(CreateToDoBindingModel input)
        {
            Todo todo = new()
            {
                Title = input.Title,
                IsCompleted = input.IsCompleted
            };

            _context.Add(todo);
            await _context.SaveChangesAsync();
        }
    }
}
