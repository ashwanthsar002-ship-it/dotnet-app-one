var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/test", () => "Hello, Welcome to the API!");
app.MapGet("/api/time", () => DateTime.Now);

app.Run();
