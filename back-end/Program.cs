using dotenv.net;
using Microsoft.AspNetCore.WebSockets;

DotEnv.Load();

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddWebSockets(options => 
{
    options.KeepAliveInterval = TimeSpan.FromMinutes(2);
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    builder.Logging.ClearProviders();
    builder.Logging.AddConsole();
    builder.Logging.SetMinimumLevel(LogLevel.Debug);
    builder.Logging.AddFilter("Microsoft.AspNetCore", LogLevel.Warning);
    app.UseDeveloperExceptionPage();
    app.UseWebSockets();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection()
   .UseHttpMethodOverride()
   .UseStaticFiles()
   .UseRouting()
   .UseAuthorization();

app.MapFallbackToFile("index.html");

app.Run("http://localhost:5000");
