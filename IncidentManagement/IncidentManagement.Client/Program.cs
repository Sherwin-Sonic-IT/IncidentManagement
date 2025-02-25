using IncidentManagement.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.FluentUI.AspNetCore.Components;
using SharedLibrary.Dictionaries;
using SharedLibrary.Interfaces;




var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddFluentUIComponents();


builder.Services.AddSingleton<IncidentFormDictionary>();


builder.Services.AddScoped<IIncident, IncidentService>();
builder.Services.AddScoped<IBoard, BoardService>();
builder.Services.AddScoped(http => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress),
});



await builder.Build().RunAsync();






