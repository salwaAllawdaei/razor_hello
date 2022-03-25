using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razor_hello.Pages;

public class AboutModel : PageModel
{
    private readonly ILogger<AboutModel> _logger;

    public AboutModel(ILogger<AboutModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        Console.WriteLine("Hello World!");
    }
    // string msg = "hello";
    // public void DebugLog(String msg)
    // {

    //     System.Diagnostics.Debug.WriteLine(msg);
    // }
}

