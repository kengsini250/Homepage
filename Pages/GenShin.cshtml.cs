using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyHomepage.Pages
{
    public class GenShinModel : PageModel
    {
        private readonly ILogger<GenShinModel> _logger;

        public GenShinModel(ILogger<GenShinModel> logger)
        {
            _logger = logger;
        }
        
        public void OnGet()
        {

        }
    }

}