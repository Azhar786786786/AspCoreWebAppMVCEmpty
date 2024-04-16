// 1) This is first way to run the console message
//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();
//app.MapGet("/", () => "Hello World!");
//app.Run();


// 2) This is second way to run the console message
//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();
//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("This is first middleware");
//});
//app.Run();


// 3) This is third way to run the multiple console message but it will not work with Run middleware
//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();
//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Wecome to ASP.NET Core 6 Projects with using Run Middleware first");
//});
//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Wecome to ASP.NET Core 6 Projects with using Run Middleware second");
//});
//app.Run();


// 4) This is fourth way to run the multiple console message and it will work with Use Middleware and Run middleware
//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();
//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("Wecome to ASP.NET Core 6 Projects with using Use Middleware first\n");
//    await next(context);
//});

//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("Wecome to ASP.NET Core 6 Projects with using Use Middleware second\n");
//    await next(context);
//});

//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Wecome to ASP.NET Core 6 Projects with using Run Middleware");
//});
//app.Run();



// 5) This is fifth way to run the mvc application with default routing
//var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddControllersWithViews();

//var app = builder.Build();
//app.MapDefaultControllerRoute();

//app.Run();



// 6) This is sixth way to run the mvc application with conventional routing
//var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddControllersWithViews();

//var app = builder.Build();
//app.MapControllerRoute(
//    name: "Defualt",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Run();



// 7) This is seventh way to run the mvc application with Attribute routing
//var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddControllersWithViews();

//var app = builder.Build();
//app.MapControllers();
//app.Run();


// 8) This is eight way to run the mvc application with Conventional and Attribute routing
//var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddControllersWithViews();

//var app = builder.Build();
//app.MapControllerRoute(
//    name: "Defualt",
//    pattern: "{controller=Home}/{action=About}/{id?}");
//app.MapControllers();
//app.Run();


// 9) This is nineth way to run the Http Method
//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();
//app.Map("/", ()=> "Map Method");
//app.Run();



// 10) This is tenth way to run the Http Method with routing
//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();
//app.MapGet("/", () => "MapGet Method!");
//app.MapPost("/", () => "MapPost Method!");
//app.MapDelete("/", () => "MapDelete Method!");
//app.MapPut("/", () => "MapPut Method!");
//app.Run();



// 11) This is eleventh way to run the Http Method with routing
//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();
//app.Map("/", () => "Map Method");
//app.MapGet("/Home", () => "MapGet Method!");
//app.MapPost("/", () => "MapPost Method!");
//app.MapDelete("/", () => "MapDelete Method!");
//app.MapPut("/", () => "MapPut Method!");
//app.Run();



// 12) This is twelveth way to run the Http Method with routing
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/Home", async (context) =>
    {
        await context.Response.WriteAsync("MapGet Method!");
    });
    endpoints.MapPost("/Home", async (context) =>
    {
        await context.Response.WriteAsync("MapPost Method!");
    });
    endpoints.MapPut("/Home", async (context) =>
    {
        await context.Response.WriteAsync("MapPut Method!");
    });
    endpoints.MapDelete("/Home", async (context) =>
    {
        await context.Response.WriteAsync("MapDelete Method!");
    });
});
app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Page Not Found!");
});
app.Run();

