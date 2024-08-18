using BlazorApp.Client;
using BlazorApp.Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["API_Prefix"] ?? builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped(sp => new MainHttpService(
    new HttpClient { BaseAddress = new Uri(builder.Configuration["API_Prefix"] ?? builder.HostEnvironment.BaseAddress) }
    ));

builder.Services.AddScoped(sp => new DataHttpService(
    new HttpClient { BaseAddress = new Uri(builder.Configuration["Data_Prefix"] ?? builder.HostEnvironment.BaseAddress) }
    ));

await builder.Build().RunAsync();
