using Microsoft.AspNetCore.Mvc.RazorPages;
using MyHomepage.Models;

namespace MyHomepage.Pages
{
    public class GenShinModel : PageModel
    {
        private readonly ILogger<GenShinModel> _logger;

        public GenShinModel(ILogger<GenShinModel> logger)
        {
            _logger = logger;
        }

        public UserModel User { get; set; } = default!;

        public void OnGet()
        {

        }

    }
}