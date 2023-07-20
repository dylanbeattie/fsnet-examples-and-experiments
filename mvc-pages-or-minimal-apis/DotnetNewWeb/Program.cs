var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapGet("/minimal-apis", SayHelloFromMinimalApis);
app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

string SayHelloFromMinimalApis() 
    => $"Hello from Minimal APIs. The time is {DateTimeOffset.Now:O}";

    