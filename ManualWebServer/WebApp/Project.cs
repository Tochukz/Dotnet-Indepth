using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using ServiceLib;

var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.MapGet("/", async (HttpContext context) =>
{
    string name = context.Request.Query["name"];
    MessageService service = new MessageService();
    string message = service.GetMessage(name);
    await context.Response.WriteAsync(message);
});
app.Run();