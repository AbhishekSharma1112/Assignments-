using Microsoft.OpenApi.Models;
using MyWebApp.Models;

var webApplicationOptions = new WebApplicationOptions
{
    ContentRootPath = AppContext.BaseDirectory,
    Args = args,
};
var builder = WebApplication.CreateBuilder(webApplicationOptions);
// Add services to the container.
builder.Services.AddRazorPages();

// Configure logging
builder.Logging.AddConsole();

// Configure app settings
builder.Configuration.AddJsonFile("appsettings.json");

// builder.Services.AddTransient<IMath, MyWebApp.Models.Math>();
builder.Services.AddSingleton<IMath, MyWebApp.Models.Math>();
//builder.Services.AddScoped<IMath, MyWebApp.Models.Math>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c  =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Math API", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "Math API v1");
        options.RoutePrefix = string.Empty;
    }
        );
}

app.UseHttpsRedirection();

app.MapGet("/hello", () =>"HelloWorld");

app.UseAuthorization();

app.MapControllers();

app.Run();
