using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoApp.Models;

namespace ToDoApp.Pages.ToDo
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public CreateToDoBindingModel Input { get; set; }

        readonly TaskService _service;
        public CreateModel(TaskService service)
        {
            _service = service;
        }

        public void OnGet()
        {
            Page();
        }

        public IActionResult OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Task<int> id =  _service.CreateTask(Input);
            return RedirectToPage("Index");
        }

    }
}
