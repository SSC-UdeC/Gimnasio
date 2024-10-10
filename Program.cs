using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;
using SSC_Gimnasio;
using SSC_Gimnasio.Modelos;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddDbContext<GymnasioDBContext>(options =>
                    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConecction")));
await builder.Build().RunAsync();
