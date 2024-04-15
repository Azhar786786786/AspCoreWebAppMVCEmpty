var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

//app.MapDefaultControllerRoute();

app.MapControllerRoute(
    name:"Defualt",
    pattern:"{controller=Home}/{action=About}/{id?}");

//app.MapGet("/", () => "Hello World!");

//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Wecome to ASP.NET Core 6 Projects with using Run Middleware");
//});

//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Wecome Back Mere Dosto");
//});

//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("Wecome to ASP.NET Core 6 Projects with using Use Middleware\n");
//    await next(context);
//});

//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("This is next middleware");
//});

app.Run();
