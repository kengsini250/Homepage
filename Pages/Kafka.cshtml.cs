using Microsoft.AspNetCore.Mvc;
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

        [BindProperty] public UsersModel? Users { get; set; }
        public string? a;      
        public string? b;      
        public void OnGet(string _username,string _password)
        {
            a = Users.Username;
            b = Users.Password;
        }
        

    }
}