﻿using Microsoft.AspNetCore.Mvc.RazorPages;
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

        public UsersModel Users;
        public void OnPost()
        {
            Users.Username = Request.Query["username"];
            Users.Password = Request.Query["password"];
        }
    }
}