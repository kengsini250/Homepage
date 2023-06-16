using Microsoft.AspNetCore.Mvc.RazorPages;
using MyHomepage.Models;

namespace MyHomepage.Pages
{

    public class KafkaModel : PageModel
    {
        private readonly ILogger<KafkaModel> _logger;

        public KafkaModel(ILogger<KafkaModel> logger)
        {
            _logger = logger;
        }

        public string _username;
        public string _password;
        public void OnGet()
        {

        }
        

    }
}