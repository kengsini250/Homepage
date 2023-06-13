using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyHomepage.Pages
{
    public class KrrModel : PageModel
    {
        private readonly ILogger<KrrModel> _logger;

        public KrrModel(ILogger<KrrModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}