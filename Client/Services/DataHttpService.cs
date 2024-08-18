namespace BlazorApp.Client.Services;

public class DataHttpService
{
    public readonly HttpClient HttpClient;

    public DataHttpService(HttpClient httpClient)
    {
        this.HttpClient = httpClient;
    }

}
