var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => new
{
    service = "CatalogService",
    status = "Running"
});

app.Run();
