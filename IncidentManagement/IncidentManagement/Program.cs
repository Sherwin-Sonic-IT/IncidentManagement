using IncidentManagement.Components;
using IncidentManagement.Data;
using IncidentManagement.Hubs;
using IncidentManagement.Repositories;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FluentUI.AspNetCore.Components;
using SharedLibrary.Dictionaries;
using SharedLibrary.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();
builder.Services.AddFluentUIComponents();

builder.Services.AddSingleton<IncidentFormDictionary>();

// DB Connection 
builder.Services.AddControllers();
builder.Services.AddDbContextFactory<DataContext>(options => { options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection Not Found")); });
builder.Services.AddScoped<IIncident, IncidentRepo>();
builder.Services.AddScoped<IBoard, BoardRepo>();
builder.Services.AddScoped(http => new HttpClient
{
    BaseAddress = new Uri(builder.Configuration.GetSection("BaseAddress").Value!)
});

// DB Connection 


//Log Auth setup
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
{
    options.Cookie.Name = "auth_token";
    options.LoginPath = "/";
    options.LogoutPath = "/";
    options.Cookie.MaxAge = TimeSpan.FromMinutes(30);
    options.AccessDeniedPath = "/access-denied";
});
builder.Services.AddAuthorization();
builder.Services.AddCascadingAuthenticationState();
//Log Auth setup


//builder.Services.AddSignalR();
builder.Services.AddSignalR(options =>
{
    options.EnableDetailedErrors = true;
    options.MaximumReceiveMessageSize = 10 * 1024 * 1024; // 10 MB
});



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


app.UseStatusCodePagesWithReExecute("/page-not-found/{0}");
app.UseHttpsRedirection();
app.MapControllers();
// app use log
app.UseAuthentication();
app.UseAuthorization();
// app use log

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(IncidentManagement.Client._Imports).Assembly);

app.MapHub<CommentHub>("/commentHub");
app.MapHub<IncidentHub>("/incidentHub");



app.Run();
