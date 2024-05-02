using dotenv.net;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

DotEnv.Load();

app.UseHttpsRedirection();
app.UseHttpMethodOverride();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "root",
    pattern: "/",
    defaults: new { controller = "Home", action = "Index" });

app.MapControllerRoute(
    name: "Privacy",
    pattern: "/privacy",
    defaults: new { controller = "Home", action = "Privacy" });

app.MapControllerRoute(
    name: "Contact",
    pattern: "/contact",
    defaults: new { controller = "Contact", action = "Index" });

app.MapControllerRoute(
    name: "AdminContact",
    pattern: "/admin_contact",
    defaults: new { controller = "Contact", action = "Admin" });


app.MapControllerRoute(
    name: "Error",
    pattern: "/error",
    defaults: new { controller = "Home", action = "Error" });

app.Run("http://localhost:5000");
