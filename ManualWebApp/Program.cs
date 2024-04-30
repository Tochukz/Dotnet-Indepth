using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async (HttpContext context) =>
{
    string name = context.Request.Query["name"];
    context.Response.StatusCode = 200;
    context.Response.ContentType = "text/html";
    await context.Response.WriteAsync($"Hello world, {name}!");
});

app.Run();
