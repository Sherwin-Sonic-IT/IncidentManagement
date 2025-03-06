using IncidentManagement.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.FluentUI.AspNetCore.Components;
using SharedLibrary.AuthenticationInterface;
using SharedLibrary.Dictionaries;
using SharedLibrary.Interfaces;




var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddFluentUIComponents();


builder.Services.AddSingleton<IncidentFormDictionary>();


builder.Services.AddScoped<IIncident, IncidentService>();
builder.Services.AddScoped<IBoard, BoardService>();
builder.Services.AddScoped<IAuthenticationInterface, AuthenticationService>();


builder.Services.AddScoped<IApplication, ApplicationSvc>();
builder.Services.AddScoped<IMDApi, MDApiSvc>();
builder.Services.AddScoped<IRoleGrpDetail, RoleGrpDetailSvc>();
builder.Services.AddScoped<IRoleGrpHeader, RoleGrpHeaderSvc>();
builder.Services.AddScoped<IUser, UserSvc>();
builder.Services.AddScoped<ISystemRole, SystemRoleSvc>();

builder.Services.AddScoped(http => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress),
});



await builder.Build().RunAsync();






