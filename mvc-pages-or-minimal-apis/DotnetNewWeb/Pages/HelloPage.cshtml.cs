using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotnetNewWeb.Pages;

public class HelloPageModel : PageModel {
    public string Now {get;set;}

    public void OnGet()
    {
        Now = DateTimeOffset.Now.ToString("O");
    }
}
