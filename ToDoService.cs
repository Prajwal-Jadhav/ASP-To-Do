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
        readonly ToDoContext _context;

        public ToDoService(ToDoContext context)
        {
            _context = context;
        }

        public async Task<int> CreateTask(CreateToDoBindingModel input)
        {
            Todo task = new()
            {
                Title = input.Title,
                IsCompleted = input.IsCompleted
            };

            _context.Add(task);
            await _context.SaveChangesAsync();
            Console.WriteLine("Successfully saved task.");
            return task.Id;
        }
    }
}
