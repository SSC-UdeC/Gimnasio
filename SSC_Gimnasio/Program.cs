using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;
using SSC_Gimnasio.Client.Pages;
using SSC_Gimnasio.Components;
using SSC_Gimnasio.Modelos;
using SSC_Gimnasio;
using KristofferStrube.Blazor.MediaCaptureStreams;
using SSC_Gimnasio.Repositorio;
using SSC_Gimnasio.Repositorios;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddMediaDevicesService();
builder.Services.AddScoped<IRepositorioClientes, RepositorioClientes>();
builder.Services.AddScoped<IRepositorioVisitas, RepositorioVisitas>();
builder.Services.AddDbContext<GymnasioDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConecction")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(SSC_Gimnasio.Client._Imports).Assembly);

app.Run();
