using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyHomepage.Models;

namespace MyHomepage.Pages;

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

    [BindProperty] public UsersModel? Users { get; set; }
    public string a;
    public string b;

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        if (Users != null)
        {
            a = Users.Username;
            b = Users.Password;
        }

        return Page();
        // return RedirectToPage("./Index");
    }
}