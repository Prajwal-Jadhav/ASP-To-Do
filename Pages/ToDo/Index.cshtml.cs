using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ToDoApp.Data;

namespace ToDoApp.Pages.ToDo
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Data.Todo> ToDos { get; set; }

        readonly ToDoContext _context;

        public IndexModel(ToDoContext context)
        {
            _context = context;
        }

        public async System.Threading.Tasks.Task OnGet()
        {
            ToDos = await _context.Todos.ToListAsync();
        }

    }
}
