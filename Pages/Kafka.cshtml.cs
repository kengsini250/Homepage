using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyHomepage.Pages
{

    public class KafkaModel : PageModel
    {
        private readonly ILogger<KafkaModel> _logger;

        public KafkaModel(ILogger<KafkaModel> logger)
        {
            _logger = logger;
        }

       
        public void OnGet()
        {

        }
        

    }
}