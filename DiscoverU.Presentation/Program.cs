using DiscoverU.Presentation;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:7001/api/") });
=======
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7001/") });

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
>>>>>>> 23e90a8620a288344b5ec26f8f36d92fe3a49f3f
=======
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7001/") });

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
>>>>>>> 23e90a8620a288344b5ec26f8f36d92fe3a49f3f
=======
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7001/") });

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
>>>>>>> 23e90a8620a288344b5ec26f8f36d92fe3a49f3f
=======
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7001/") });

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
>>>>>>> 23e90a8620a288344b5ec26f8f36d92fe3a49f3f

await builder.Build().RunAsync();
