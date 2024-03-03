var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // MVC tarafı için kullanılan bir servistir.

var app = builder.Build();

// {controller=Home}/{action=Index}/{id?}
// app.MapDefaultControllerRoute(); 
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run(); 
