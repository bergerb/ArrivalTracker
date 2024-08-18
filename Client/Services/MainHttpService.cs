namespace BlazorApp.Client.Services;

public class MainHttpService
{
    public readonly HttpClient httpClient;

    public MainHttpService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }
}
