using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Models;
using ToDoApp.Data;
using System.Diagnostics;

namespace ToDoApp
{
    public class TaskService
    {
        readonly ToDoContext _context;

        public TaskService(ToDoContext context)
        {
            _context = context;
        }

        public async Task<int> CreateTask(CreateToDoBindingModel input)
        {
            ToDoApp.Data.Todo task = new()
            {
                Title = input.Title,
                IsCompleted = input.IsCompleted
            };

            _context.Add(task);
            await _context.SaveChangesAsync();
            Debug.WriteLine("Successfully saved task.");
            return task.Id;
        }
    }
}
