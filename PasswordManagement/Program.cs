using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using PasswordManagement.Services;
using Syncfusion.Blazor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<IClipboardService, ClipboardService>();
builder.Services.AddSingleton<PasswordService>();
builder.Services.AddHttpClient<IPasswordService, PasswordService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7154/");
});
builder.Services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = true; });


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    //app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
