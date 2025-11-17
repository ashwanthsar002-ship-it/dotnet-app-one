var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello, Welcome to the API!");
app.MapGet("/api/time", () => DateTime.Now);

app.Run();
