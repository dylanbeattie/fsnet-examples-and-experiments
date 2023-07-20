namespace DotnetNewWeb.Models;
public class HelloModel {
    public string Now { get;set;}
    public HelloModel(DateTimeOffset now)
        => Now = now.ToString("O");

}