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

        public string text = "TEST";
        public void OnGet()
        {
	        text = "TESTSETESTETSETESTETSETEST";
        }

        public UsersModel Users = new();
        public string _username;
        public string _password;
        public void OnPost()
        {
             _username = Request.Query["username"];
             _password = Request.Query["password"];
             Users.Username = _username;
             Users.Password = _password;
        }





    }
}