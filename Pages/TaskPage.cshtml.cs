using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace дз9.Pages
{
    public class TaskPageModel : PageModel
    {
        private readonly ITaskService _taskService;

        public TaskPageModel(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [BindProperty]
        [Required(ErrorMessage = "У задачи должен быть заголовок")]
        public required string Title { get; set; }

        [BindProperty]
        public string? Description { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            _taskService.CreateTask(Title, Description);

            return RedirectToPage("/Index");
        }
    }
}
