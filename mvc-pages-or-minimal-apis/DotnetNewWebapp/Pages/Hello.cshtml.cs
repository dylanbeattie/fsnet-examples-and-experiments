using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotnetNewWebapp.Pages;

public class HelloModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public HelloModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public string now => DateTime.Now.ToString("O");

    public void OnGet()
    {

    }
}
